namespace Ekhteear.UI
{
    partial class AddAgentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAgentForm));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.maximizeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.crossButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.minimizeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.addAgentId = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.addPhoneNumber = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.addCompanyName = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.addAgentName = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel72 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel71 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel70 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel69 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SaveButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
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
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.bunifuGradientPanel1;
            this.bunifuDragControl2.Vertical = true;
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
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(516, 73);
            this.bunifuGradientPanel1.TabIndex = 3;
            // 
            // maximizeButton
            // 
            this.maximizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizeButton.BackColor = System.Drawing.Color.Transparent;
            this.maximizeButton.Image = global::Ekhteear.Properties.Resources.imageedit_5_7285109277;
            this.maximizeButton.ImageActive = null;
            this.maximizeButton.Location = new System.Drawing.Point(413, 26);
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
            this.crossButton.Location = new System.Drawing.Point(444, 26);
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
            this.minimizeButton.Location = new System.Drawing.Point(383, 27);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(24, 25);
            this.minimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizeButton.TabIndex = 2;
            this.minimizeButton.TabStop = false;
            this.minimizeButton.Zoom = 10;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // addAgentId
            // 
            this.addAgentId.AutoSize = true;
            this.addAgentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAgentId.Location = new System.Drawing.Point(223, 104);
            this.addAgentId.Name = "addAgentId";
            this.addAgentId.Size = new System.Drawing.Size(29, 20);
            this.addAgentId.TabIndex = 20;
            this.addAgentId.Text = "00";
            // 
            // addPhoneNumber
            // 
            this.addPhoneNumber.BorderColor = System.Drawing.Color.SeaGreen;
            this.addPhoneNumber.Location = new System.Drawing.Point(225, 244);
            this.addPhoneNumber.Multiline = true;
            this.addPhoneNumber.Name = "addPhoneNumber";
            this.addPhoneNumber.Size = new System.Drawing.Size(171, 30);
            this.addPhoneNumber.TabIndex = 19;
            // 
            // addCompanyName
            // 
            this.addCompanyName.BorderColor = System.Drawing.Color.SeaGreen;
            this.addCompanyName.Location = new System.Drawing.Point(226, 194);
            this.addCompanyName.Multiline = true;
            this.addCompanyName.Name = "addCompanyName";
            this.addCompanyName.Size = new System.Drawing.Size(171, 30);
            this.addCompanyName.TabIndex = 18;
            // 
            // addAgentName
            // 
            this.addAgentName.BorderColor = System.Drawing.Color.SeaGreen;
            this.addAgentName.Location = new System.Drawing.Point(226, 144);
            this.addAgentName.Multiline = true;
            this.addAgentName.Name = "addAgentName";
            this.addAgentName.Size = new System.Drawing.Size(171, 30);
            this.addAgentName.TabIndex = 17;
            // 
            // bunifuCustomLabel72
            // 
            this.bunifuCustomLabel72.AutoSize = true;
            this.bunifuCustomLabel72.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel72.Location = new System.Drawing.Point(113, 245);
            this.bunifuCustomLabel72.Name = "bunifuCustomLabel72";
            this.bunifuCustomLabel72.Size = new System.Drawing.Size(101, 17);
            this.bunifuCustomLabel72.TabIndex = 16;
            this.bunifuCustomLabel72.Text = "Phone Number";
            // 
            // bunifuCustomLabel71
            // 
            this.bunifuCustomLabel71.AutoSize = true;
            this.bunifuCustomLabel71.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel71.Location = new System.Drawing.Point(113, 198);
            this.bunifuCustomLabel71.Name = "bunifuCustomLabel71";
            this.bunifuCustomLabel71.Size = new System.Drawing.Size(106, 17);
            this.bunifuCustomLabel71.TabIndex = 15;
            this.bunifuCustomLabel71.Text = "Company Name";
            // 
            // bunifuCustomLabel70
            // 
            this.bunifuCustomLabel70.AutoSize = true;
            this.bunifuCustomLabel70.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel70.Location = new System.Drawing.Point(113, 151);
            this.bunifuCustomLabel70.Name = "bunifuCustomLabel70";
            this.bunifuCustomLabel70.Size = new System.Drawing.Size(85, 17);
            this.bunifuCustomLabel70.TabIndex = 14;
            this.bunifuCustomLabel70.Text = "Agent Name";
            // 
            // bunifuCustomLabel69
            // 
            this.bunifuCustomLabel69.AutoSize = true;
            this.bunifuCustomLabel69.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel69.Location = new System.Drawing.Point(113, 104);
            this.bunifuCustomLabel69.Name = "bunifuCustomLabel69";
            this.bunifuCustomLabel69.Size = new System.Drawing.Size(63, 17);
            this.bunifuCustomLabel69.TabIndex = 13;
            this.bunifuCustomLabel69.Text = "Agent ID";
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
            this.SaveButton.Location = new System.Drawing.Point(225, 303);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Normalcolor = System.Drawing.Color.Gray;
            this.SaveButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.SaveButton.OnHoverTextColor = System.Drawing.Color.White;
            this.SaveButton.selected = false;
            this.SaveButton.Size = new System.Drawing.Size(98, 47);
            this.SaveButton.TabIndex = 53;
            this.SaveButton.Text = "Save";
            this.SaveButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SaveButton.Textcolor = System.Drawing.Color.White;
            this.SaveButton.TextFont = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 3;
            this.bunifuThinButton21.ActiveCornerRadius = 1;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.Gray;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.Silver;
            this.bunifuThinButton21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuThinButton21.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Back";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuThinButton21.IdleBorderThickness = 2;
            this.bunifuThinButton21.IdleCornerRadius = 1;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.DimGray;
            this.bunifuThinButton21.Location = new System.Drawing.Point(383, 350);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(110, 47);
            this.bunifuThinButton21.TabIndex = 70;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // AddAgentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 439);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.addAgentId);
            this.Controls.Add(this.addPhoneNumber);
            this.Controls.Add(this.addCompanyName);
            this.Controls.Add(this.addAgentName);
            this.Controls.Add(this.bunifuCustomLabel72);
            this.Controls.Add(this.bunifuCustomLabel71);
            this.Controls.Add(this.bunifuCustomLabel70);
            this.Controls.Add(this.bunifuCustomLabel69);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddAgentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddAgentForm";
            this.Load += new System.EventHandler(this.AddAgentForm_Load);
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
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuCustomLabel addAgentId;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox addPhoneNumber;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox addCompanyName;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox addAgentName;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel72;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel71;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel70;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel69;
        private Bunifu.Framework.UI.BunifuFlatButton SaveButton;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
    }
}