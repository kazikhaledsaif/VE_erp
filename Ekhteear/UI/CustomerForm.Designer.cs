namespace Ekhteear.UI
{
    partial class CustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.searchByName = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel32 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.customerGridView = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.backButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.deleteButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.updateButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.addButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.refreshButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.maximizeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.crossButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.minimizeButton = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.customerGridView)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maximizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crossButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // searchByName
            // 
            this.searchByName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchByName.BorderColor = System.Drawing.Color.SeaGreen;
            this.searchByName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.searchByName.Location = new System.Drawing.Point(926, 101);
            this.searchByName.Multiline = true;
            this.searchByName.Name = "searchByName";
            this.searchByName.Size = new System.Drawing.Size(171, 30);
            this.searchByName.TabIndex = 66;
            this.searchByName.TextChanged += new System.EventHandler(this.searchByName_TextChanged);
            // 
            // bunifuCustomLabel32
            // 
            this.bunifuCustomLabel32.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel32.AutoSize = true;
            this.bunifuCustomLabel32.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel32.Location = new System.Drawing.Point(813, 107);
            this.bunifuCustomLabel32.Name = "bunifuCustomLabel32";
            this.bunifuCustomLabel32.Size = new System.Drawing.Size(107, 17);
            this.bunifuCustomLabel32.TabIndex = 65;
            this.bunifuCustomLabel32.Text = "Search by Name";
            // 
            // customerGridView
            // 
            this.customerGridView.AllowUserToAddRows = false;
            this.customerGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.customerGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.customerGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customerGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customerGridView.BackgroundColor = System.Drawing.Color.Gray;
            this.customerGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customerGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customerGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.customerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.customerGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.customerGridView.DoubleBuffered = true;
            this.customerGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.customerGridView.EnableHeadersVisualStyles = false;
            this.customerGridView.GridColor = System.Drawing.Color.Black;
            this.customerGridView.HeaderBgColor = System.Drawing.Color.Gray;
            this.customerGridView.HeaderForeColor = System.Drawing.Color.White;
            this.customerGridView.Location = new System.Drawing.Point(0, 140);
            this.customerGridView.Name = "customerGridView";
            this.customerGridView.ReadOnly = true;
            this.customerGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.customerGridView.RowHeadersVisible = false;
            this.customerGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customerGridView.Size = new System.Drawing.Size(1135, 426);
            this.customerGridView.TabIndex = 63;
            this.customerGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerGridView_CellClick);
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
            this.backButton.Location = new System.Drawing.Point(978, 659);
            this.backButton.Margin = new System.Windows.Forms.Padding(5);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(110, 47);
            this.backButton.TabIndex = 69;
            this.backButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.ActiveBorderThickness = 3;
            this.deleteButton.ActiveCornerRadius = 20;
            this.deleteButton.ActiveFillColor = System.Drawing.Color.Gray;
            this.deleteButton.ActiveForecolor = System.Drawing.Color.White;
            this.deleteButton.ActiveLineColor = System.Drawing.Color.Silver;
            this.deleteButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteButton.BackColor = System.Drawing.SystemColors.Control;
            this.deleteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteButton.BackgroundImage")));
            this.deleteButton.ButtonText = "Delete";
            this.deleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.deleteButton.IdleBorderThickness = 2;
            this.deleteButton.IdleCornerRadius = 20;
            this.deleteButton.IdleFillColor = System.Drawing.Color.White;
            this.deleteButton.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.deleteButton.IdleLineColor = System.Drawing.Color.DimGray;
            this.deleteButton.Location = new System.Drawing.Point(566, 600);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(184, 47);
            this.deleteButton.TabIndex = 62;
            this.deleteButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.ActiveBorderThickness = 3;
            this.updateButton.ActiveCornerRadius = 20;
            this.updateButton.ActiveFillColor = System.Drawing.Color.Gray;
            this.updateButton.ActiveForecolor = System.Drawing.Color.White;
            this.updateButton.ActiveLineColor = System.Drawing.Color.Silver;
            this.updateButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.updateButton.BackColor = System.Drawing.SystemColors.Control;
            this.updateButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("updateButton.BackgroundImage")));
            this.updateButton.ButtonText = "Update";
            this.updateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.updateButton.IdleBorderThickness = 2;
            this.updateButton.IdleCornerRadius = 20;
            this.updateButton.IdleFillColor = System.Drawing.Color.White;
            this.updateButton.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.updateButton.IdleLineColor = System.Drawing.Color.DimGray;
            this.updateButton.Location = new System.Drawing.Point(366, 600);
            this.updateButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(184, 47);
            this.updateButton.TabIndex = 61;
            this.updateButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // addButton
            // 
            this.addButton.ActiveBorderThickness = 3;
            this.addButton.ActiveCornerRadius = 20;
            this.addButton.ActiveFillColor = System.Drawing.Color.Gray;
            this.addButton.ActiveForecolor = System.Drawing.Color.White;
            this.addButton.ActiveLineColor = System.Drawing.Color.Silver;
            this.addButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addButton.BackColor = System.Drawing.SystemColors.Control;
            this.addButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addButton.BackgroundImage")));
            this.addButton.ButtonText = "Add";
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addButton.IdleBorderThickness = 2;
            this.addButton.IdleCornerRadius = 20;
            this.addButton.IdleFillColor = System.Drawing.Color.White;
            this.addButton.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addButton.IdleLineColor = System.Drawing.Color.DimGray;
            this.addButton.Location = new System.Drawing.Point(166, 600);
            this.addButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(184, 47);
            this.addButton.TabIndex = 60;
            this.addButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.ActiveBorderThickness = 3;
            this.refreshButton.ActiveCornerRadius = 20;
            this.refreshButton.ActiveFillColor = System.Drawing.Color.Gray;
            this.refreshButton.ActiveForecolor = System.Drawing.Color.White;
            this.refreshButton.ActiveLineColor = System.Drawing.Color.Silver;
            this.refreshButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.refreshButton.BackColor = System.Drawing.SystemColors.Control;
            this.refreshButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("refreshButton.BackgroundImage")));
            this.refreshButton.ButtonText = "Refresh";
            this.refreshButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.refreshButton.IdleBorderThickness = 2;
            this.refreshButton.IdleCornerRadius = 20;
            this.refreshButton.IdleFillColor = System.Drawing.Color.White;
            this.refreshButton.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.refreshButton.IdleLineColor = System.Drawing.Color.DimGray;
            this.refreshButton.Location = new System.Drawing.Point(766, 600);
            this.refreshButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(184, 47);
            this.refreshButton.TabIndex = 64;
            this.refreshButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
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
            this.bunifuGradientPanel1.TabIndex = 59;
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
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 728);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.searchByName);
            this.Controls.Add(this.bunifuCustomLabel32);
            this.Controls.Add(this.customerGridView);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerGridView)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.maximizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crossButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuThinButton2 backButton;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox searchByName;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel32;
        public Bunifu.Framework.UI.BunifuCustomDataGrid customerGridView;
        private Bunifu.Framework.UI.BunifuThinButton2 deleteButton;
        private Bunifu.Framework.UI.BunifuThinButton2 updateButton;
        private Bunifu.Framework.UI.BunifuThinButton2 addButton;
        private Bunifu.Framework.UI.BunifuThinButton2 refreshButton;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuImageButton maximizeButton;
        private Bunifu.Framework.UI.BunifuImageButton crossButton;
        private Bunifu.Framework.UI.BunifuImageButton minimizeButton;
    }
}