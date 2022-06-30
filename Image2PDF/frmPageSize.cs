using iText.Kernel.Pdf;

namespace Image2PDF
{
    public partial class frmPageSize : Form
    {
        public PageSize SelectedPageSize { get; set; }

        public frmPageSize()
        {
            InitializeComponent();
        }

        public frmPageSize(PdfDocument document) : this()
        {
            iText.Kernel.Geom.Rectangle _rect = document.GetDefaultPageSize();

            PageSize _size = PageSizeExtension.SizeOf(_rect);

            ListViewItem _item = new ListViewItem(_size.ToString());
            _item.SubItems.Add("0");
            _item.SubItems.Add(_rect.GetWidth().ToString());
            _item.SubItems.Add(_rect.GetHeight().ToString());

            lvPagesSizes.Items.Add(_item);

            for (int _i = 0; _i < document.GetNumberOfPages(); _i++)
            {
                PdfPage _page = document.GetPage(_i + 1);

                _rect = _page.GetPageSize();

                _size = PageSizeExtension.SizeOf(_rect);

                _item = lvPagesSizes.FindItemWithText(_size.ToString());

                if (_item != null)
                {
                    int _count = int.Parse(_item.SubItems[1].Text.ToString());
                    _count++;
                    _item.SubItems[1].Text = _count.ToString();
                }
                else
                {
                    _item = new ListViewItem(_size.ToString());
                    _item.SubItems.Add("1");
                    _item.SubItems.Add(_rect.GetWidth().ToString());
                    _item.SubItems.Add(_rect.GetHeight().ToString());

                    lvPagesSizes.Items.Add(_item);
                }
            }

            lvPagesSizes.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lvPagesSizes_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem _item;

            if (lvPagesSizes.SelectedItems.Count == 0)
                return;

            _item = lvPagesSizes.SelectedItems[0];

            SelectedPageSize = (PageSize)Enum.Parse(typeof(PageSize), _item.Text);
        }
    }
}
