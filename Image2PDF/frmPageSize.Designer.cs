namespace Image2PDF
{
    partial class frmPageSize
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvPagesSizes = new System.Windows.Forms.ListView();
            this.chSize = new System.Windows.Forms.ColumnHeader();
            this.chCount = new System.Windows.Forms.ColumnHeader();
            this.chWidth = new System.Windows.Forms.ColumnHeader();
            this.chHeight = new System.Windows.Forms.ColumnHeader();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvPagesSizes
            // 
            this.lvPagesSizes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvPagesSizes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chSize,
            this.chCount,
            this.chWidth,
            this.chHeight});
            this.lvPagesSizes.FullRowSelect = true;
            this.lvPagesSizes.Location = new System.Drawing.Point(12, 12);
            this.lvPagesSizes.Name = "lvPagesSizes";
            this.lvPagesSizes.Size = new System.Drawing.Size(347, 391);
            this.lvPagesSizes.TabIndex = 0;
            this.lvPagesSizes.UseCompatibleStateImageBehavior = false;
            this.lvPagesSizes.View = System.Windows.Forms.View.Details;
            this.lvPagesSizes.SelectedIndexChanged += new System.EventHandler(this.lvPagesSizes_SelectedIndexChanged);
            // 
            // chSize
            // 
            this.chSize.Text = "Size";
            // 
            // chCount
            // 
            this.chCount.Text = "Count";
            // 
            // chWidth
            // 
            this.chWidth.Text = "Width";
            // 
            // chHeight
            // 
            this.chHeight.Text = "Height";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(139, 409);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(93, 29);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmPageSize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lvPagesSizes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPageSize";
            this.Text = "Page(s) sizes:";
            this.ResumeLayout(false);

        }

        #endregion
        private ColumnHeader chSize;
        private ColumnHeader chCount;
        private Button btnClose;
        public ListView lvPagesSizes;
        private ColumnHeader chWidth;
        private ColumnHeader chHeight;
    }
}