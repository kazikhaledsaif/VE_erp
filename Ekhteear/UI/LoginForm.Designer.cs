namespace Ekhteear.UI
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.maximizeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.crossButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.minimizeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.userNameTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.passwordTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.logInButton = new Bunifu.Framework.UI.BunifuFlatButton();
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
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
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
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(483, 73);
            this.bunifuGradientPanel1.TabIndex = 3;
            // 
            // maximizeButton
            // 
            this.maximizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizeButton.BackColor = System.Drawing.Color.Transparent;
            this.maximizeButton.Image = global::Ekhteear.Properties.Resources.imageedit_5_7285109277;
            this.maximizeButton.ImageActive = null;
            this.maximizeButton.Location = new System.Drawing.Point(380, 26);
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
            this.crossButton.Location = new System.Drawing.Point(411, 26);
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
            this.minimizeButton.Location = new System.Drawing.Point(350, 27);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(24, 25);
            this.minimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizeButton.TabIndex = 2;
            this.minimizeButton.TabStop = false;
            this.minimizeButton.Zoom = 10;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userNameTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.userNameTextBox.ForeColor = System.Drawing.Color.Black;
            this.userNameTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.userNameTextBox.HintText = "username";
            this.userNameTextBox.isPassword = false;
            this.userNameTextBox.LineFocusedColor = System.Drawing.Color.Blue;
            this.userNameTextBox.LineIdleColor = System.Drawing.Color.Gray;
            this.userNameTextBox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.userNameTextBox.LineThickness = 3;
            this.userNameTextBox.Location = new System.Drawing.Point(149, 139);
            this.userNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(189, 29);
            this.userNameTextBox.TabIndex = 4;
            this.userNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.passwordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.passwordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passwordTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.passwordTextBox.HintText = "password";
            this.passwordTextBox.isPassword = false;
            this.passwordTextBox.LineFocusedColor = System.Drawing.Color.Blue;
            this.passwordTextBox.LineIdleColor = System.Drawing.Color.Gray;
            this.passwordTextBox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.passwordTextBox.LineThickness = 3;
            this.passwordTextBox.Location = new System.Drawing.Point(149, 218);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(189, 29);
            this.passwordTextBox.TabIndex = 5;
            this.passwordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // logInButton
            // 
            this.logInButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.logInButton.BackColor = System.Drawing.Color.DimGray;
            this.logInButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logInButton.BorderRadius = 0;
            this.logInButton.ButtonText = "LOG IN";
            this.logInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logInButton.DisabledColor = System.Drawing.Color.Gray;
            this.logInButton.Iconcolor = System.Drawing.Color.Transparent;
            this.logInButton.Iconimage = null;
            this.logInButton.Iconimage_right = null;
            this.logInButton.Iconimage_right_Selected = null;
            this.logInButton.Iconimage_Selected = null;
            this.logInButton.IconMarginLeft = 0;
            this.logInButton.IconMarginRight = 0;
            this.logInButton.IconRightVisible = true;
            this.logInButton.IconRightZoom = 0D;
            this.logInButton.IconVisible = true;
            this.logInButton.IconZoom = 90D;
            this.logInButton.IsTab = false;
            this.logInButton.Location = new System.Drawing.Point(159, 311);
            this.logInButton.Name = "logInButton";
            this.logInButton.Normalcolor = System.Drawing.Color.DimGray;
            this.logInButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.logInButton.OnHoverTextColor = System.Drawing.Color.White;
            this.logInButton.selected = false;
            this.logInButton.Size = new System.Drawing.Size(166, 42);
            this.logInButton.TabIndex = 6;
            this.logInButton.Text = "LOG IN";
            this.logInButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.logInButton.Textcolor = System.Drawing.Color.White;
            this.logInButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 508);
            this.Controls.Add(this.logInButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.maximizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crossButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuFlatButton logInButton;
        private Bunifu.Framework.UI.BunifuMaterialTextbox passwordTextBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox userNameTextBox;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuImageButton maximizeButton;
        private Bunifu.Framework.UI.BunifuImageButton crossButton;
        private Bunifu.Framework.UI.BunifuImageButton minimizeButton;
    }
}