namespace Ekhteear.UI
{
    partial class InventoryAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryAddForm));
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.UnitTextBox = new System.Windows.Forms.Label();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Reload = new Bunifu.Framework.UI.BunifuFlatButton();
            this.totalBill = new System.Windows.Forms.Label();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.agentNameDD = new System.Windows.Forms.ComboBox();
            this.productNameDD = new System.Windows.Forms.ComboBox();
            this.cost = new System.Windows.Forms.Label();
            this.companyName = new System.Windows.Forms.Label();
            this.delete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.AddButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Purchase = new Bunifu.Framework.UI.BunifuFlatButton();
            this.due = new System.Windows.Forms.Label();
            this.productRate = new System.Windows.Forms.Label();
            this.storeId = new System.Windows.Forms.Label();
            this.cashPaid = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.quantity = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel20 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel19 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel18 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.storeIdLab = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel16 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel13 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel12 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel11 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.inventoryDetailsGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.maximizeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.crossButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.minimizeButton = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDetailsGrid)).BeginInit();
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
            // UnitTextBox
            // 
            this.UnitTextBox.AutoSize = true;
            this.UnitTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitTextBox.Location = new System.Drawing.Point(182, 288);
            this.UnitTextBox.Name = "UnitTextBox";
            this.UnitTextBox.Size = new System.Drawing.Size(0, 20);
            this.UnitTextBox.TabIndex = 71;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(38, 284);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(34, 17);
            this.bunifuCustomLabel3.TabIndex = 70;
            this.bunifuCustomLabel3.Text = "Unit";
            // 
            // Reload
            // 
            this.Reload.Activecolor = System.Drawing.Color.Gray;
            this.Reload.BackColor = System.Drawing.Color.Gray;
            this.Reload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Reload.BorderRadius = 7;
            this.Reload.ButtonText = "Reload";
            this.Reload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Reload.DisabledColor = System.Drawing.Color.Gray;
            this.Reload.Iconcolor = System.Drawing.Color.Transparent;
            this.Reload.Iconimage = null;
            this.Reload.Iconimage_right = null;
            this.Reload.Iconimage_right_Selected = null;
            this.Reload.Iconimage_Selected = null;
            this.Reload.IconMarginLeft = 0;
            this.Reload.IconMarginRight = 0;
            this.Reload.IconRightVisible = true;
            this.Reload.IconRightZoom = 0D;
            this.Reload.IconVisible = true;
            this.Reload.IconZoom = 50D;
            this.Reload.IsTab = false;
            this.Reload.Location = new System.Drawing.Point(92, 542);
            this.Reload.Margin = new System.Windows.Forms.Padding(22, 18, 22, 18);
            this.Reload.Name = "Reload";
            this.Reload.Normalcolor = System.Drawing.Color.Gray;
            this.Reload.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.Reload.OnHoverTextColor = System.Drawing.Color.White;
            this.Reload.selected = false;
            this.Reload.Size = new System.Drawing.Size(118, 35);
            this.Reload.TabIndex = 69;
            this.Reload.Text = "Reload";
            this.Reload.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Reload.Textcolor = System.Drawing.Color.White;
            this.Reload.TextFont = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reload.Click += new System.EventHandler(this.Reload_Click);
            // 
            // totalBill
            // 
            this.totalBill.AutoSize = true;
            this.totalBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalBill.Location = new System.Drawing.Point(182, 384);
            this.totalBill.Name = "totalBill";
            this.totalBill.Size = new System.Drawing.Size(0, 20);
            this.totalBill.TabIndex = 68;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(38, 380);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(63, 17);
            this.bunifuCustomLabel2.TabIndex = 67;
            this.bunifuCustomLabel2.Text = "Total Bill";
            // 
            // agentNameDD
            // 
            this.agentNameDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.agentNameDD.FormattingEnabled = true;
            this.agentNameDD.Location = new System.Drawing.Point(182, 220);
            this.agentNameDD.Name = "agentNameDD";
            this.agentNameDD.Size = new System.Drawing.Size(194, 21);
            this.agentNameDD.TabIndex = 66;
            this.agentNameDD.SelectedIndexChanged += new System.EventHandler(this.agentNameDD_SelectedIndexChanged);
            // 
            // productNameDD
            // 
            this.productNameDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productNameDD.FormattingEnabled = true;
            this.productNameDD.Location = new System.Drawing.Point(182, 152);
            this.productNameDD.Name = "productNameDD";
            this.productNameDD.Size = new System.Drawing.Size(194, 21);
            this.productNameDD.TabIndex = 65;
            this.productNameDD.SelectedIndexChanged += new System.EventHandler(this.productNameDD_SelectedIndexChanged);
            // 
            // cost
            // 
            this.cost.AutoSize = true;
            this.cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cost.Location = new System.Drawing.Point(182, 354);
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(0, 20);
            this.cost.TabIndex = 64;
            // 
            // companyName
            // 
            this.companyName.AutoSize = true;
            this.companyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyName.Location = new System.Drawing.Point(182, 254);
            this.companyName.Name = "companyName";
            this.companyName.Size = new System.Drawing.Size(0, 20);
            this.companyName.TabIndex = 63;
            // 
            // delete
            // 
            this.delete.Activecolor = System.Drawing.Color.Gray;
            this.delete.BackColor = System.Drawing.Color.Gray;
            this.delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.delete.BorderRadius = 7;
            this.delete.ButtonText = "Remove";
            this.delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete.DisabledColor = System.Drawing.Color.Gray;
            this.delete.Iconcolor = System.Drawing.Color.Transparent;
            this.delete.Iconimage = null;
            this.delete.Iconimage_right = null;
            this.delete.Iconimage_right_Selected = null;
            this.delete.Iconimage_Selected = null;
            this.delete.IconMarginLeft = 0;
            this.delete.IconMarginRight = 0;
            this.delete.IconRightVisible = true;
            this.delete.IconRightZoom = 0D;
            this.delete.IconVisible = true;
            this.delete.IconZoom = 50D;
            this.delete.IsTab = false;
            this.delete.Location = new System.Drawing.Point(258, 487);
            this.delete.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.delete.Name = "delete";
            this.delete.Normalcolor = System.Drawing.Color.Gray;
            this.delete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.delete.OnHoverTextColor = System.Drawing.Color.White;
            this.delete.selected = false;
            this.delete.Size = new System.Drawing.Size(118, 35);
            this.delete.TabIndex = 62;
            this.delete.Text = "Remove";
            this.delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.delete.Textcolor = System.Drawing.Color.White;
            this.delete.TextFont = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // AddButton
            // 
            this.AddButton.Activecolor = System.Drawing.Color.Gray;
            this.AddButton.BackColor = System.Drawing.Color.Gray;
            this.AddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddButton.BorderRadius = 7;
            this.AddButton.ButtonText = "Add";
            this.AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddButton.DisabledColor = System.Drawing.Color.Gray;
            this.AddButton.Iconcolor = System.Drawing.Color.Transparent;
            this.AddButton.Iconimage = null;
            this.AddButton.Iconimage_right = null;
            this.AddButton.Iconimage_right_Selected = null;
            this.AddButton.Iconimage_Selected = null;
            this.AddButton.IconMarginLeft = 0;
            this.AddButton.IconMarginRight = 0;
            this.AddButton.IconRightVisible = true;
            this.AddButton.IconRightZoom = 0D;
            this.AddButton.IconVisible = true;
            this.AddButton.IconZoom = 50D;
            this.AddButton.IsTab = false;
            this.AddButton.Location = new System.Drawing.Point(92, 487);
            this.AddButton.Margin = new System.Windows.Forms.Padding(8);
            this.AddButton.Name = "AddButton";
            this.AddButton.Normalcolor = System.Drawing.Color.Gray;
            this.AddButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.AddButton.OnHoverTextColor = System.Drawing.Color.White;
            this.AddButton.selected = false;
            this.AddButton.Size = new System.Drawing.Size(118, 35);
            this.AddButton.TabIndex = 61;
            this.AddButton.Text = "Add";
            this.AddButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddButton.Textcolor = System.Drawing.Color.White;
            this.AddButton.TextFont = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(38, 252);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(106, 17);
            this.bunifuCustomLabel1.TabIndex = 60;
            this.bunifuCustomLabel1.Text = "Company Name";
            // 
            // Purchase
            // 
            this.Purchase.Activecolor = System.Drawing.Color.Gray;
            this.Purchase.BackColor = System.Drawing.Color.Gray;
            this.Purchase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Purchase.BorderRadius = 7;
            this.Purchase.ButtonText = "Purchase";
            this.Purchase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Purchase.DisabledColor = System.Drawing.Color.Gray;
            this.Purchase.Iconcolor = System.Drawing.Color.Transparent;
            this.Purchase.Iconimage = null;
            this.Purchase.Iconimage_right = null;
            this.Purchase.Iconimage_right_Selected = null;
            this.Purchase.Iconimage_Selected = null;
            this.Purchase.IconMarginLeft = 0;
            this.Purchase.IconMarginRight = 0;
            this.Purchase.IconRightVisible = true;
            this.Purchase.IconRightZoom = 0D;
            this.Purchase.IconVisible = true;
            this.Purchase.IconZoom = 50D;
            this.Purchase.IsTab = false;
            this.Purchase.Location = new System.Drawing.Point(258, 542);
            this.Purchase.Margin = new System.Windows.Forms.Padding(5);
            this.Purchase.Name = "Purchase";
            this.Purchase.Normalcolor = System.Drawing.Color.Gray;
            this.Purchase.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.Purchase.OnHoverTextColor = System.Drawing.Color.White;
            this.Purchase.selected = false;
            this.Purchase.Size = new System.Drawing.Size(118, 35);
            this.Purchase.TabIndex = 57;
            this.Purchase.Text = "Purchase";
            this.Purchase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Purchase.Textcolor = System.Drawing.Color.White;
            this.Purchase.TextFont = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Purchase.Click += new System.EventHandler(this.Purchase_Click);
            // 
            // due
            // 
            this.due.AutoSize = true;
            this.due.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.due.Location = new System.Drawing.Point(182, 450);
            this.due.Name = "due";
            this.due.Size = new System.Drawing.Size(0, 20);
            this.due.TabIndex = 56;
            // 
            // productRate
            // 
            this.productRate.AutoSize = true;
            this.productRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productRate.Location = new System.Drawing.Point(182, 190);
            this.productRate.Name = "productRate";
            this.productRate.Size = new System.Drawing.Size(0, 20);
            this.productRate.TabIndex = 55;
            // 
            // storeId
            // 
            this.storeId.AutoSize = true;
            this.storeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeId.Location = new System.Drawing.Point(182, 122);
            this.storeId.Name = "storeId";
            this.storeId.Size = new System.Drawing.Size(19, 20);
            this.storeId.TabIndex = 54;
            this.storeId.Text = "0";
            // 
            // cashPaid
            // 
            this.cashPaid.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.cashPaid.Location = new System.Drawing.Point(182, 414);
            this.cashPaid.Name = "cashPaid";
            this.cashPaid.Size = new System.Drawing.Size(194, 20);
            this.cashPaid.TabIndex = 53;
            this.cashPaid.TextChanged += new System.EventHandler(this.cashPaid_TextChanged);
            // 
            // quantity
            // 
            this.quantity.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.quantity.Location = new System.Drawing.Point(182, 317);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(194, 20);
            this.quantity.TabIndex = 52;
            this.quantity.TextChanged += new System.EventHandler(this.quantity_TextChanged);
            // 
            // bunifuCustomLabel20
            // 
            this.bunifuCustomLabel20.AutoSize = true;
            this.bunifuCustomLabel20.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel20.Location = new System.Drawing.Point(38, 444);
            this.bunifuCustomLabel20.Name = "bunifuCustomLabel20";
            this.bunifuCustomLabel20.Size = new System.Drawing.Size(33, 17);
            this.bunifuCustomLabel20.TabIndex = 51;
            this.bunifuCustomLabel20.Text = "Due";
            // 
            // bunifuCustomLabel19
            // 
            this.bunifuCustomLabel19.AutoSize = true;
            this.bunifuCustomLabel19.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel19.Location = new System.Drawing.Point(38, 412);
            this.bunifuCustomLabel19.Name = "bunifuCustomLabel19";
            this.bunifuCustomLabel19.Size = new System.Drawing.Size(68, 17);
            this.bunifuCustomLabel19.TabIndex = 50;
            this.bunifuCustomLabel19.Text = "Cash Paid";
            // 
            // bunifuCustomLabel18
            // 
            this.bunifuCustomLabel18.AutoSize = true;
            this.bunifuCustomLabel18.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel18.Location = new System.Drawing.Point(38, 348);
            this.bunifuCustomLabel18.Name = "bunifuCustomLabel18";
            this.bunifuCustomLabel18.Size = new System.Drawing.Size(35, 17);
            this.bunifuCustomLabel18.TabIndex = 49;
            this.bunifuCustomLabel18.Text = "Cost";
            // 
            // storeIdLab
            // 
            this.storeIdLab.AutoSize = true;
            this.storeIdLab.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeIdLab.Location = new System.Drawing.Point(38, 124);
            this.storeIdLab.Name = "storeIdLab";
            this.storeIdLab.Size = new System.Drawing.Size(58, 17);
            this.storeIdLab.TabIndex = 48;
            this.storeIdLab.Text = "Store ID";
            // 
            // bunifuCustomLabel16
            // 
            this.bunifuCustomLabel16.AutoSize = true;
            this.bunifuCustomLabel16.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel16.Location = new System.Drawing.Point(38, 316);
            this.bunifuCustomLabel16.Name = "bunifuCustomLabel16";
            this.bunifuCustomLabel16.Size = new System.Drawing.Size(62, 17);
            this.bunifuCustomLabel16.TabIndex = 47;
            this.bunifuCustomLabel16.Text = "Quantity";
            // 
            // bunifuCustomLabel13
            // 
            this.bunifuCustomLabel13.AutoSize = true;
            this.bunifuCustomLabel13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel13.Location = new System.Drawing.Point(38, 220);
            this.bunifuCustomLabel13.Name = "bunifuCustomLabel13";
            this.bunifuCustomLabel13.Size = new System.Drawing.Size(85, 17);
            this.bunifuCustomLabel13.TabIndex = 46;
            this.bunifuCustomLabel13.Text = "Agent Name";
            // 
            // bunifuCustomLabel12
            // 
            this.bunifuCustomLabel12.AutoSize = true;
            this.bunifuCustomLabel12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel12.Location = new System.Drawing.Point(38, 188);
            this.bunifuCustomLabel12.Name = "bunifuCustomLabel12";
            this.bunifuCustomLabel12.Size = new System.Drawing.Size(134, 17);
            this.bunifuCustomLabel12.TabIndex = 45;
            this.bunifuCustomLabel12.Text = "Product Buying Rate";
            // 
            // bunifuCustomLabel11
            // 
            this.bunifuCustomLabel11.AutoSize = true;
            this.bunifuCustomLabel11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel11.Location = new System.Drawing.Point(38, 156);
            this.bunifuCustomLabel11.Name = "bunifuCustomLabel11";
            this.bunifuCustomLabel11.Size = new System.Drawing.Size(96, 17);
            this.bunifuCustomLabel11.TabIndex = 44;
            this.bunifuCustomLabel11.Text = "Product Name";
            // 
            // inventoryDetailsGrid
            // 
            this.inventoryDetailsGrid.AllowUserToAddRows = false;
            this.inventoryDetailsGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.inventoryDetailsGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.inventoryDetailsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inventoryDetailsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.inventoryDetailsGrid.BackgroundColor = System.Drawing.Color.Gray;
            this.inventoryDetailsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inventoryDetailsGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.inventoryDetailsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.inventoryDetailsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventoryDetailsGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.inventoryDetailsGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.inventoryDetailsGrid.DoubleBuffered = true;
            this.inventoryDetailsGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.inventoryDetailsGrid.EnableHeadersVisualStyles = false;
            this.inventoryDetailsGrid.GridColor = System.Drawing.Color.Black;
            this.inventoryDetailsGrid.HeaderBgColor = System.Drawing.Color.Gray;
            this.inventoryDetailsGrid.HeaderForeColor = System.Drawing.Color.White;
            this.inventoryDetailsGrid.Location = new System.Drawing.Point(406, 102);
            this.inventoryDetailsGrid.MultiSelect = false;
            this.inventoryDetailsGrid.Name = "inventoryDetailsGrid";
            this.inventoryDetailsGrid.ReadOnly = true;
            this.inventoryDetailsGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.inventoryDetailsGrid.RowHeadersVisible = false;
            this.inventoryDetailsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.inventoryDetailsGrid.Size = new System.Drawing.Size(779, 472);
            this.inventoryDetailsGrid.TabIndex = 73;
            this.inventoryDetailsGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.inventoryDetailsDataGridView_CellClick);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(182, 90);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(128, 26);
            this.dateTimePicker.TabIndex = 74;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(38, 97);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(37, 17);
            this.bunifuCustomLabel4.TabIndex = 75;
            this.bunifuCustomLabel4.Text = "Date";
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
            this.bunifuThinButton21.Location = new System.Drawing.Point(1040, 582);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(110, 47);
            this.bunifuThinButton21.TabIndex = 72;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.BackButtonClick);
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
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1197, 73);
            this.bunifuGradientPanel1.TabIndex = 2;
            // 
            // maximizeButton
            // 
            this.maximizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizeButton.BackColor = System.Drawing.Color.Transparent;
            this.maximizeButton.Image = global::Ekhteear.Properties.Resources.imageedit_5_7285109277;
            this.maximizeButton.ImageActive = null;
            this.maximizeButton.Location = new System.Drawing.Point(1094, 26);
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
            this.crossButton.Location = new System.Drawing.Point(1125, 26);
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
            this.minimizeButton.Location = new System.Drawing.Point(1064, 27);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(24, 25);
            this.minimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizeButton.TabIndex = 2;
            this.minimizeButton.TabStop = false;
            this.minimizeButton.Zoom = 10;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // InventoryAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 643);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.inventoryDetailsGrid);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.UnitTextBox);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.Reload);
            this.Controls.Add(this.totalBill);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.agentNameDD);
            this.Controls.Add(this.productNameDD);
            this.Controls.Add(this.cost);
            this.Controls.Add(this.companyName);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.Purchase);
            this.Controls.Add(this.due);
            this.Controls.Add(this.productRate);
            this.Controls.Add(this.storeId);
            this.Controls.Add(this.cashPaid);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.bunifuCustomLabel20);
            this.Controls.Add(this.bunifuCustomLabel19);
            this.Controls.Add(this.bunifuCustomLabel18);
            this.Controls.Add(this.storeIdLab);
            this.Controls.Add(this.bunifuCustomLabel16);
            this.Controls.Add(this.bunifuCustomLabel13);
            this.Controls.Add(this.bunifuCustomLabel12);
            this.Controls.Add(this.bunifuCustomLabel11);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InventoryAddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InventoryAddForm";
            this.Load += new System.EventHandler(this.InventoryAddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDetailsGrid)).EndInit();
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
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuImageButton maximizeButton;
        private Bunifu.Framework.UI.BunifuImageButton crossButton;
        private Bunifu.Framework.UI.BunifuImageButton minimizeButton;
        private System.Windows.Forms.Label UnitTextBox;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuFlatButton Reload;
        private System.Windows.Forms.Label totalBill;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.ComboBox agentNameDD;
        private System.Windows.Forms.ComboBox productNameDD;
        private System.Windows.Forms.Label cost;
        private System.Windows.Forms.Label companyName;
        private Bunifu.Framework.UI.BunifuFlatButton delete;
        private Bunifu.Framework.UI.BunifuFlatButton AddButton;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuFlatButton Purchase;
        private System.Windows.Forms.Label due;
        private System.Windows.Forms.Label productRate;
        private System.Windows.Forms.Label storeId;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox cashPaid;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox quantity;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel20;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel19;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel18;
        private Bunifu.Framework.UI.BunifuCustomLabel storeIdLab;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel16;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel13;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel12;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel11;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        public Bunifu.Framework.UI.BunifuCustomDataGrid inventoryDetailsGrid;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}