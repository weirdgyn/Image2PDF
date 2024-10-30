using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using System.Media;
using System.Text;

namespace Image2PDF
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            cbPageSize.DataSource = Enum.GetValues(typeof(PageSize));
        }

        private void CreateDoc(string srcFilename, string folder, PageSize pageSize)
        {
            string dstFilename = System.IO.Path.Combine(folder, System.IO.Path.GetFileNameWithoutExtension(srcFilename) + ".pdf");

            using PdfWriter writer = new(dstFilename);
            using PdfDocument pdfDocument = new(writer);


            iText.IO.Image.ImageData imageData = iText.IO.Image.ImageDataFactory.Create(srcFilename);

            iText.Layout.Element.Image image = new(imageData);

            iText.Kernel.Geom.Rectangle? rectangle = null;

            if (pageSize == PageSize.ImageSize)
            {
                rectangle = new(0, 0, (int)image.GetImageWidth(), (int)image.GetImageHeight());
            }
            else
            {
                rectangle = pageSize.PdfSize();
                if (rectangle != null)
                    image.ScaleToFit(
                        rectangle.GetWidth(),
                        rectangle.GetHeight());
                else throw new Exception("Page size not supported!");
            }

            if (rectangle == null)
                throw new Exception("Page not created!");

            iText.Layout.Document document = new(pdfDocument, new iText.Kernel.Geom.PageSize(rectangle));

            float offX = (rectangle.GetWidth() - image.GetImageScaledWidth()) / 2;
            float offY = (rectangle.GetHeight() - image.GetImageScaledHeight()) / 2;

            image.SetFixedPosition(offX, offY);

            document.SetMargins(0, 0, 0, 0);

            document.Add(image);
        }

        private void AddFiles(string[] files)
        {
            if (files.Length == 0)
                return;

            foreach (string file in files)
                if (txtImageFile.Lines.Length == 0)
                    txtImageFile.AppendText(file);
                else
                    txtImageFile.AppendText(Environment.NewLine + file);
        }

        private void AddFilesAsync(string[] files)
        {
            if (txtImageFile.InvokeRequired)
                txtImageFile.Invoke(new Action<string[]>(AddFilesAsync), files);
            else
                AddFiles(files);
        }

        private void AddFile(string file)
        {
            if (string.IsNullOrEmpty(file))
                return;

            txtImageFile.AppendText(file);
        }
        private void AddFileAsync(string file)
        {
            if (txtImageFile.InvokeRequired)
                txtImageFile.Invoke(new Action<string>(AddFileAsync), file);
            else
                AddFile(file);
        }

        private void SelectPageSize(string filename)
        {
            using PdfReader reader = new(filename);
            using PdfDocument document = new(reader);
            frmPageSize frmPageSize = new(document);

            if (frmPageSize != null)
            {
                frmPageSize.ShowDialog();

                cbPageSize.SelectedItem = frmPageSize.SelectedPageSize;
            }
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            if (dlgSelectImageFile.ShowDialog() == DialogResult.OK)
            {
                string[] files = dlgSelectImageFile.FileNames;

                txtImageFile.Clear();

                AddFiles(files);
            }
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            if (dlgSelectFolder.ShowDialog() == DialogResult.OK)
            {
                txtDestinationFolder.Text = dlgSelectFolder.SelectedPath;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtImageFile.Text))
                return;

            string[] delimiters = { Environment.NewLine };
            string[] lines = txtImageFile.Text.Split(delimiters,
                                                     StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);

            foreach (string file in lines)
            {
                string? folder;

                if (string.IsNullOrWhiteSpace(txtDestinationFolder.Text))
                    folder = System.IO.Path.GetDirectoryName(file);
                else
                    folder = txtDestinationFolder.Text;

                if (folder == null) folder = "";
                
                PageSize pageSize;
                
                Enum.TryParse(cbPageSize.SelectedValue.ToString(), out pageSize);

                CreateDoc(file, folder, pageSize);
            }

            SystemSounds.Beep.Play();
        }

        private void btnSelectPageSize_Click(object sender, EventArgs e)
        {
            if (dlgSelectPDFFile.ShowDialog() != DialogResult.OK)
                return;

            SelectPageSize(dlgSelectPDFFile.FileName);
        }

        private void txtImageFile_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data is null)
                return;

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                AddFiles(files);
            }
            else if (e.Data.GetDataPresent("text/x-moz-url"))
            {
                var data = (MemoryStream)e.Data.GetData("text/x-moz-url");

                var url = Encoding.Unicode.GetString(data.ToArray()).Trim('\n', '\0');

                AddImageFromUrl(url);
            }
        }

        private async void AddImageFromUrl(string url)
        {
            using var client = new HttpClient();
            var data = await client.GetByteArrayAsync(url);

            using var buffer = new MemoryStream(data);
            var image = Image.FromStream(buffer);

            var guid = Guid.NewGuid().ToString();

            var temp = System.IO.Path.GetTempPath();

            var filename = System.IO.Path.Combine(temp, guid + ".bmp");

            image.Save(filename);

            AddFileAsync(filename);
        }

        private void txtImageFile_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data is null)
                return;

            if (e.Data.GetDataPresent(DataFormats.FileDrop) || e.Data.GetDataPresent("text/x-moz-url"))
                e.Effect = DragDropEffects.Copy;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            dlgSelectImageFile.Filter = Properties.Resources.FileTypes;

            cbPageSize.SelectedIndex = 0;

            if (!string.IsNullOrWhiteSpace(Properties.Settings.Default.DestinationFolder))
                txtDestinationFolder.Text = Properties.Settings.Default.DestinationFolder;
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtDestinationFolder.Text))
                if (Directory.Exists(txtDestinationFolder.Text))
                {
                    Properties.Settings.Default.DestinationFolder = txtDestinationFolder.Text;
                    Properties.Settings.Default.Save();
                }
        }

        private void miClear_Click(object sender, EventArgs e)
        {
            txtImageFile.Clear();
        }

        private void cmsImages_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            miClear.Enabled = !string.IsNullOrWhiteSpace(txtImageFile.Text);
        }

        private void cbPageSize_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data is null)
                return;

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;

        }

        private void cbPageSize_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data is null)
                return;

            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            SelectPageSize(files[0]);
        }
    }
}