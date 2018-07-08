namespace Ekhteear.UI
{
    partial class DebtorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DebtorForm));
            this.debtorDue = new System.Windows.Forms.Label();
            this.debtorId = new System.Windows.Forms.Label();
            this.SaveButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.debtorCashPaid = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel78 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel76 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel75 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Search = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.debtorGridView = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.back = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.maximizeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.crossButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.minimizeButton = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.debtorGridView)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maximizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crossButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).BeginInit();
            this.SuspendLayout();
            // 
            // debtorDue
            // 
            this.debtorDue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.debtorDue.AutoSize = true;
            this.debtorDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debtorDue.Location = new System.Drawing.Point(381, 600);
            this.debtorDue.Name = "debtorDue";
            this.debtorDue.Size = new System.Drawing.Size(19, 20);
            this.debtorDue.TabIndex = 75;
            this.debtorDue.Text = "0";
            // 
            // debtorId
            // 
            this.debtorId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.debtorId.AutoSize = true;
            this.debtorId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debtorId.Location = new System.Drawing.Point(381, 569);
            this.debtorId.Name = "debtorId";
            this.debtorId.Size = new System.Drawing.Size(19, 20);
            this.debtorId.TabIndex = 74;
            this.debtorId.Text = "0";
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
            this.SaveButton.Location = new System.Drawing.Point(519, 655);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(8);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Normalcolor = System.Drawing.Color.Gray;
            this.SaveButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.SaveButton.OnHoverTextColor = System.Drawing.Color.White;
            this.SaveButton.selected = false;
            this.SaveButton.Size = new System.Drawing.Size(118, 35);
            this.SaveButton.TabIndex = 76;
            this.SaveButton.Text = "Save";
            this.SaveButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SaveButton.Textcolor = System.Drawing.Color.White;
            this.SaveButton.TextFont = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // debtorCashPaid
            // 
            this.debtorCashPaid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.debtorCashPaid.BorderColor = System.Drawing.Color.SeaGreen;
            this.debtorCashPaid.Location = new System.Drawing.Point(323, 627);
            this.debtorCashPaid.Multiline = true;
            this.debtorCashPaid.Name = "debtorCashPaid";
            this.debtorCashPaid.Size = new System.Drawing.Size(89, 30);
            this.debtorCashPaid.TabIndex = 73;
            // 
            // bunifuCustomLabel78
            // 
            this.bunifuCustomLabel78.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bunifuCustomLabel78.AutoSize = true;
            this.bunifuCustomLabel78.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel78.Location = new System.Drawing.Point(175, 637);
            this.bunifuCustomLabel78.Name = "bunifuCustomLabel78";
            this.bunifuCustomLabel78.Size = new System.Drawing.Size(37, 17);
            this.bunifuCustomLabel78.TabIndex = 72;
            this.bunifuCustomLabel78.Text = "Cash";
            // 
            // bunifuCustomLabel76
            // 
            this.bunifuCustomLabel76.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bunifuCustomLabel76.AutoSize = true;
            this.bunifuCustomLabel76.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel76.Location = new System.Drawing.Point(175, 602);
            this.bunifuCustomLabel76.Name = "bunifuCustomLabel76";
            this.bunifuCustomLabel76.Size = new System.Drawing.Size(139, 17);
            this.bunifuCustomLabel76.TabIndex = 71;
            this.bunifuCustomLabel76.Text = "Total Amount of Due";
            // 
            // bunifuCustomLabel75
            // 
            this.bunifuCustomLabel75.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bunifuCustomLabel75.AutoSize = true;
            this.bunifuCustomLabel75.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel75.Location = new System.Drawing.Point(175, 572);
            this.bunifuCustomLabel75.Name = "bunifuCustomLabel75";
            this.bunifuCustomLabel75.Size = new System.Drawing.Size(109, 17);
            this.bunifuCustomLabel75.TabIndex = 70;
            this.bunifuCustomLabel75.Text = "Select Debtor ID";
            // 
            // Search
            // 
            this.Search.BorderColor = System.Drawing.Color.SeaGreen;
            this.Search.Location = new System.Drawing.Point(943, 85);
            this.Search.Multiline = true;
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(190, 30);
            this.Search.TabIndex = 69;
            this.Search.TextChanged += new System.EventHandler(this.DebotrSearch_TextChanged);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(830, 92);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(107, 17);
            this.bunifuCustomLabel3.TabIndex = 68;
            this.bunifuCustomLabel3.Text = "Search By Name";
            // 
            // debtorGridView
            // 
            this.debtorGridView.AllowUserToAddRows = false;
            this.debtorGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.debtorGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.debtorGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.debtorGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.debtorGridView.BackgroundColor = System.Drawing.Color.Gray;
            this.debtorGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.debtorGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.debtorGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.debtorGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.debtorGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.debtorGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.debtorGridView.DoubleBuffered = true;
            this.debtorGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.debtorGridView.EnableHeadersVisualStyles = false;
            this.debtorGridView.GridColor = System.Drawing.Color.Black;
            this.debtorGridView.HeaderBgColor = System.Drawing.Color.Gray;
            this.debtorGridView.HeaderForeColor = System.Drawing.Color.White;
            this.debtorGridView.Location = new System.Drawing.Point(19, 125);
            this.debtorGridView.Name = "debtorGridView";
            this.debtorGridView.ReadOnly = true;
            this.debtorGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.debtorGridView.RowHeadersVisible = false;
            this.debtorGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.debtorGridView.Size = new System.Drawing.Size(1121, 404);
            this.debtorGridView.TabIndex = 66;
            this.debtorGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.debtorGridView_CellClick);
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this;
            this.bunifuDragControl2.Vertical = true;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.bunifuGradientPanel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this;
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
            this.back.Location = new System.Drawing.Point(1009, 655);
            this.back.Margin = new System.Windows.Forms.Padding(5);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(110, 47);
            this.back.TabIndex = 77;
            this.back.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.back.Click += new System.EventHandler(this.back_Click);
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
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1166, 73);
            this.bunifuGradientPanel1.TabIndex = 67;
            // 
            // maximizeButton
            // 
            this.maximizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizeButton.BackColor = System.Drawing.Color.Transparent;
            this.maximizeButton.Image = global::Ekhteear.Properties.Resources.imageedit_5_7285109277;
            this.maximizeButton.ImageActive = null;
            this.maximizeButton.Location = new System.Drawing.Point(1063, 26);
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
            this.crossButton.Location = new System.Drawing.Point(1094, 26);
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
            this.minimizeButton.Location = new System.Drawing.Point(1033, 27);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(24, 25);
            this.minimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizeButton.TabIndex = 2;
            this.minimizeButton.TabStop = false;
            this.minimizeButton.Zoom = 10;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // DebtorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 724);
            this.Controls.Add(this.back);
            this.Controls.Add(this.debtorDue);
            this.Controls.Add(this.debtorId);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.debtorCashPaid);
            this.Controls.Add(this.bunifuCustomLabel78);
            this.Controls.Add(this.bunifuCustomLabel76);
            this.Controls.Add(this.bunifuCustomLabel75);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.debtorGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DebtorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DebtorForm";
            this.Load += new System.EventHandler(this.DebtorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.debtorGridView)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.maximizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crossButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuThinButton2 back;
        private System.Windows.Forms.Label debtorDue;
        private System.Windows.Forms.Label debtorId;
        private Bunifu.Framework.UI.BunifuFlatButton SaveButton;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox debtorCashPaid;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel78;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel76;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel75;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox Search;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuImageButton maximizeButton;
        private Bunifu.Framework.UI.BunifuImageButton crossButton;
        private Bunifu.Framework.UI.BunifuImageButton minimizeButton;
        public Bunifu.Framework.UI.BunifuCustomDataGrid debtorGridView;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
    }
}