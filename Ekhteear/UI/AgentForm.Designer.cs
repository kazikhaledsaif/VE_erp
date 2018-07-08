namespace Ekhteear.UI
{
    partial class AgentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgentForm));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.agentGridView = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.searchByName = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel32 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.maximizeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.crossButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.minimizeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.backButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.deleteAgent = new Bunifu.Framework.UI.BunifuThinButton2();
            this.updateAgent = new Bunifu.Framework.UI.BunifuThinButton2();
            this.addAgent = new Bunifu.Framework.UI.BunifuThinButton2();
            this.refresh = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.agentGridView)).BeginInit();
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
            // agentGridView
            // 
            this.agentGridView.AllowUserToAddRows = false;
            this.agentGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.agentGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.agentGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.agentGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.agentGridView.BackgroundColor = System.Drawing.Color.Gray;
            this.agentGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.agentGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.agentGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.agentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.agentGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.agentGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.agentGridView.DoubleBuffered = true;
            this.agentGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.agentGridView.EnableHeadersVisualStyles = false;
            this.agentGridView.GridColor = System.Drawing.Color.Black;
            this.agentGridView.HeaderBgColor = System.Drawing.Color.Gray;
            this.agentGridView.HeaderForeColor = System.Drawing.Color.White;
            this.agentGridView.Location = new System.Drawing.Point(0, 131);
            this.agentGridView.Name = "agentGridView";
            this.agentGridView.ReadOnly = true;
            this.agentGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.agentGridView.RowHeadersVisible = false;
            this.agentGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.agentGridView.Size = new System.Drawing.Size(1139, 377);
            this.agentGridView.TabIndex = 52;
            this.agentGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.agentGridView_CellClick);
            // 
            // searchByName
            // 
            this.searchByName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchByName.BorderColor = System.Drawing.Color.SeaGreen;
            this.searchByName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.searchByName.Location = new System.Drawing.Point(945, 88);
            this.searchByName.Multiline = true;
            this.searchByName.Name = "searchByName";
            this.searchByName.Size = new System.Drawing.Size(171, 30);
            this.searchByName.TabIndex = 56;
            this.searchByName.TextChanged += new System.EventHandler(this.SearchByAgentName_TextChanged);
            // 
            // bunifuCustomLabel32
            // 
            this.bunifuCustomLabel32.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel32.AutoSize = true;
            this.bunifuCustomLabel32.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel32.Location = new System.Drawing.Point(832, 94);
            this.bunifuCustomLabel32.Name = "bunifuCustomLabel32";
            this.bunifuCustomLabel32.Size = new System.Drawing.Size(107, 17);
            this.bunifuCustomLabel32.TabIndex = 55;
            this.bunifuCustomLabel32.Text = "Search by Name";
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
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1139, 73);
            this.bunifuGradientPanel1.TabIndex = 2;
            // 
            // maximizeButton
            // 
            this.maximizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizeButton.BackColor = System.Drawing.Color.Transparent;
            this.maximizeButton.Image = global::Ekhteear.Properties.Resources.imageedit_5_7285109277;
            this.maximizeButton.ImageActive = null;
            this.maximizeButton.Location = new System.Drawing.Point(1036, 26);
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
            this.crossButton.Location = new System.Drawing.Point(1067, 26);
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
            this.minimizeButton.Location = new System.Drawing.Point(1006, 27);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(24, 25);
            this.minimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizeButton.TabIndex = 2;
            this.minimizeButton.TabStop = false;
            this.minimizeButton.Zoom = 10;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
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
            this.backButton.Location = new System.Drawing.Point(982, 620);
            this.backButton.Margin = new System.Windows.Forms.Padding(5);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(110, 47);
            this.backButton.TabIndex = 63;
            this.backButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.backButton.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // deleteAgent
            // 
            this.deleteAgent.ActiveBorderThickness = 3;
            this.deleteAgent.ActiveCornerRadius = 20;
            this.deleteAgent.ActiveFillColor = System.Drawing.Color.Gray;
            this.deleteAgent.ActiveForecolor = System.Drawing.Color.White;
            this.deleteAgent.ActiveLineColor = System.Drawing.Color.Silver;
            this.deleteAgent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteAgent.BackColor = System.Drawing.SystemColors.Control;
            this.deleteAgent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteAgent.BackgroundImage")));
            this.deleteAgent.ButtonText = "Delete";
            this.deleteAgent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteAgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteAgent.ForeColor = System.Drawing.Color.SeaGreen;
            this.deleteAgent.IdleBorderThickness = 2;
            this.deleteAgent.IdleCornerRadius = 20;
            this.deleteAgent.IdleFillColor = System.Drawing.Color.White;
            this.deleteAgent.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.deleteAgent.IdleLineColor = System.Drawing.Color.DimGray;
            this.deleteAgent.Location = new System.Drawing.Point(585, 558);
            this.deleteAgent.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.deleteAgent.Name = "deleteAgent";
            this.deleteAgent.Size = new System.Drawing.Size(184, 47);
            this.deleteAgent.TabIndex = 61;
            this.deleteAgent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.deleteAgent.Click += new System.EventHandler(this.deleteAgent_Click);
            // 
            // updateAgent
            // 
            this.updateAgent.ActiveBorderThickness = 3;
            this.updateAgent.ActiveCornerRadius = 20;
            this.updateAgent.ActiveFillColor = System.Drawing.Color.Gray;
            this.updateAgent.ActiveForecolor = System.Drawing.Color.White;
            this.updateAgent.ActiveLineColor = System.Drawing.Color.Silver;
            this.updateAgent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.updateAgent.BackColor = System.Drawing.SystemColors.Control;
            this.updateAgent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("updateAgent.BackgroundImage")));
            this.updateAgent.ButtonText = "Update";
            this.updateAgent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateAgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateAgent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.updateAgent.IdleBorderThickness = 2;
            this.updateAgent.IdleCornerRadius = 20;
            this.updateAgent.IdleFillColor = System.Drawing.Color.White;
            this.updateAgent.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.updateAgent.IdleLineColor = System.Drawing.Color.DimGray;
            this.updateAgent.Location = new System.Drawing.Point(385, 558);
            this.updateAgent.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.updateAgent.Name = "updateAgent";
            this.updateAgent.Size = new System.Drawing.Size(184, 47);
            this.updateAgent.TabIndex = 60;
            this.updateAgent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.updateAgent.Click += new System.EventHandler(this.updateAgent_Click);
            // 
            // addAgent
            // 
            this.addAgent.ActiveBorderThickness = 3;
            this.addAgent.ActiveCornerRadius = 20;
            this.addAgent.ActiveFillColor = System.Drawing.Color.Gray;
            this.addAgent.ActiveForecolor = System.Drawing.Color.White;
            this.addAgent.ActiveLineColor = System.Drawing.Color.Silver;
            this.addAgent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addAgent.BackColor = System.Drawing.SystemColors.Control;
            this.addAgent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addAgent.BackgroundImage")));
            this.addAgent.ButtonText = "Add";
            this.addAgent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addAgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAgent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addAgent.IdleBorderThickness = 2;
            this.addAgent.IdleCornerRadius = 20;
            this.addAgent.IdleFillColor = System.Drawing.Color.White;
            this.addAgent.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addAgent.IdleLineColor = System.Drawing.Color.DimGray;
            this.addAgent.Location = new System.Drawing.Point(185, 558);
            this.addAgent.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.addAgent.Name = "addAgent";
            this.addAgent.Size = new System.Drawing.Size(184, 47);
            this.addAgent.TabIndex = 59;
            this.addAgent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addAgent.Click += new System.EventHandler(this.addAgent_Click);
            // 
            // refresh
            // 
            this.refresh.ActiveBorderThickness = 3;
            this.refresh.ActiveCornerRadius = 20;
            this.refresh.ActiveFillColor = System.Drawing.Color.Gray;
            this.refresh.ActiveForecolor = System.Drawing.Color.White;
            this.refresh.ActiveLineColor = System.Drawing.Color.Silver;
            this.refresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.refresh.BackColor = System.Drawing.SystemColors.Control;
            this.refresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("refresh.BackgroundImage")));
            this.refresh.ButtonText = "Refresh";
            this.refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.refresh.IdleBorderThickness = 2;
            this.refresh.IdleCornerRadius = 20;
            this.refresh.IdleFillColor = System.Drawing.Color.White;
            this.refresh.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.refresh.IdleLineColor = System.Drawing.Color.DimGray;
            this.refresh.Location = new System.Drawing.Point(785, 558);
            this.refresh.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(184, 47);
            this.refresh.TabIndex = 62;
            this.refresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // AgentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 698);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.deleteAgent);
            this.Controls.Add(this.updateAgent);
            this.Controls.Add(this.addAgent);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.searchByName);
            this.Controls.Add(this.bunifuCustomLabel32);
            this.Controls.Add(this.agentGridView);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgentForm";
            this.Load += new System.EventHandler(this.AgentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.agentGridView)).EndInit();
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
        private WindowsFormsControlLibrary1.BunifuCustomTextbox searchByName;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel32;
        private Bunifu.Framework.UI.BunifuThinButton2 backButton;
        private Bunifu.Framework.UI.BunifuThinButton2 deleteAgent;
        private Bunifu.Framework.UI.BunifuThinButton2 updateAgent;
        private Bunifu.Framework.UI.BunifuThinButton2 addAgent;
        private Bunifu.Framework.UI.BunifuThinButton2 refresh;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid agentGridView;
    }
}