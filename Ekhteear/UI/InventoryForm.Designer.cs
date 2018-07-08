namespace Ekhteear.UI
{
    partial class InventoryForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryForm));
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Inventorygridview = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.back = new Bunifu.Framework.UI.BunifuThinButton2();
            this.returnGoodsButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.inventoryViewButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.inventoryAddButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.refreshButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.maximizeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.crossButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.minimizeButton = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.Inventorygridview)).BeginInit();
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
            // Inventorygridview
            // 
            this.Inventorygridview.AllowUserToAddRows = false;
            this.Inventorygridview.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Inventorygridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.Inventorygridview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Inventorygridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Inventorygridview.BackgroundColor = System.Drawing.Color.Gray;
            this.Inventorygridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Inventorygridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Inventorygridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.Inventorygridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Inventorygridview.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Inventorygridview.DefaultCellStyle = dataGridViewCellStyle6;
            this.Inventorygridview.DoubleBuffered = true;
            this.Inventorygridview.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Inventorygridview.EnableHeadersVisualStyles = false;
            this.Inventorygridview.GridColor = System.Drawing.Color.Black;
            this.Inventorygridview.HeaderBgColor = System.Drawing.Color.Gray;
            this.Inventorygridview.HeaderForeColor = System.Drawing.Color.White;
            this.Inventorygridview.Location = new System.Drawing.Point(12, 94);
            this.Inventorygridview.Name = "Inventorygridview";
            this.Inventorygridview.ReadOnly = true;
            this.Inventorygridview.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Inventorygridview.RowHeadersVisible = false;
            this.Inventorygridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Inventorygridview.Size = new System.Drawing.Size(1178, 448);
            this.Inventorygridview.TabIndex = 52;
            this.Inventorygridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Inventorygridview_CellClick);
            // 
            // back
            // 
            this.back.ActiveBorderThickness = 3;
            this.back.ActiveCornerRadius = 1;
            this.back.ActiveFillColor = System.Drawing.Color.Gray;
            this.back.ActiveForecolor = System.Drawing.Color.White;
            this.back.ActiveLineColor = System.Drawing.Color.Silver;
            this.back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.back.BackColor = System.Drawing.SystemColors.Control;
            this.back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("back.BackgroundImage")));
            this.back.ButtonText = "Back";
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.back.IdleBorderThickness = 2;
            this.back.IdleCornerRadius = 1;
            this.back.IdleFillColor = System.Drawing.Color.White;
            this.back.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.back.IdleLineColor = System.Drawing.Color.DimGray;
            this.back.Location = new System.Drawing.Point(1066, 609);
            this.back.Margin = new System.Windows.Forms.Padding(5);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(110, 47);
            this.back.TabIndex = 63;
            this.back.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.back.Click += new System.EventHandler(this.BackButtonClick);
            // 
            // returnGoodsButton
            // 
            this.returnGoodsButton.ActiveBorderThickness = 3;
            this.returnGoodsButton.ActiveCornerRadius = 20;
            this.returnGoodsButton.ActiveFillColor = System.Drawing.Color.Gray;
            this.returnGoodsButton.ActiveForecolor = System.Drawing.Color.White;
            this.returnGoodsButton.ActiveLineColor = System.Drawing.Color.Silver;
            this.returnGoodsButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.returnGoodsButton.BackColor = System.Drawing.SystemColors.Control;
            this.returnGoodsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("returnGoodsButton.BackgroundImage")));
            this.returnGoodsButton.ButtonText = "Return Goods";
            this.returnGoodsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.returnGoodsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnGoodsButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.returnGoodsButton.IdleBorderThickness = 2;
            this.returnGoodsButton.IdleCornerRadius = 20;
            this.returnGoodsButton.IdleFillColor = System.Drawing.Color.White;
            this.returnGoodsButton.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.returnGoodsButton.IdleLineColor = System.Drawing.Color.DimGray;
            this.returnGoodsButton.Location = new System.Drawing.Point(589, 573);
            this.returnGoodsButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.returnGoodsButton.Name = "returnGoodsButton";
            this.returnGoodsButton.Size = new System.Drawing.Size(184, 47);
            this.returnGoodsButton.TabIndex = 61;
            this.returnGoodsButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.returnGoodsButton.Click += new System.EventHandler(this.returnGoodsButton_Click);
            // 
            // inventoryViewButton
            // 
            this.inventoryViewButton.ActiveBorderThickness = 3;
            this.inventoryViewButton.ActiveCornerRadius = 20;
            this.inventoryViewButton.ActiveFillColor = System.Drawing.Color.Gray;
            this.inventoryViewButton.ActiveForecolor = System.Drawing.Color.White;
            this.inventoryViewButton.ActiveLineColor = System.Drawing.Color.Silver;
            this.inventoryViewButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.inventoryViewButton.BackColor = System.Drawing.SystemColors.Control;
            this.inventoryViewButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("inventoryViewButton.BackgroundImage")));
            this.inventoryViewButton.ButtonText = "View";
            this.inventoryViewButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inventoryViewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryViewButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inventoryViewButton.IdleBorderThickness = 2;
            this.inventoryViewButton.IdleCornerRadius = 20;
            this.inventoryViewButton.IdleFillColor = System.Drawing.Color.White;
            this.inventoryViewButton.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inventoryViewButton.IdleLineColor = System.Drawing.Color.DimGray;
            this.inventoryViewButton.Location = new System.Drawing.Point(389, 573);
            this.inventoryViewButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.inventoryViewButton.Name = "inventoryViewButton";
            this.inventoryViewButton.Size = new System.Drawing.Size(184, 47);
            this.inventoryViewButton.TabIndex = 60;
            this.inventoryViewButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.inventoryViewButton.Click += new System.EventHandler(this.inventoryViewButton_Click);
            // 
            // inventoryAddButton
            // 
            this.inventoryAddButton.ActiveBorderThickness = 3;
            this.inventoryAddButton.ActiveCornerRadius = 20;
            this.inventoryAddButton.ActiveFillColor = System.Drawing.Color.Gray;
            this.inventoryAddButton.ActiveForecolor = System.Drawing.Color.White;
            this.inventoryAddButton.ActiveLineColor = System.Drawing.Color.Silver;
            this.inventoryAddButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.inventoryAddButton.BackColor = System.Drawing.SystemColors.Control;
            this.inventoryAddButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("inventoryAddButton.BackgroundImage")));
            this.inventoryAddButton.ButtonText = "Add";
            this.inventoryAddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inventoryAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryAddButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inventoryAddButton.IdleBorderThickness = 2;
            this.inventoryAddButton.IdleCornerRadius = 20;
            this.inventoryAddButton.IdleFillColor = System.Drawing.Color.White;
            this.inventoryAddButton.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inventoryAddButton.IdleLineColor = System.Drawing.Color.DimGray;
            this.inventoryAddButton.Location = new System.Drawing.Point(189, 573);
            this.inventoryAddButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.inventoryAddButton.Name = "inventoryAddButton";
            this.inventoryAddButton.Size = new System.Drawing.Size(184, 47);
            this.inventoryAddButton.TabIndex = 59;
            this.inventoryAddButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.inventoryAddButton.Click += new System.EventHandler(this.inventoryAddButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.ActiveBorderThickness = 3;
            this.refreshButton.ActiveCornerRadius = 20;
            this.refreshButton.ActiveFillColor = System.Drawing.Color.Gray;
            this.refreshButton.ActiveForecolor = System.Drawing.Color.White;
            this.refreshButton.ActiveLineColor = System.Drawing.Color.Silver;
            this.refreshButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
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
            this.refreshButton.Location = new System.Drawing.Point(789, 573);
            this.refreshButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(184, 47);
            this.refreshButton.TabIndex = 62;
            this.refreshButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1202, 73);
            this.bunifuGradientPanel1.TabIndex = 1;
            // 
            // maximizeButton
            // 
            this.maximizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizeButton.BackColor = System.Drawing.Color.Transparent;
            this.maximizeButton.Image = global::Ekhteear.Properties.Resources.imageedit_5_7285109277;
            this.maximizeButton.ImageActive = null;
            this.maximizeButton.Location = new System.Drawing.Point(1099, 26);
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
            this.crossButton.Location = new System.Drawing.Point(1130, 26);
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
            this.minimizeButton.Location = new System.Drawing.Point(1069, 27);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(24, 25);
            this.minimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizeButton.TabIndex = 2;
            this.minimizeButton.TabStop = false;
            this.minimizeButton.Zoom = 10;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 669);
            this.Controls.Add(this.back);
            this.Controls.Add(this.returnGoodsButton);
            this.Controls.Add(this.inventoryViewButton);
            this.Controls.Add(this.inventoryAddButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.Inventorygridview);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InventoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InventoryForm";
            this.Load += new System.EventHandler(this.InventoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Inventorygridview)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.maximizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crossButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuImageButton maximizeButton;
        private Bunifu.Framework.UI.BunifuImageButton crossButton;
        private Bunifu.Framework.UI.BunifuImageButton minimizeButton;
        public Bunifu.Framework.UI.BunifuCustomDataGrid Inventorygridview;
        private Bunifu.Framework.UI.BunifuThinButton2 back;
        private Bunifu.Framework.UI.BunifuThinButton2 returnGoodsButton;
        private Bunifu.Framework.UI.BunifuThinButton2 inventoryViewButton;
        private Bunifu.Framework.UI.BunifuThinButton2 inventoryAddButton;
        private Bunifu.Framework.UI.BunifuThinButton2 refreshButton;
    }
}