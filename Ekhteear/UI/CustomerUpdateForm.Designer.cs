namespace Ekhteear.UI
{
    partial class CustomerUpdateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerUpdateForm));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.customerIdLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.CustomerTypeDD = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel85 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.CustomerPhn = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel84 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.CustomerCompany = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel83 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.CustomerName = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel82 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.backButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.maximizeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.crossButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.minimizeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.SaveButton = new Bunifu.Framework.UI.BunifuFlatButton();
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
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this;
            // 
            // customerIdLabel
            // 
            this.customerIdLabel.AutoSize = true;
            this.customerIdLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.customerIdLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerIdLabel.Location = new System.Drawing.Point(338, 121);
            this.customerIdLabel.Name = "customerIdLabel";
            this.customerIdLabel.Size = new System.Drawing.Size(15, 17);
            this.customerIdLabel.TabIndex = 93;
            this.customerIdLabel.Text = "0";
            // 
            // CustomerTypeDD
            // 
            this.CustomerTypeDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CustomerTypeDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerTypeDD.FormattingEnabled = true;
            this.CustomerTypeDD.Items.AddRange(new object[] {
            "Normal",
            "Agent"});
            this.CustomerTypeDD.Location = new System.Drawing.Point(341, 300);
            this.CustomerTypeDD.Name = "CustomerTypeDD";
            this.CustomerTypeDD.Size = new System.Drawing.Size(172, 28);
            this.CustomerTypeDD.TabIndex = 92;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(183, 308);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(37, 17);
            this.bunifuCustomLabel2.TabIndex = 91;
            this.bunifuCustomLabel2.Text = "Type";
            // 
            // bunifuCustomLabel85
            // 
            this.bunifuCustomLabel85.AutoSize = true;
            this.bunifuCustomLabel85.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel85.Location = new System.Drawing.Point(182, 263);
            this.bunifuCustomLabel85.Name = "bunifuCustomLabel85";
            this.bunifuCustomLabel85.Size = new System.Drawing.Size(101, 17);
            this.bunifuCustomLabel85.TabIndex = 90;
            this.bunifuCustomLabel85.Text = "Phone Number";
            // 
            // CustomerPhn
            // 
            this.CustomerPhn.BorderColor = System.Drawing.Color.SeaGreen;
            this.CustomerPhn.Location = new System.Drawing.Point(341, 253);
            this.CustomerPhn.Multiline = true;
            this.CustomerPhn.Name = "CustomerPhn";
            this.CustomerPhn.Size = new System.Drawing.Size(171, 30);
            this.CustomerPhn.TabIndex = 89;
            // 
            // bunifuCustomLabel84
            // 
            this.bunifuCustomLabel84.AutoSize = true;
            this.bunifuCustomLabel84.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel84.Location = new System.Drawing.Point(182, 214);
            this.bunifuCustomLabel84.Name = "bunifuCustomLabel84";
            this.bunifuCustomLabel84.Size = new System.Drawing.Size(66, 17);
            this.bunifuCustomLabel84.TabIndex = 88;
            this.bunifuCustomLabel84.Text = "Company";
            // 
            // CustomerCompany
            // 
            this.CustomerCompany.BorderColor = System.Drawing.Color.SeaGreen;
            this.CustomerCompany.Location = new System.Drawing.Point(341, 206);
            this.CustomerCompany.Multiline = true;
            this.CustomerCompany.Name = "CustomerCompany";
            this.CustomerCompany.Size = new System.Drawing.Size(171, 30);
            this.CustomerCompany.TabIndex = 87;
            // 
            // bunifuCustomLabel83
            // 
            this.bunifuCustomLabel83.AutoSize = true;
            this.bunifuCustomLabel83.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel83.Location = new System.Drawing.Point(182, 168);
            this.bunifuCustomLabel83.Name = "bunifuCustomLabel83";
            this.bunifuCustomLabel83.Size = new System.Drawing.Size(107, 17);
            this.bunifuCustomLabel83.TabIndex = 86;
            this.bunifuCustomLabel83.Text = "Customer Name";
            // 
            // CustomerName
            // 
            this.CustomerName.BorderColor = System.Drawing.Color.SeaGreen;
            this.CustomerName.Location = new System.Drawing.Point(341, 159);
            this.CustomerName.Multiline = true;
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(171, 30);
            this.CustomerName.TabIndex = 85;
            // 
            // bunifuCustomLabel82
            // 
            this.bunifuCustomLabel82.AutoSize = true;
            this.bunifuCustomLabel82.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel82.Location = new System.Drawing.Point(182, 121);
            this.bunifuCustomLabel82.Name = "bunifuCustomLabel82";
            this.bunifuCustomLabel82.Size = new System.Drawing.Size(85, 17);
            this.bunifuCustomLabel82.TabIndex = 84;
            this.bunifuCustomLabel82.Text = "Customer ID";
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
            this.backButton.Location = new System.Drawing.Point(538, 407);
            this.backButton.Margin = new System.Windows.Forms.Padding(5);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(110, 47);
            this.backButton.TabIndex = 83;
            this.backButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
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
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(671, 73);
            this.bunifuGradientPanel1.TabIndex = 82;
            // 
            // maximizeButton
            // 
            this.maximizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizeButton.BackColor = System.Drawing.Color.Transparent;
            this.maximizeButton.Image = global::Ekhteear.Properties.Resources.imageedit_5_7285109277;
            this.maximizeButton.ImageActive = null;
            this.maximizeButton.Location = new System.Drawing.Point(568, 26);
            this.maximizeButton.Name = "maximizeButton";
            this.maximizeButton.Size = new System.Drawing.Size(25, 25);
            this.maximizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.maximizeButton.TabIndex = 4;
            this.maximizeButton.TabStop = false;
            this.maximizeButton.Zoom = 10;
            // 
            // crossButton
            // 
            this.crossButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.crossButton.BackColor = System.Drawing.Color.Transparent;
            this.crossButton.Image = global::Ekhteear.Properties.Resources.imageedit_1_7939263489;
            this.crossButton.ImageActive = null;
            this.crossButton.Location = new System.Drawing.Point(599, 26);
            this.crossButton.Name = "crossButton";
            this.crossButton.Size = new System.Drawing.Size(25, 25);
            this.crossButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.crossButton.TabIndex = 3;
            this.crossButton.TabStop = false;
            this.crossButton.Zoom = 10;
            // 
            // minimizeButton
            // 
            this.minimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.minimizeButton.Image = global::Ekhteear.Properties.Resources.imageedit_7_5361398056;
            this.minimizeButton.ImageActive = null;
            this.minimizeButton.Location = new System.Drawing.Point(538, 27);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(24, 25);
            this.minimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizeButton.TabIndex = 2;
            this.minimizeButton.TabStop = false;
            this.minimizeButton.Zoom = 10;
            // 
            // SaveButton
            // 
            this.SaveButton.Activecolor = System.Drawing.Color.Gray;
            this.SaveButton.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.SaveButton.Location = new System.Drawing.Point(280, 352);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Normalcolor = System.Drawing.Color.Gray;
            this.SaveButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.SaveButton.OnHoverTextColor = System.Drawing.Color.White;
            this.SaveButton.selected = false;
            this.SaveButton.Size = new System.Drawing.Size(98, 47);
            this.SaveButton.TabIndex = 94;
            this.SaveButton.Text = "Save";
            this.SaveButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SaveButton.Textcolor = System.Drawing.Color.White;
            this.SaveButton.TextFont = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CustomerUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 468);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.customerIdLabel);
            this.Controls.Add(this.CustomerTypeDD);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel85);
            this.Controls.Add(this.CustomerPhn);
            this.Controls.Add(this.bunifuCustomLabel84);
            this.Controls.Add(this.CustomerCompany);
            this.Controls.Add(this.bunifuCustomLabel83);
            this.Controls.Add(this.CustomerName);
            this.Controls.Add(this.bunifuCustomLabel82);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerUpdateForm";
            this.Text = "CustomerUpdateForm";
            this.Load += new System.EventHandler(this.CustomerUpdateForm_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.maximizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crossButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCustomLabel customerIdLabel;
        private System.Windows.Forms.ComboBox CustomerTypeDD;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel85;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox CustomerPhn;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel84;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox CustomerCompany;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel83;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox CustomerName;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel82;
        private Bunifu.Framework.UI.BunifuThinButton2 backButton;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuImageButton maximizeButton;
        private Bunifu.Framework.UI.BunifuImageButton crossButton;
        private Bunifu.Framework.UI.BunifuImageButton minimizeButton;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuFlatButton SaveButton;
    }
}