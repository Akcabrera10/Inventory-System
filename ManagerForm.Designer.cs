namespace UI_Project
{
    partial class ManagerForm
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
            this.productList = new System.Windows.Forms.ListBox();
            this.inventoryLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.quantityLbl = new System.Windows.Forms.Label();
            this.priceLbl = new System.Windows.Forms.Label();
            this.priceTxt = new System.Windows.Forms.TextBox();
            this.qtyCounter = new System.Windows.Forms.NumericUpDown();
            this.categoryLbl = new System.Windows.Forms.Label();
            this.dairyRadio = new System.Windows.Forms.RadioButton();
            this.grainRadio = new System.Windows.Forms.RadioButton();
            this.meatRadio = new System.Windows.Forms.RadioButton();
            this.vegetableRadio = new System.Windows.Forms.RadioButton();
            this.addBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.nameErr = new System.Windows.Forms.ErrorProvider(this.components);
            this.priceErr = new System.Windows.Forms.ErrorProvider(this.components);
            this.categoryErr = new System.Windows.Forms.ErrorProvider(this.components);
            this.removeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.qtyCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameErr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceErr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryErr)).BeginInit();
            this.SuspendLayout();
            // 
            // productList
            // 
            this.productList.FormattingEnabled = true;
            this.productList.ItemHeight = 25;
            this.productList.Location = new System.Drawing.Point(15, 40);
            this.productList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.productList.Name = "productList";
            this.productList.Size = new System.Drawing.Size(312, 479);
            this.productList.TabIndex = 0;
            this.productList.TabStop = false;
            this.productList.SelectedIndexChanged += new System.EventHandler(this.productList_SelectedIndexChanged);
            // 
            // inventoryLbl
            // 
            this.inventoryLbl.AutoSize = true;
            this.inventoryLbl.Location = new System.Drawing.Point(15, 11);
            this.inventoryLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.inventoryLbl.Name = "inventoryLbl";
            this.inventoryLbl.Size = new System.Drawing.Size(154, 25);
            this.inventoryLbl.TabIndex = 1;
            this.inventoryLbl.Text = "Product Inventory";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(415, 96);
            this.nameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(59, 25);
            this.nameLbl.TabIndex = 2;
            this.nameLbl.Text = "Name";
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(490, 92);
            this.nameTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(155, 31);
            this.nameTxt.TabIndex = 0;
            this.nameTxt.TextChanged += new System.EventHandler(this.nameTxt_TextChanged);
            // 
            // quantityLbl
            // 
            this.quantityLbl.AutoSize = true;
            this.quantityLbl.Location = new System.Drawing.Point(395, 429);
            this.quantityLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.quantityLbl.Name = "quantityLbl";
            this.quantityLbl.Size = new System.Drawing.Size(80, 25);
            this.quantityLbl.TabIndex = 4;
            this.quantityLbl.Text = "Quantity";
            // 
            // priceLbl
            // 
            this.priceLbl.AutoSize = true;
            this.priceLbl.Location = new System.Drawing.Point(425, 168);
            this.priceLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(49, 25);
            this.priceLbl.TabIndex = 5;
            this.priceLbl.Text = "Price";
            // 
            // priceTxt
            // 
            this.priceTxt.Location = new System.Drawing.Point(490, 159);
            this.priceTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.Size = new System.Drawing.Size(155, 31);
            this.priceTxt.TabIndex = 1;
            // 
            // qtyCounter
            // 
            this.qtyCounter.Location = new System.Drawing.Point(490, 420);
            this.qtyCounter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.qtyCounter.Name = "qtyCounter";
            this.qtyCounter.Size = new System.Drawing.Size(61, 31);
            this.qtyCounter.TabIndex = 2;
            // 
            // categoryLbl
            // 
            this.categoryLbl.AutoSize = true;
            this.categoryLbl.Location = new System.Drawing.Point(390, 239);
            this.categoryLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.categoryLbl.Name = "categoryLbl";
            this.categoryLbl.Size = new System.Drawing.Size(84, 25);
            this.categoryLbl.TabIndex = 8;
            this.categoryLbl.Text = "Category";
            // 
            // dairyRadio
            // 
            this.dairyRadio.AutoSize = true;
            this.dairyRadio.Location = new System.Drawing.Point(500, 236);
            this.dairyRadio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dairyRadio.Name = "dairyRadio";
            this.dairyRadio.Size = new System.Drawing.Size(78, 29);
            this.dairyRadio.TabIndex = 9;
            this.dairyRadio.Text = "Dairy";
            this.dairyRadio.UseVisualStyleBackColor = true;
            // 
            // grainRadio
            // 
            this.grainRadio.AutoSize = true;
            this.grainRadio.Location = new System.Drawing.Point(500, 274);
            this.grainRadio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grainRadio.Name = "grainRadio";
            this.grainRadio.Size = new System.Drawing.Size(78, 29);
            this.grainRadio.TabIndex = 10;
            this.grainRadio.TabStop = true;
            this.grainRadio.Text = "Grain";
            this.grainRadio.UseVisualStyleBackColor = true;
            // 
            // meatRadio
            // 
            this.meatRadio.AutoSize = true;
            this.meatRadio.Location = new System.Drawing.Point(500, 311);
            this.meatRadio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.meatRadio.Name = "meatRadio";
            this.meatRadio.Size = new System.Drawing.Size(77, 29);
            this.meatRadio.TabIndex = 11;
            this.meatRadio.TabStop = true;
            this.meatRadio.Text = "Meat";
            this.meatRadio.UseVisualStyleBackColor = true;
            // 
            // vegetableRadio
            // 
            this.vegetableRadio.AutoSize = true;
            this.vegetableRadio.Location = new System.Drawing.Point(500, 349);
            this.vegetableRadio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.vegetableRadio.Name = "vegetableRadio";
            this.vegetableRadio.Size = new System.Drawing.Size(115, 29);
            this.vegetableRadio.TabIndex = 12;
            this.vegetableRadio.TabStop = true;
            this.vegetableRadio.Text = "Vegetable";
            this.vegetableRadio.UseVisualStyleBackColor = true;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(335, 482);
            this.addBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(156, 36);
            this.addBtn.TabIndex = 13;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Enabled = false;
            this.updateBtn.Location = new System.Drawing.Point(651, 482);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(156, 36);
            this.updateBtn.TabIndex = 14;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.Location = new System.Drawing.Point(690, 6);
            this.logoutBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(118, 36);
            this.logoutBtn.TabIndex = 15;
            this.logoutBtn.Text = "Log Out";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // nameErr
            // 
            this.nameErr.ContainerControl = this;
            // 
            // priceErr
            // 
            this.priceErr.ContainerControl = this;
            // 
            // categoryErr
            // 
            this.categoryErr.ContainerControl = this;
            // 
            // removeBtn
            // 
            this.removeBtn.Enabled = false;
            this.removeBtn.Location = new System.Drawing.Point(500, 484);
            this.removeBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(144, 36);
            this.removeBtn.TabIndex = 16;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 534);
            this.ControlBox = false;
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.vegetableRadio);
            this.Controls.Add(this.meatRadio);
            this.Controls.Add(this.grainRadio);
            this.Controls.Add(this.dairyRadio);
            this.Controls.Add(this.categoryLbl);
            this.Controls.Add(this.qtyCounter);
            this.Controls.Add(this.priceTxt);
            this.Controls.Add(this.priceLbl);
            this.Controls.Add(this.quantityLbl);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.inventoryLbl);
            this.Controls.Add(this.productList);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ManagerForm";
            this.Text = "Inventory Manager";
            ((System.ComponentModel.ISupportInitialize)(this.qtyCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameErr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceErr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryErr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox productList;
        private Label inventoryLbl;
        private Label nameLbl;
        private TextBox nameTxt;
        private Label quantityLbl;
        private Label priceLbl;
        private TextBox priceTxt;
        private NumericUpDown qtyCounter;
        private Label categoryLbl;
        private RadioButton dairyRadio;
        private RadioButton grainRadio;
        private RadioButton meatRadio;
        private RadioButton vegetableRadio;
        private Button addBtn;
        private Button updateBtn;
        private Button logoutBtn;
        private ErrorProvider nameErr;
        private ErrorProvider priceErr;
        private ErrorProvider categoryErr;
        private Button removeBtn;
    }
}