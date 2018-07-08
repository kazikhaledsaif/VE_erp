namespace Ekhteear.UI
{
    partial class ProductForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductForm));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.SearchType = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel34 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SearchProduct = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel32 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.productsgridview = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.backButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.productdelete = new Bunifu.Framework.UI.BunifuThinButton2();
            this.productupdate = new Bunifu.Framework.UI.BunifuThinButton2();
            this.productadd = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ProductRefreshButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.maximizeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.crossButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.minimizeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.productsgridview)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maximizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crossButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // SearchType
            // 
            this.SearchType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchType.BorderColor = System.Drawing.Color.SeaGreen;
            this.SearchType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.SearchType.Location = new System.Drawing.Point(636, 78);
            this.SearchType.Multiline = true;
            this.SearchType.Name = "SearchType";
            this.SearchType.Size = new System.Drawing.Size(171, 30);
            this.SearchType.TabIndex = 56;
            this.SearchType.TextChanged += new System.EventHandler(this.SearchByType_TextChanged);
            // 
            // bunifuCustomLabel34
            // 
            this.bunifuCustomLabel34.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel34.AutoSize = true;
            this.bunifuCustomLabel34.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel34.Location = new System.Drawing.Point(530, 84);
            this.bunifuCustomLabel34.Name = "bunifuCustomLabel34";
            this.bunifuCustomLabel34.Size = new System.Drawing.Size(100, 17);
            this.bunifuCustomLabel34.TabIndex = 55;
            this.bunifuCustomLabel34.Text = "Search by Type";
            // 
            // SearchProduct
            // 
            this.SearchProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchProduct.BorderColor = System.Drawing.Color.SeaGreen;
            this.SearchProduct.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.SearchProduct.Location = new System.Drawing.Point(926, 78);
            this.SearchProduct.Multiline = true;
            this.SearchProduct.Name = "SearchProduct";
            this.SearchProduct.Size = new System.Drawing.Size(171, 30);
            this.SearchProduct.TabIndex = 54;
            this.SearchProduct.TextChanged += new System.EventHandler(this.SearchProduct_TextChanged);
            // 
            // bunifuCustomLabel32
            // 
            this.bunifuCustomLabel32.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel32.AutoSize = true;
            this.bunifuCustomLabel32.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel32.Location = new System.Drawing.Point(813, 84);
            this.bunifuCustomLabel32.Name = "bunifuCustomLabel32";
            this.bunifuCustomLabel32.Size = new System.Drawing.Size(107, 17);
            this.bunifuCustomLabel32.TabIndex = 53;
            this.bunifuCustomLabel32.Text = "Search by Name";
            // 
            // productsgridview
            // 
            this.productsgridview.AllowUserToAddRows = false;
            this.productsgridview.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.productsgridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.productsgridview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productsgridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productsgridview.BackgroundColor = System.Drawing.Color.Gray;
            this.productsgridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productsgridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productsgridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.productsgridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsgridview.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.productsgridview.DefaultCellStyle = dataGridViewCellStyle3;
            this.productsgridview.DoubleBuffered = true;
            this.productsgridview.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.productsgridview.EnableHeadersVisualStyles = false;
            this.productsgridview.GridColor = System.Drawing.Color.Black;
            this.productsgridview.HeaderBgColor = System.Drawing.Color.Gray;
            this.productsgridview.HeaderForeColor = System.Drawing.Color.White;
            this.productsgridview.Location = new System.Drawing.Point(12, 117);
            this.productsgridview.Name = "productsgridview";
            this.productsgridview.ReadOnly = true;
            this.productsgridview.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.productsgridview.RowHeadersVisible = false;
            this.productsgridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productsgridview.Size = new System.Drawing.Size(1111, 426);
            this.productsgridview.TabIndex = 51;
            this.productsgridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productsgridview_CellClick);
            // 
            // backButton
            // 
            this.backButton.ActiveBorderThickness = 3;
            this.backButton.ActiveCornerRadius = 1;
            this.backButton.ActiveFillColor = System.Drawing.Color.Gray;
            this.backButton.ActiveForecolor = System.Drawing.Color.White;
            this.backButton.ActiveLineColor = System.Drawing.Color.Silver;
            this.backButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.backButton.BackColor = System.Drawing.SystemColors.Control;
            this.backButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backButton.BackgroundImage")));
            this.backButton.ButtonText = "Back";
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.backButton.IdleBorderThickness = 2;
            this.backButton.IdleCornerRadius = 1;
            this.backButton.IdleFillColor = System.Drawing.Color.White;
            this.backButton.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.backButton.IdleLineColor = System.Drawing.Color.DimGray;
            this.backButton.Location = new System.Drawing.Point(978, 636);
            this.backButton.Margin = new System.Windows.Forms.Padding(5);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(110, 47);
            this.backButton.TabIndex = 58;
            this.backButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // productdelete
            // 
            this.productdelete.ActiveBorderThickness = 3;
            this.productdelete.ActiveCornerRadius = 20;
            this.productdelete.ActiveFillColor = System.Drawing.Color.Gray;
            this.productdelete.ActiveForecolor = System.Drawing.Color.White;
            this.productdelete.ActiveLineColor = System.Drawing.Color.Silver;
            this.productdelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.productdelete.BackColor = System.Drawing.SystemColors.Control;
            this.productdelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("productdelete.BackgroundImage")));
            this.productdelete.ButtonText = "Delete";
            this.productdelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.productdelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productdelete.ForeColor = System.Drawing.Color.SeaGreen;
            this.productdelete.IdleBorderThickness = 2;
            this.productdelete.IdleCornerRadius = 20;
            this.productdelete.IdleFillColor = System.Drawing.Color.White;
            this.productdelete.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.productdelete.IdleLineColor = System.Drawing.Color.DimGray;
            this.productdelete.Location = new System.Drawing.Point(566, 577);
            this.productdelete.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.productdelete.Name = "productdelete";
            this.productdelete.Size = new System.Drawing.Size(184, 47);
            this.productdelete.TabIndex = 50;
            this.productdelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.productdelete.Click += new System.EventHandler(this.productdelete_Click);
            // 
            // productupdate
            // 
            this.productupdate.ActiveBorderThickness = 3;
            this.productupdate.ActiveCornerRadius = 20;
            this.productupdate.ActiveFillColor = System.Drawing.Color.Gray;
            this.productupdate.ActiveForecolor = System.Drawing.Color.White;
            this.productupdate.ActiveLineColor = System.Drawing.Color.Silver;
            this.productupdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.productupdate.BackColor = System.Drawing.SystemColors.Control;
            this.productupdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("productupdate.BackgroundImage")));
            this.productupdate.ButtonText = "Update";
            this.productupdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.productupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productupdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.productupdate.IdleBorderThickness = 2;
            this.productupdate.IdleCornerRadius = 20;
            this.productupdate.IdleFillColor = System.Drawing.Color.White;
            this.productupdate.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.productupdate.IdleLineColor = System.Drawing.Color.DimGray;
            this.productupdate.Location = new System.Drawing.Point(366, 577);
            this.productupdate.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.productupdate.Name = "productupdate";
            this.productupdate.Size = new System.Drawing.Size(184, 47);
            this.productupdate.TabIndex = 49;
            this.productupdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.productupdate.Click += new System.EventHandler(this.productupdate_Click);
            // 
            // productadd
            // 
            this.productadd.ActiveBorderThickness = 3;
            this.productadd.ActiveCornerRadius = 20;
            this.productadd.ActiveFillColor = System.Drawing.Color.Gray;
            this.productadd.ActiveForecolor = System.Drawing.Color.White;
            this.productadd.ActiveLineColor = System.Drawing.Color.Silver;
            this.productadd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.productadd.BackColor = System.Drawing.SystemColors.Control;
            this.productadd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("productadd.BackgroundImage")));
            this.productadd.ButtonText = "Add";
            this.productadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.productadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productadd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.productadd.IdleBorderThickness = 2;
            this.productadd.IdleCornerRadius = 20;
            this.productadd.IdleFillColor = System.Drawing.Color.White;
            this.productadd.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.productadd.IdleLineColor = System.Drawing.Color.DimGray;
            this.productadd.Location = new System.Drawing.Point(166, 577);
            this.productadd.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.productadd.Name = "productadd";
            this.productadd.Size = new System.Drawing.Size(184, 47);
            this.productadd.TabIndex = 48;
            this.productadd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.productadd.Click += new System.EventHandler(this.productadd_Click);
            // 
            // ProductRefreshButton
            // 
            this.ProductRefreshButton.ActiveBorderThickness = 3;
            this.ProductRefreshButton.ActiveCornerRadius = 20;
            this.ProductRefreshButton.ActiveFillColor = System.Drawing.Color.Gray;
            this.ProductRefreshButton.ActiveForecolor = System.Drawing.Color.White;
            this.ProductRefreshButton.ActiveLineColor = System.Drawing.Color.Silver;
            this.ProductRefreshButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProductRefreshButton.BackColor = System.Drawing.SystemColors.Control;
            this.ProductRefreshButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ProductRefreshButton.BackgroundImage")));
            this.ProductRefreshButton.ButtonText = "Refresh";
            this.ProductRefreshButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProductRefreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductRefreshButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProductRefreshButton.IdleBorderThickness = 2;
            this.ProductRefreshButton.IdleCornerRadius = 20;
            this.ProductRefreshButton.IdleFillColor = System.Drawing.Color.White;
            this.ProductRefreshButton.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProductRefreshButton.IdleLineColor = System.Drawing.Color.DimGray;
            this.ProductRefreshButton.Location = new System.Drawing.Point(766, 577);
            this.ProductRefreshButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.ProductRefreshButton.Name = "ProductRefreshButton";
            this.ProductRefreshButton.Size = new System.Drawing.Size(184, 47);
            this.ProductRefreshButton.TabIndex = 52;
            this.ProductRefreshButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ProductRefreshButton.Click += new System.EventHandler(this.ProductRefreshButton_Click);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.maximizeButton);
            this.bunifuGradientPanel1.Controls.Add(this.crossButton);
            this.bunifuGradientPanel1.Controls.Add(this.minimizeButton);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1135, 73);
            this.bunifuGradientPanel1.TabIndex = 1;
            // 
            // maximizeButton
            // 
            this.maximizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizeButton.BackColor = System.Drawing.Color.Transparent;
            this.maximizeButton.Image = global::Ekhteear.Properties.Resources.imageedit_5_7285109277;
            this.maximizeButton.ImageActive = null;
            this.maximizeButton.Location = new System.Drawing.Point(1032, 26);
            this.maximizeButton.Name = "maximizeButton";
            this.maximizeButton.Size = new System.Drawing.Size(25, 25);
            this.maximizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.maximizeButton.TabIndex = 4;
            this.maximizeButton.TabStop = false;
            this.maximizeButton.Zoom = 10;
            this.maximizeButton.Click += new System.EventHandler(this.maximizeButton_Click);
            // 
            // crossButton
            // 
            this.crossButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.crossButton.BackColor = System.Drawing.Color.Transparent;
            this.crossButton.Image = global::Ekhteear.Properties.Resources.imageedit_1_7939263489;
            this.crossButton.ImageActive = null;
            this.crossButton.Location = new System.Drawing.Point(1063, 26);
            this.crossButton.Name = "crossButton";
            this.crossButton.Size = new System.Drawing.Size(25, 25);
            this.crossButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.crossButton.TabIndex = 3;
            this.crossButton.TabStop = false;
            this.crossButton.Zoom = 10;
            this.crossButton.Click += new System.EventHandler(this.crossButton_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.minimizeButton.Image = global::Ekhteear.Properties.Resources.imageedit_7_5361398056;
            this.minimizeButton.ImageActive = null;
            this.minimizeButton.Location = new System.Drawing.Point(1002, 27);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(24, 25);
            this.minimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizeButton.TabIndex = 2;
            this.minimizeButton.TabStop = false;
            this.minimizeButton.Zoom = 10;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.bunifuGradientPanel1;
            this.bunifuDragControl2.Vertical = true;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 728);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.SearchType);
            this.Controls.Add(this.bunifuCustomLabel34);
            this.Controls.Add(this.SearchProduct);
            this.Controls.Add(this.bunifuCustomLabel32);
            this.Controls.Add(this.productsgridview);
            this.Controls.Add(this.productdelete);
            this.Controls.Add(this.productupdate);
            this.Controls.Add(this.productadd);
            this.Controls.Add(this.ProductRefreshButton);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsgridview)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.maximizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crossButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuImageButton maximizeButton;
        private Bunifu.Framework.UI.BunifuImageButton crossButton;
        private Bunifu.Framework.UI.BunifuImageButton minimizeButton;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox SearchType;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel34;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox SearchProduct;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel32;
        public Bunifu.Framework.UI.BunifuCustomDataGrid productsgridview;
        private Bunifu.Framework.UI.BunifuThinButton2 productdelete;
        private Bunifu.Framework.UI.BunifuThinButton2 productupdate;
        private Bunifu.Framework.UI.BunifuThinButton2 productadd;
        private Bunifu.Framework.UI.BunifuThinButton2 ProductRefreshButton;
        private Bunifu.Framework.UI.BunifuThinButton2 backButton;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
    }
}