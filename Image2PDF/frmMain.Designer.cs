namespace Image2PDF
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dlgSelectImageFile = new System.Windows.Forms.OpenFileDialog();
            this.dlgSelectFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.lblImage = new System.Windows.Forms.Label();
            this.txtImageFile = new System.Windows.Forms.TextBox();
            this.cmsImages = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miClear = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.txtDestinationFolder = new System.Windows.Forms.TextBox();
            this.lblDestination = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.cbPageSize = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelectPageSize = new System.Windows.Forms.Button();
            this.dlgSelectPDFFile = new System.Windows.Forms.OpenFileDialog();
            this.cmsImages.SuspendLayout();
            this.SuspendLayout();
            // 
            // dlgSelectImageFile
            // 
            this.dlgSelectImageFile.Multiselect = true;
            this.dlgSelectImageFile.Title = "Select image file(s)";
            // 
            // dlgSelectFolder
            // 
            this.dlgSelectFolder.Description = "Select destination folder";
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Location = new System.Drawing.Point(12, 9);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(67, 20);
            this.lblImage.TabIndex = 0;
            this.lblImage.Text = "Image(s)";
            // 
            // txtImageFile
            // 
            this.txtImageFile.AllowDrop = true;
            this.txtImageFile.ContextMenuStrip = this.cmsImages;
            this.txtImageFile.Location = new System.Drawing.Point(106, 6);
            this.txtImageFile.Multiline = true;
            this.txtImageFile.Name = "txtImageFile";
            this.txtImageFile.ReadOnly = true;
            this.txtImageFile.Size = new System.Drawing.Size(340, 298);
            this.txtImageFile.TabIndex = 1;
            this.txtImageFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtImageFile_DragDrop);
            this.txtImageFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtImageFile_DragEnter);
            // 
            // cmsImages
            // 
            this.cmsImages.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsImages.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miClear});
            this.cmsImages.Name = "cmsImages";
            this.cmsImages.Size = new System.Drawing.Size(113, 28);
            this.cmsImages.Opening += new System.ComponentModel.CancelEventHandler(this.cmsImages_Opening);
            // 
            // miClear
            // 
            this.miClear.Name = "miClear";
            this.miClear.Size = new System.Drawing.Size(112, 24);
            this.miClear.Text = "Clear";
            this.miClear.Click += new System.EventHandler(this.miClear_Click);
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.AutoSize = true;
            this.btnSelectFile.Location = new System.Drawing.Point(452, 4);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(39, 30);
            this.btnSelectFile.TabIndex = 2;
            this.btnSelectFile.Text = "...";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectFolder.AutoSize = true;
            this.btnSelectFolder.Location = new System.Drawing.Point(452, 342);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(39, 30);
            this.btnSelectFolder.TabIndex = 5;
            this.btnSelectFolder.Text = "...";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // txtDestinationFolder
            // 
            this.txtDestinationFolder.AllowDrop = true;
            this.txtDestinationFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDestinationFolder.Location = new System.Drawing.Point(106, 344);
            this.txtDestinationFolder.Name = "txtDestinationFolder";
            this.txtDestinationFolder.Size = new System.Drawing.Size(340, 27);
            this.txtDestinationFolder.TabIndex = 4;
            // 
            // lblDestination
            // 
            this.lblDestination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDestination.AutoSize = true;
            this.lblDestination.Location = new System.Drawing.Point(12, 347);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(88, 20);
            this.lblDestination.TabIndex = 3;
            this.lblDestination.Text = "Destination:";
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.Location = new System.Drawing.Point(205, 377);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(94, 29);
            this.btnCreate.TabIndex = 6;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // cbPageSize
            // 
            this.cbPageSize.AllowDrop = true;
            this.cbPageSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPageSize.FormattingEnabled = true;
            this.cbPageSize.Items.AddRange(new object[] {
            "Same as image"});
            this.cbPageSize.Location = new System.Drawing.Point(106, 310);
            this.cbPageSize.Name = "cbPageSize";
            this.cbPageSize.Size = new System.Drawing.Size(340, 28);
            this.cbPageSize.TabIndex = 7;
            this.cbPageSize.DragDrop += new System.Windows.Forms.DragEventHandler(this.cbPageSize_DragDrop);
            this.cbPageSize.DragEnter += new System.Windows.Forms.DragEventHandler(this.cbPageSize_DragEnter);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Page size:";
            // 
            // btnSelectPageSize
            // 
            this.btnSelectPageSize.Location = new System.Drawing.Point(452, 309);
            this.btnSelectPageSize.Name = "btnSelectPageSize";
            this.btnSelectPageSize.Size = new System.Drawing.Size(39, 29);
            this.btnSelectPageSize.TabIndex = 9;
            this.btnSelectPageSize.Text = "...";
            this.btnSelectPageSize.UseVisualStyleBackColor = true;
            this.btnSelectPageSize.Click += new System.EventHandler(this.btnSelectPageSize_Click);
            // 
            // dlgSelectPDFFile
            // 
            this.dlgSelectPDFFile.Filter = "PDF files|*.pdf";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 418);
            this.Controls.Add(this.btnSelectPageSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbPageSize);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnSelectFolder);
            this.Controls.Add(this.txtDestinationFolder);
            this.Controls.Add(this.lblDestination);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.txtImageFile);
            this.Controls.Add(this.lblImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmMain";
            this.Text = "Image2PDF";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.cmsImages.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenFileDialog dlgSelectImageFile;
        private FolderBrowserDialog dlgSelectFolder;
        private Label lblImage;
        private TextBox txtImageFile;
        private Button btnSelectFile;
        private Button btnSelectFolder;
        private TextBox txtDestinationFolder;
        private Label lblDestination;
        private Button btnCreate;
        private ContextMenuStrip cmsImages;
        private ToolStripMenuItem miClear;
        private ComboBox cbPageSize;
        private Label label1;
        private Button btnSelectPageSize;
        private OpenFileDialog dlgSelectPDFFile;
    }
}