namespace Ekhteear.UI
{
    partial class CreditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreditorForm));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.creditorGridView = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.maximizeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.crossButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.minimizeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.CreditorSearch = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.creditorDue = new System.Windows.Forms.Label();
            this.creditorId = new System.Windows.Forms.Label();
            this.CreditorCashPaid = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel78 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel76 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel75 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SaveButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.back = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.creditorGridView)).BeginInit();
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
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = null;
            this.bunifuDragControl2.Vertical = true;
            // 
            // creditorGridView
            // 
            this.creditorGridView.AllowUserToAddRows = false;
            this.creditorGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.creditorGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.creditorGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.creditorGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.creditorGridView.BackgroundColor = System.Drawing.Color.Gray;
            this.creditorGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.creditorGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.creditorGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.creditorGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.creditorGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.creditorGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.creditorGridView.DoubleBuffered = true;
            this.creditorGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.creditorGridView.EnableHeadersVisualStyles = false;
            this.creditorGridView.GridColor = System.Drawing.Color.Black;
            this.creditorGridView.HeaderBgColor = System.Drawing.Color.Gray;
            this.creditorGridView.HeaderForeColor = System.Drawing.Color.White;
            this.creditorGridView.Location = new System.Drawing.Point(12, 122);
            this.creditorGridView.Name = "creditorGridView";
            this.creditorGridView.ReadOnly = true;
            this.creditorGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.creditorGridView.RowHeadersVisible = false;
            this.creditorGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.creditorGridView.Size = new System.Drawing.Size(916, 351);
            this.creditorGridView.TabIndex = 54;
            this.creditorGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.creditorGridView_CellClick);
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
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(940, 73);
            this.bunifuGradientPanel1.TabIndex = 55;
            // 
            // maximizeButton
            // 
            this.maximizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizeButton.BackColor = System.Drawing.Color.Transparent;
            this.maximizeButton.Image = global::Ekhteear.Properties.Resources.imageedit_5_7285109277;
            this.maximizeButton.ImageActive = null;
            this.maximizeButton.Location = new System.Drawing.Point(837, 26);
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
            this.crossButton.Location = new System.Drawing.Point(868, 26);
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
            this.minimizeButton.Location = new System.Drawing.Point(807, 27);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(24, 25);
            this.minimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizeButton.TabIndex = 2;
            this.minimizeButton.TabStop = false;
            this.minimizeButton.Zoom = 10;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // CreditorSearch
            // 
            this.CreditorSearch.BorderColor = System.Drawing.Color.SeaGreen;
            this.CreditorSearch.Location = new System.Drawing.Point(703, 79);
            this.CreditorSearch.Multiline = true;
            this.CreditorSearch.Name = "CreditorSearch";
            this.CreditorSearch.Size = new System.Drawing.Size(190, 30);
            this.CreditorSearch.TabIndex = 57;
            this.CreditorSearch.TextChanged += new System.EventHandler(this.CreditorSearch_TextChanged);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(590, 86);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(107, 17);
            this.bunifuCustomLabel3.TabIndex = 56;
            this.bunifuCustomLabel3.Text = "Search By Name";
            // 
            // creditorDue
            // 
            this.creditorDue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.creditorDue.AutoSize = true;
            this.creditorDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditorDue.Location = new System.Drawing.Point(312, 532);
            this.creditorDue.Name = "creditorDue";
            this.creditorDue.Size = new System.Drawing.Size(19, 20);
            this.creditorDue.TabIndex = 63;
            this.creditorDue.Text = "0";
            // 
            // creditorId
            // 
            this.creditorId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.creditorId.AutoSize = true;
            this.creditorId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditorId.Location = new System.Drawing.Point(312, 501);
            this.creditorId.Name = "creditorId";
            this.creditorId.Size = new System.Drawing.Size(19, 20);
            this.creditorId.TabIndex = 62;
            this.creditorId.Text = "0";
            // 
            // CreditorCashPaid
            // 
            this.CreditorCashPaid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CreditorCashPaid.BorderColor = System.Drawing.Color.SeaGreen;
            this.CreditorCashPaid.Location = new System.Drawing.Point(254, 559);
            this.CreditorCashPaid.Multiline = true;
            this.CreditorCashPaid.Name = "CreditorCashPaid";
            this.CreditorCashPaid.Size = new System.Drawing.Size(89, 30);
            this.CreditorCashPaid.TabIndex = 61;
            // 
            // bunifuCustomLabel78
            // 
            this.bunifuCustomLabel78.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bunifuCustomLabel78.AutoSize = true;
            this.bunifuCustomLabel78.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel78.Location = new System.Drawing.Point(106, 569);
            this.bunifuCustomLabel78.Name = "bunifuCustomLabel78";
            this.bunifuCustomLabel78.Size = new System.Drawing.Size(37, 17);
            this.bunifuCustomLabel78.TabIndex = 60;
            this.bunifuCustomLabel78.Text = "Cash";
            // 
            // bunifuCustomLabel76
            // 
            this.bunifuCustomLabel76.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bunifuCustomLabel76.AutoSize = true;
            this.bunifuCustomLabel76.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel76.Location = new System.Drawing.Point(106, 534);
            this.bunifuCustomLabel76.Name = "bunifuCustomLabel76";
            this.bunifuCustomLabel76.Size = new System.Drawing.Size(139, 17);
            this.bunifuCustomLabel76.TabIndex = 59;
            this.bunifuCustomLabel76.Text = "Total Amount of Due";
            // 
            // bunifuCustomLabel75
            // 
            this.bunifuCustomLabel75.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bunifuCustomLabel75.AutoSize = true;
            this.bunifuCustomLabel75.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel75.Location = new System.Drawing.Point(106, 504);
            this.bunifuCustomLabel75.Name = "bunifuCustomLabel75";
            this.bunifuCustomLabel75.Size = new System.Drawing.Size(116, 17);
            this.bunifuCustomLabel75.TabIndex = 58;
            this.bunifuCustomLabel75.Text = "Select Creditor ID";
            // 
            // SaveButton
            // 
            this.SaveButton.Activecolor = System.Drawing.Color.Gray;
            this.SaveButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SaveButton.BackColor = System.Drawing.Color.Gray;
            this.SaveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SaveButton.BorderRadius = 7;
            this.SaveButton.ButtonText = "Save";
            this.SaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveButton.DisabledColor = System.Drawing.Color.Gray;
            this.SaveButton.Iconcolor = System.Drawing.Color.Transparent;
            this.SaveButton.Iconimage = null;
            this.SaveButton.Iconimage_right = null;
            this.SaveButton.Iconimage_right_Selected = null;
            this.SaveButton.Iconimage_Selected = null;
            this.SaveButton.IconMarginLeft = 0;
            this.SaveButton.IconMarginRight = 0;
            this.SaveButton.IconRightVisible = true;
            this.SaveButton.IconRightZoom = 0D;
            this.SaveButton.IconVisible = true;
            this.SaveButton.IconZoom = 50D;
            this.SaveButton.IsTab = false;
            this.SaveButton.Location = new System.Drawing.Point(408, 587);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(8);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Normalcolor = System.Drawing.Color.Gray;
            this.SaveButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.SaveButton.OnHoverTextColor = System.Drawing.Color.White;
            this.SaveButton.selected = false;
            this.SaveButton.Size = new System.Drawing.Size(118, 35);
            this.SaveButton.TabIndex = 64;
            this.SaveButton.Text = "Save";
            this.SaveButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SaveButton.Textcolor = System.Drawing.Color.White;
            this.SaveButton.TextFont = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
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
            this.back.Location = new System.Drawing.Point(795, 581);
            this.back.Margin = new System.Windows.Forms.Padding(5);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(110, 47);
            this.back.TabIndex = 65;
            this.back.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // CreditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 642);
            this.Controls.Add(this.back);
            this.Controls.Add(this.creditorDue);
            this.Controls.Add(this.creditorId);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CreditorCashPaid);
            this.Controls.Add(this.bunifuCustomLabel78);
            this.Controls.Add(this.bunifuCustomLabel76);
            this.Controls.Add(this.bunifuCustomLabel75);
            this.Controls.Add(this.CreditorSearch);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.creditorGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreditorForm";
            this.Load += new System.EventHandler(this.CreditorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.creditorGridView)).EndInit();
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
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        public Bunifu.Framework.UI.BunifuCustomDataGrid creditorGridView;
        private System.Windows.Forms.Label creditorDue;
        private System.Windows.Forms.Label creditorId;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox CreditorCashPaid;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel78;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel76;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel75;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox CreditorSearch;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuImageButton maximizeButton;
        private Bunifu.Framework.UI.BunifuImageButton crossButton;
        private Bunifu.Framework.UI.BunifuImageButton minimizeButton;
        private Bunifu.Framework.UI.BunifuFlatButton SaveButton;
        private Bunifu.Framework.UI.BunifuThinButton2 back;
    }
}