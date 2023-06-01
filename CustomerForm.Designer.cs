namespace UI_Project
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manageCartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vegetableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dairyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortAlphabeticallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortByPriceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highestToLowestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lowestToHighestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerList = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.productTxt = new System.Windows.Forms.TextBox();
            this.csName = new System.Windows.Forms.TextBox();
            this.csPostal = new System.Windows.Forms.TextBox();
            this.quantityTxt = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.priceTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.categoryTxt = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.labelOver = new System.Windows.Forms.Label();
            this.labelAdd = new System.Windows.Forms.Label();
            this.labelQty = new System.Windows.Forms.Label();
            this.tab = new System.Windows.Forms.TabPage();
            this.lblPickup = new System.Windows.Forms.Label();
            this.timePickup = new System.Windows.Forms.DateTimePicker();
            this.lblNoUpdate = new System.Windows.Forms.Label();
            this.labelUpdate = new System.Windows.Forms.Label();
            this.txtReceipt = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.checkBtn = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtCV = new System.Windows.Forms.TextBox();
            this.txtCard = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblDelivery = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.radPickup = new System.Windows.Forms.RadioButton();
            this.radDelivery = new System.Windows.Forms.RadioButton();
            this.cartProd = new System.Windows.Forms.TextBox();
            this.cartList = new System.Windows.Forms.ListBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.cartUpdateBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnBack1 = new System.Windows.Forms.Button();
            this.cartPrice = new System.Windows.Forms.TextBox();
            this.cartName = new System.Windows.Forms.TextBox();
            this.cartPostal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cartQty = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.errorCard = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorCV = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorAddress = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityTxt)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAddress)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageCartToolStripMenuItem,
            this.sortAlphabeticallyToolStripMenuItem,
            this.sortByPriceToolStripMenuItem,
            this.signOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(760, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manageCartToolStripMenuItem
            // 
            this.manageCartToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produceToolStripMenuItem,
            this.vegetableToolStripMenuItem,
            this.dairyToolStripMenuItem,
            this.grainToolStripMenuItem});
            this.manageCartToolStripMenuItem.Name = "manageCartToolStripMenuItem";
            this.manageCartToolStripMenuItem.Size = new System.Drawing.Size(163, 29);
            this.manageCartToolStripMenuItem.Text = "Sort by Category";
            // 
            // produceToolStripMenuItem
            // 
            this.produceToolStripMenuItem.Name = "produceToolStripMenuItem";
            this.produceToolStripMenuItem.Size = new System.Drawing.Size(192, 34);
            this.produceToolStripMenuItem.Text = "Produce";
            this.produceToolStripMenuItem.Click += new System.EventHandler(this.produceToolStripMenuItem_Click);
            // 
            // vegetableToolStripMenuItem
            // 
            this.vegetableToolStripMenuItem.Name = "vegetableToolStripMenuItem";
            this.vegetableToolStripMenuItem.Size = new System.Drawing.Size(192, 34);
            this.vegetableToolStripMenuItem.Text = "Vegetable";
            this.vegetableToolStripMenuItem.Click += new System.EventHandler(this.vegetableToolStripMenuItem_Click);
            // 
            // dairyToolStripMenuItem
            // 
            this.dairyToolStripMenuItem.Name = "dairyToolStripMenuItem";
            this.dairyToolStripMenuItem.Size = new System.Drawing.Size(192, 34);
            this.dairyToolStripMenuItem.Text = "Dairy";
            this.dairyToolStripMenuItem.Click += new System.EventHandler(this.dairyToolStripMenuItem_Click);
            // 
            // grainToolStripMenuItem
            // 
            this.grainToolStripMenuItem.Name = "grainToolStripMenuItem";
            this.grainToolStripMenuItem.Size = new System.Drawing.Size(192, 34);
            this.grainToolStripMenuItem.Text = "Grain";
            this.grainToolStripMenuItem.Click += new System.EventHandler(this.grainToolStripMenuItem_Click);
            // 
            // sortAlphabeticallyToolStripMenuItem
            // 
            this.sortAlphabeticallyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aZToolStripMenuItem,
            this.zAToolStripMenuItem});
            this.sortAlphabeticallyToolStripMenuItem.Name = "sortAlphabeticallyToolStripMenuItem";
            this.sortAlphabeticallyToolStripMenuItem.Size = new System.Drawing.Size(176, 29);
            this.sortAlphabeticallyToolStripMenuItem.Text = "Sort Alphabetically";
            // 
            // aZToolStripMenuItem
            // 
            this.aZToolStripMenuItem.Name = "aZToolStripMenuItem";
            this.aZToolStripMenuItem.Size = new System.Drawing.Size(143, 34);
            this.aZToolStripMenuItem.Text = "A-Z";
            this.aZToolStripMenuItem.Click += new System.EventHandler(this.aZToolStripMenuItem_Click);
            // 
            // zAToolStripMenuItem
            // 
            this.zAToolStripMenuItem.Name = "zAToolStripMenuItem";
            this.zAToolStripMenuItem.Size = new System.Drawing.Size(143, 34);
            this.zAToolStripMenuItem.Text = "Z-A";
            this.zAToolStripMenuItem.Click += new System.EventHandler(this.zAToolStripMenuItem_Click);
            // 
            // sortByPriceToolStripMenuItem
            // 
            this.sortByPriceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.highestToLowestToolStripMenuItem,
            this.lowestToHighestToolStripMenuItem});
            this.sortByPriceToolStripMenuItem.Name = "sortByPriceToolStripMenuItem";
            this.sortByPriceToolStripMenuItem.Size = new System.Drawing.Size(128, 29);
            this.sortByPriceToolStripMenuItem.Text = "Sort by Price";
            // 
            // highestToLowestToolStripMenuItem
            // 
            this.highestToLowestToolStripMenuItem.Name = "highestToLowestToolStripMenuItem";
            this.highestToLowestToolStripMenuItem.Size = new System.Drawing.Size(257, 34);
            this.highestToLowestToolStripMenuItem.Text = "Highest to Lowest";
            this.highestToLowestToolStripMenuItem.Click += new System.EventHandler(this.highestToLowestToolStripMenuItem_Click);
            // 
            // lowestToHighestToolStripMenuItem
            // 
            this.lowestToHighestToolStripMenuItem.Name = "lowestToHighestToolStripMenuItem";
            this.lowestToHighestToolStripMenuItem.Size = new System.Drawing.Size(257, 34);
            this.lowestToHighestToolStripMenuItem.Text = "Lowest to Highest";
            this.lowestToHighestToolStripMenuItem.Click += new System.EventHandler(this.lowestToHighestToolStripMenuItem_Click);
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(98, 29);
            this.signOutToolStripMenuItem.Text = "Sign Out";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
            // 
            // customerList
            // 
            this.customerList.FormattingEnabled = true;
            this.customerList.HorizontalScrollbar = true;
            this.customerList.ItemHeight = 25;
            this.customerList.Location = new System.Drawing.Point(6, 2);
            this.customerList.Margin = new System.Windows.Forms.Padding(2);
            this.customerList.Name = "customerList";
            this.customerList.Size = new System.Drawing.Size(334, 454);
            this.customerList.TabIndex = 1;
            this.customerList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(468, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(222, 34);
            this.button3.TabIndex = 9;
            this.button3.Text = "Manage Cart";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // productTxt
            // 
            this.productTxt.Location = new System.Drawing.Point(469, 119);
            this.productTxt.Margin = new System.Windows.Forms.Padding(2);
            this.productTxt.Name = "productTxt";
            this.productTxt.ReadOnly = true;
            this.productTxt.Size = new System.Drawing.Size(132, 31);
            this.productTxt.TabIndex = 10;
            // 
            // csName
            // 
            this.csName.Location = new System.Drawing.Point(470, 344);
            this.csName.Margin = new System.Windows.Forms.Padding(2);
            this.csName.Name = "csName";
            this.csName.ReadOnly = true;
            this.csName.Size = new System.Drawing.Size(222, 31);
            this.csName.TabIndex = 11;
            // 
            // csPostal
            // 
            this.csPostal.Location = new System.Drawing.Point(470, 408);
            this.csPostal.Margin = new System.Windows.Forms.Padding(2);
            this.csPostal.Name = "csPostal";
            this.csPostal.ReadOnly = true;
            this.csPostal.Size = new System.Drawing.Size(222, 31);
            this.csPostal.TabIndex = 12;
            // 
            // quantityTxt
            // 
            this.quantityTxt.Location = new System.Drawing.Point(469, 184);
            this.quantityTxt.Margin = new System.Windows.Forms.Padding(2);
            this.quantityTxt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantityTxt.Name = "quantityTxt";
            this.quantityTxt.Size = new System.Drawing.Size(96, 31);
            this.quantityTxt.TabIndex = 13;
            this.quantityTxt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantityTxt.ValueChanged += new System.EventHandler(this.quantityTxt_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(469, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 32);
            this.label1.TabIndex = 14;
            this.label1.Text = "Product Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(458, 268);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 32);
            this.label2.TabIndex = 15;
            this.label2.Text = "Customer Information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(469, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Product";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(469, 156);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(469, 320);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(470, 380);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "Postal Code";
            // 
            // priceTxt
            // 
            this.priceTxt.Location = new System.Drawing.Point(622, 119);
            this.priceTxt.Margin = new System.Windows.Forms.Padding(2);
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.ReadOnly = true;
            this.priceTxt.Size = new System.Drawing.Size(68, 31);
            this.priceTxt.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(622, 98);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 25);
            this.label7.TabIndex = 22;
            this.label7.Text = "Price";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(571, 182);
            this.addBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(121, 34);
            this.addBtn.TabIndex = 7;
            this.addBtn.Text = "Add to Cart";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // categoryTxt
            // 
            this.categoryTxt.Location = new System.Drawing.Point(542, 222);
            this.categoryTxt.Margin = new System.Windows.Forms.Padding(2);
            this.categoryTxt.Name = "categoryTxt";
            this.categoryTxt.ReadOnly = true;
            this.categoryTxt.Size = new System.Drawing.Size(130, 31);
            this.categoryTxt.TabIndex = 23;
            this.categoryTxt.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tab);
            this.tabControl1.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControl1.Location = new System.Drawing.Point(12, 36);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 1);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(748, 530);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 24;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labelOver);
            this.tabPage1.Controls.Add(this.labelAdd);
            this.tabPage1.Controls.Add(this.labelQty);
            this.tabPage1.Controls.Add(this.productTxt);
            this.tabPage1.Controls.Add(this.customerList);
            this.tabPage1.Controls.Add(this.categoryTxt);
            this.tabPage1.Controls.Add(this.addBtn);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.priceTxt);
            this.tabPage1.Controls.Add(this.csName);
            this.tabPage1.Controls.Add(this.csPostal);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.quantityTxt);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 5);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(740, 521);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // labelOver
            // 
            this.labelOver.AutoSize = true;
            this.labelOver.Location = new System.Drawing.Point(441, 225);
            this.labelOver.Name = "labelOver";
            this.labelOver.Size = new System.Drawing.Size(281, 25);
            this.labelOver.TabIndex = 26;
            this.labelOver.Text = "Invalid amount, exceeds inventory";
            this.labelOver.Visible = false;
            // 
            // labelAdd
            // 
            this.labelAdd.AutoSize = true;
            this.labelAdd.Location = new System.Drawing.Point(475, 225);
            this.labelAdd.Name = "labelAdd";
            this.labelAdd.Size = new System.Drawing.Size(197, 25);
            this.labelAdd.TabIndex = 25;
            this.labelAdd.Text = "Product Added to Cart!";
            this.labelAdd.Visible = false;
            // 
            // labelQty
            // 
            this.labelQty.AutoSize = true;
            this.labelQty.Location = new System.Drawing.Point(2, 460);
            this.labelQty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelQty.Name = "labelQty";
            this.labelQty.Size = new System.Drawing.Size(0, 25);
            this.labelQty.TabIndex = 24;
            // 
            // tab
            // 
            this.tab.Controls.Add(this.lblPickup);
            this.tab.Controls.Add(this.timePickup);
            this.tab.Controls.Add(this.lblNoUpdate);
            this.tab.Controls.Add(this.labelUpdate);
            this.tab.Controls.Add(this.txtReceipt);
            this.tab.Controls.Add(this.label19);
            this.tab.Controls.Add(this.label18);
            this.tab.Controls.Add(this.checkBtn);
            this.tab.Controls.Add(this.dateTimePicker1);
            this.tab.Controls.Add(this.txtCV);
            this.tab.Controls.Add(this.txtCard);
            this.tab.Controls.Add(this.label17);
            this.tab.Controls.Add(this.label16);
            this.tab.Controls.Add(this.lblDelivery);
            this.tab.Controls.Add(this.txtAddress);
            this.tab.Controls.Add(this.radPickup);
            this.tab.Controls.Add(this.radDelivery);
            this.tab.Controls.Add(this.cartProd);
            this.tab.Controls.Add(this.cartList);
            this.tab.Controls.Add(this.textBox4);
            this.tab.Controls.Add(this.cartUpdateBtn);
            this.tab.Controls.Add(this.label8);
            this.tab.Controls.Add(this.btnBack1);
            this.tab.Controls.Add(this.cartPrice);
            this.tab.Controls.Add(this.cartName);
            this.tab.Controls.Add(this.cartPostal);
            this.tab.Controls.Add(this.label9);
            this.tab.Controls.Add(this.cartQty);
            this.tab.Controls.Add(this.label10);
            this.tab.Controls.Add(this.label11);
            this.tab.Controls.Add(this.label12);
            this.tab.Controls.Add(this.label13);
            this.tab.Controls.Add(this.label14);
            this.tab.Location = new System.Drawing.Point(4, 24);
            this.tab.Margin = new System.Windows.Forms.Padding(2);
            this.tab.Name = "tab";
            this.tab.Padding = new System.Windows.Forms.Padding(2);
            this.tab.Size = new System.Drawing.Size(740, 502);
            this.tab.TabIndex = 1;
            this.tab.Text = "tabPage2";
            this.tab.UseVisualStyleBackColor = true;
            // 
            // lblPickup
            // 
            this.lblPickup.AutoSize = true;
            this.lblPickup.Location = new System.Drawing.Point(472, 440);
            this.lblPickup.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPickup.Name = "lblPickup";
            this.lblPickup.Size = new System.Drawing.Size(116, 25);
            this.lblPickup.TabIndex = 57;
            this.lblPickup.Tag = "Product";
            this.lblPickup.Text = "Pick-Up Time";
            this.lblPickup.Visible = false;
            // 
            // timePickup
            // 
            this.timePickup.CustomFormat = "hh:mm tt";
            this.timePickup.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePickup.Location = new System.Drawing.Point(472, 461);
            this.timePickup.Margin = new System.Windows.Forms.Padding(2);
            this.timePickup.Name = "timePickup";
            this.timePickup.Size = new System.Drawing.Size(222, 31);
            this.timePickup.TabIndex = 56;
            this.timePickup.Visible = false;
            // 
            // lblNoUpdate
            // 
            this.lblNoUpdate.AutoSize = true;
            this.lblNoUpdate.Location = new System.Drawing.Point(510, 210);
            this.lblNoUpdate.Name = "lblNoUpdate";
            this.lblNoUpdate.Size = new System.Drawing.Size(142, 25);
            this.lblNoUpdate.TabIndex = 55;
            this.lblNoUpdate.Text = "Invalid Quantity!";
            this.lblNoUpdate.Visible = false;
            // 
            // labelUpdate
            // 
            this.labelUpdate.AutoSize = true;
            this.labelUpdate.Location = new System.Drawing.Point(510, 211);
            this.labelUpdate.Name = "labelUpdate";
            this.labelUpdate.Size = new System.Drawing.Size(157, 25);
            this.labelUpdate.TabIndex = 54;
            this.labelUpdate.Text = "Quantity updated!";
            this.labelUpdate.Visible = false;
            // 
            // txtReceipt
            // 
            this.txtReceipt.Location = new System.Drawing.Point(8, 5);
            this.txtReceipt.Multiline = true;
            this.txtReceipt.Name = "txtReceipt";
            this.txtReceipt.ReadOnly = true;
            this.txtReceipt.Size = new System.Drawing.Size(334, 303);
            this.txtReceipt.TabIndex = 53;
            this.txtReceipt.Visible = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(252, 411);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(133, 25);
            this.label19.TabIndex = 52;
            this.label19.Text = "Expiry (MM/YY)";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(255, 354);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(45, 25);
            this.label18.TabIndex = 51;
            this.label18.Text = "CVV";
            // 
            // checkBtn
            // 
            this.checkBtn.Location = new System.Drawing.Point(8, 432);
            this.checkBtn.Margin = new System.Windows.Forms.Padding(2);
            this.checkBtn.Name = "checkBtn";
            this.checkBtn.Size = new System.Drawing.Size(231, 34);
            this.checkBtn.TabIndex = 50;
            this.checkBtn.Text = "Checkout";
            this.checkBtn.UseVisualStyleBackColor = true;
            this.checkBtn.Click += new System.EventHandler(this.checkBtn_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM/yy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(255, 436);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(86, 31);
            this.dateTimePicker1.TabIndex = 49;
            // 
            // txtCV
            // 
            this.txtCV.Location = new System.Drawing.Point(255, 378);
            this.txtCV.Margin = new System.Windows.Forms.Padding(2);
            this.txtCV.MaxLength = 3;
            this.txtCV.Name = "txtCV";
            this.txtCV.Size = new System.Drawing.Size(86, 31);
            this.txtCV.TabIndex = 48;
            this.txtCV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCV_KeyPress);
            // 
            // txtCard
            // 
            this.txtCard.Location = new System.Drawing.Point(8, 378);
            this.txtCard.Margin = new System.Windows.Forms.Padding(2);
            this.txtCard.MaxLength = 12;
            this.txtCard.Name = "txtCard";
            this.txtCard.Size = new System.Drawing.Size(212, 31);
            this.txtCard.TabIndex = 46;
            this.txtCard.TextChanged += new System.EventHandler(this.txtCard_TextChanged);
            this.txtCard.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCard_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(8, 354);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(148, 25);
            this.label17.TabIndex = 47;
            this.label17.Text = "Card Information";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(54, 316);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(238, 32);
            this.label16.TabIndex = 45;
            this.label16.Text = "Payment Information";
            // 
            // lblDelivery
            // 
            this.lblDelivery.AutoSize = true;
            this.lblDelivery.Location = new System.Drawing.Point(470, 440);
            this.lblDelivery.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDelivery.Name = "lblDelivery";
            this.lblDelivery.Size = new System.Drawing.Size(145, 25);
            this.lblDelivery.TabIndex = 44;
            this.lblDelivery.Tag = "Product";
            this.lblDelivery.Text = "Delivery Address";
            this.lblDelivery.Visible = false;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(472, 463);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(222, 31);
            this.txtAddress.TabIndex = 43;
            this.txtAddress.Visible = false;
            this.txtAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // radPickup
            // 
            this.radPickup.AutoSize = true;
            this.radPickup.Location = new System.Drawing.Point(592, 403);
            this.radPickup.Margin = new System.Windows.Forms.Padding(2);
            this.radPickup.Name = "radPickup";
            this.radPickup.Size = new System.Drawing.Size(98, 29);
            this.radPickup.TabIndex = 42;
            this.radPickup.TabStop = true;
            this.radPickup.Text = "Pick-Up";
            this.radPickup.UseVisualStyleBackColor = true;
            this.radPickup.CheckedChanged += new System.EventHandler(this.radPickup_CheckedChanged);
            // 
            // radDelivery
            // 
            this.radDelivery.AutoSize = true;
            this.radDelivery.Location = new System.Drawing.Point(470, 403);
            this.radDelivery.Margin = new System.Windows.Forms.Padding(2);
            this.radDelivery.Name = "radDelivery";
            this.radDelivery.Size = new System.Drawing.Size(100, 29);
            this.radDelivery.TabIndex = 41;
            this.radDelivery.TabStop = true;
            this.radDelivery.Text = "Delivery";
            this.radDelivery.UseVisualStyleBackColor = true;
            this.radDelivery.CheckedChanged += new System.EventHandler(this.radDelivery_CheckedChanged);
            // 
            // cartProd
            // 
            this.cartProd.Location = new System.Drawing.Point(470, 111);
            this.cartProd.Margin = new System.Windows.Forms.Padding(2);
            this.cartProd.Name = "cartProd";
            this.cartProd.ReadOnly = true;
            this.cartProd.Size = new System.Drawing.Size(132, 31);
            this.cartProd.TabIndex = 27;
            // 
            // cartList
            // 
            this.cartList.FormattingEnabled = true;
            this.cartList.HorizontalScrollbar = true;
            this.cartList.ItemHeight = 25;
            this.cartList.Location = new System.Drawing.Point(8, 4);
            this.cartList.Margin = new System.Windows.Forms.Padding(2);
            this.cartList.Name = "cartList";
            this.cartList.Size = new System.Drawing.Size(334, 304);
            this.cartList.TabIndex = 24;
            this.cartList.SelectedIndexChanged += new System.EventHandler(this.cartList_SelectedIndexChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(578, 142);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(130, 31);
            this.textBox4.TabIndex = 40;
            this.textBox4.Visible = false;
            // 
            // cartUpdateBtn
            // 
            this.cartUpdateBtn.Location = new System.Drawing.Point(572, 174);
            this.cartUpdateBtn.Margin = new System.Windows.Forms.Padding(2);
            this.cartUpdateBtn.Name = "cartUpdateBtn";
            this.cartUpdateBtn.Size = new System.Drawing.Size(121, 34);
            this.cartUpdateBtn.TabIndex = 25;
            this.cartUpdateBtn.Text = "Update";
            this.cartUpdateBtn.UseVisualStyleBackColor = true;
            this.cartUpdateBtn.Click += new System.EventHandler(this.cartUpdateBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(624, 89);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 25);
            this.label8.TabIndex = 39;
            this.label8.Text = "Price";
            // 
            // btnBack1
            // 
            this.btnBack1.Location = new System.Drawing.Point(469, 1);
            this.btnBack1.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack1.Name = "btnBack1";
            this.btnBack1.Size = new System.Drawing.Size(222, 34);
            this.btnBack1.TabIndex = 26;
            this.btnBack1.Text = "Shop List";
            this.btnBack1.UseVisualStyleBackColor = true;
            this.btnBack1.Click += new System.EventHandler(this.btnBack1_Click);
            // 
            // cartPrice
            // 
            this.cartPrice.Location = new System.Drawing.Point(624, 111);
            this.cartPrice.Margin = new System.Windows.Forms.Padding(2);
            this.cartPrice.Name = "cartPrice";
            this.cartPrice.ReadOnly = true;
            this.cartPrice.Size = new System.Drawing.Size(68, 31);
            this.cartPrice.TabIndex = 38;
            // 
            // cartName
            // 
            this.cartName.Location = new System.Drawing.Point(469, 296);
            this.cartName.Margin = new System.Windows.Forms.Padding(2);
            this.cartName.Name = "cartName";
            this.cartName.ReadOnly = true;
            this.cartName.Size = new System.Drawing.Size(222, 31);
            this.cartName.TabIndex = 28;
            // 
            // cartPostal
            // 
            this.cartPostal.Location = new System.Drawing.Point(469, 360);
            this.cartPostal.Margin = new System.Windows.Forms.Padding(2);
            this.cartPostal.Name = "cartPostal";
            this.cartPostal.ReadOnly = true;
            this.cartPostal.Size = new System.Drawing.Size(222, 31);
            this.cartPostal.TabIndex = 29;
            this.cartPostal.TextChanged += new System.EventHandler(this.cartPostal_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(469, 332);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 25);
            this.label9.TabIndex = 36;
            this.label9.Text = "Postal Code";
            // 
            // cartQty
            // 
            this.cartQty.Location = new System.Drawing.Point(470, 176);
            this.cartQty.Margin = new System.Windows.Forms.Padding(2);
            this.cartQty.Name = "cartQty";
            this.cartQty.Size = new System.Drawing.Size(96, 31);
            this.cartQty.TabIndex = 30;
            this.cartQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(468, 272);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 25);
            this.label10.TabIndex = 35;
            this.label10.Text = "Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(470, 42);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(228, 32);
            this.label11.TabIndex = 31;
            this.label11.Text = "Product Information";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(470, 148);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 25);
            this.label12.TabIndex = 34;
            this.label12.Text = "Quantity";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(458, 232);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(249, 32);
            this.label13.TabIndex = 32;
            this.label13.Text = "Customer Information";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(470, 89);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 25);
            this.label14.TabIndex = 33;
            this.label14.Text = "Product";
            // 
            // errorCard
            // 
            this.errorCard.ContainerControl = this;
            // 
            // errorCV
            // 
            this.errorCV.ContainerControl = this;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorAddress
            // 
            this.errorAddress.ContainerControl = this;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 578);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CustomerForm";
            this.Text = "Customer Storefront";
            this.Load += new System.EventHandler(this.CustomerForm_Load_1);
            this.Shown += new System.EventHandler(this.CustomerForm_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityTxt)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tab.ResumeLayout(false);
            this.tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAddress)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem manageCartToolStripMenuItem;
        private ListBox customerList;
        private ToolStripMenuItem sortAlphabeticallyToolStripMenuItem;
        private ToolStripMenuItem sortByPriceToolStripMenuItem;
        private ToolStripMenuItem signOutToolStripMenuItem;
        private Button button3;
        private TextBox productTxt;
        private TextBox csName;
        private TextBox csPostal;
        private NumericUpDown quantityTxt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox priceTxt;
        private Label label7;
        private Button addBtn;
        private TextBox categoryTxt;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tab;
        private TextBox cartProd;
        private ListBox cartList;
        private TextBox textBox4;
        private Button cartUpdateBtn;
        private Label label8;
        private Button btnBack1;
        private TextBox cartPrice;
        private TextBox cartName;
        private TextBox cartPostal;
        private Label label9;
        private NumericUpDown cartQty;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private ToolStripMenuItem produceToolStripMenuItem;
        private ToolStripMenuItem vegetableToolStripMenuItem;
        private RadioButton radPickup;
        private RadioButton radDelivery;
        private ToolStripMenuItem dairyToolStripMenuItem;
        private ToolStripMenuItem grainToolStripMenuItem;
        private Button checkBtn;
        private DateTimePicker dateTimePicker1;
        private TextBox txtCV;
        private TextBox txtCard;
        private Label label17;
        private Label label16;
        private Label lblDelivery;
        private TextBox txtAddress;
        private ToolStripMenuItem aZToolStripMenuItem;
        private ToolStripMenuItem zAToolStripMenuItem;
        private ToolStripMenuItem highestToLowestToolStripMenuItem;
        private ToolStripMenuItem lowestToHighestToolStripMenuItem;
        private Label labelQty;
        private Label label19;
        private Label label18;
        private ErrorProvider errorCard;
        private ErrorProvider errorCV;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private TextBox txtReceipt;
        private Label labelAdd;
        private Label labelOver;
        private ErrorProvider errorAddress;
        private Label labelUpdate;
        private Label lblNoUpdate;
        private Label lblPickup;
        private DateTimePicker timePickup;
    }
}