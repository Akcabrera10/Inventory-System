namespace UI_Project
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.customerRadio = new System.Windows.Forms.RadioButton();
            this.managerRadio = new System.Windows.Forms.RadioButton();
            this.firstTxt = new System.Windows.Forms.TextBox();
            this.firstLbl = new System.Windows.Forms.Label();
            this.employeeLbl = new System.Windows.Forms.Label();
            this.employeeTxt = new System.Windows.Forms.TextBox();
            this.addressLbl = new System.Windows.Forms.Label();
            this.addressTxt = new System.Windows.Forms.TextBox();
            this.lastLbl = new System.Windows.Forms.Label();
            this.lastTxt = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.firstErr = new System.Windows.Forms.ErrorProvider(this.components);
            this.lastErr = new System.Windows.Forms.ErrorProvider(this.components);
            this.addressErr = new System.Windows.Forms.ErrorProvider(this.components);
            this.employeeErr = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.firstErr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastErr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressErr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeErr)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "User:";
            // 
            // customerRadio
            // 
            this.customerRadio.AutoSize = true;
            this.customerRadio.Location = new System.Drawing.Point(67, 16);
            this.customerRadio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customerRadio.Name = "customerRadio";
            this.customerRadio.Size = new System.Drawing.Size(93, 24);
            this.customerRadio.TabIndex = 0;
            this.customerRadio.Text = "Customer";
            this.customerRadio.UseVisualStyleBackColor = true;
            this.customerRadio.CheckedChanged += new System.EventHandler(this.customerRadio_CheckedChanged);
            // 
            // managerRadio
            // 
            this.managerRadio.AutoSize = true;
            this.managerRadio.Location = new System.Drawing.Point(174, 16);
            this.managerRadio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.managerRadio.Name = "managerRadio";
            this.managerRadio.Size = new System.Drawing.Size(89, 24);
            this.managerRadio.TabIndex = 1;
            this.managerRadio.Text = "Manager";
            this.managerRadio.UseVisualStyleBackColor = true;
            this.managerRadio.CheckedChanged += new System.EventHandler(this.managerRadio_CheckedChanged);
            // 
            // firstTxt
            // 
            this.firstTxt.Location = new System.Drawing.Point(111, 64);
            this.firstTxt.Name = "firstTxt";
            this.firstTxt.Size = new System.Drawing.Size(125, 27);
            this.firstTxt.TabIndex = 2;
            this.firstTxt.TextChanged += new System.EventHandler(this.firstTxt_TextChanged);
            this.firstTxt.Validating += new System.ComponentModel.CancelEventHandler(this.firstTxt_Validating);
            // 
            // firstLbl
            // 
            this.firstLbl.AutoSize = true;
            this.firstLbl.Location = new System.Drawing.Point(23, 67);
            this.firstLbl.Name = "firstLbl";
            this.firstLbl.Size = new System.Drawing.Size(80, 20);
            this.firstLbl.TabIndex = 4;
            this.firstLbl.Text = "First Name";
            // 
            // employeeLbl
            // 
            this.employeeLbl.AutoSize = true;
            this.employeeLbl.Location = new System.Drawing.Point(23, 139);
            this.employeeLbl.Name = "employeeLbl";
            this.employeeLbl.Size = new System.Drawing.Size(88, 20);
            this.employeeLbl.TabIndex = 6;
            this.employeeLbl.Text = "Employee #";
            this.employeeLbl.Visible = false;
            // 
            // employeeTxt
            // 
            this.employeeTxt.Location = new System.Drawing.Point(111, 139);
            this.employeeTxt.Name = "employeeTxt";
            this.employeeTxt.Size = new System.Drawing.Size(125, 27);
            this.employeeTxt.TabIndex = 4;
            this.employeeTxt.Visible = false;
            this.employeeTxt.Validating += new System.ComponentModel.CancelEventHandler(this.employeeTxt_Validating_1);
            // 
            // addressLbl
            // 
            this.addressLbl.AutoSize = true;
            this.addressLbl.Location = new System.Drawing.Point(23, 142);
            this.addressLbl.Name = "addressLbl";
            this.addressLbl.Size = new System.Drawing.Size(62, 20);
            this.addressLbl.TabIndex = 8;
            this.addressLbl.Text = "Address";
            this.addressLbl.Visible = false;
            // 
            // addressTxt
            // 
            this.addressTxt.Location = new System.Drawing.Point(110, 137);
            this.addressTxt.Name = "addressTxt";
            this.addressTxt.Size = new System.Drawing.Size(125, 27);
            this.addressTxt.TabIndex = 4;
            this.addressTxt.Visible = false;
            this.addressTxt.Validating += new System.ComponentModel.CancelEventHandler(this.addressTxt_Validating);
            // 
            // lastLbl
            // 
            this.lastLbl.AutoSize = true;
            this.lastLbl.Location = new System.Drawing.Point(23, 103);
            this.lastLbl.Name = "lastLbl";
            this.lastLbl.Size = new System.Drawing.Size(79, 20);
            this.lastLbl.TabIndex = 10;
            this.lastLbl.Text = "Last Name";
            // 
            // lastTxt
            // 
            this.lastTxt.Location = new System.Drawing.Point(111, 101);
            this.lastTxt.Name = "lastTxt";
            this.lastTxt.Size = new System.Drawing.Size(125, 27);
            this.lastTxt.TabIndex = 3;
            this.lastTxt.Validating += new System.ComponentModel.CancelEventHandler(this.lastTxt_Validating);
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(111, 200);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(94, 29);
            this.loginBtn.TabIndex = 11;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // firstErr
            // 
            this.firstErr.ContainerControl = this;
            // 
            // lastErr
            // 
            this.lastErr.ContainerControl = this;
            // 
            // addressErr
            // 
            this.addressErr.ContainerControl = this;
            // 
            // employeeErr
            // 
            this.employeeErr.ContainerControl = this;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 341);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.lastLbl);
            this.Controls.Add(this.lastTxt);
            this.Controls.Add(this.addressLbl);
            this.Controls.Add(this.addressTxt);
            this.Controls.Add(this.employeeLbl);
            this.Controls.Add(this.employeeTxt);
            this.Controls.Add(this.firstLbl);
            this.Controls.Add(this.firstTxt);
            this.Controls.Add(this.managerRadio);
            this.Controls.Add(this.customerRadio);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.firstErr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastErr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressErr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeErr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private RadioButton customerRadio;
        private RadioButton managerRadio;
        private Label firstLbl;
        private Label employeeLbl;
        private TextBox employeeTxt;
        private Label addressLbl;
        private Label lastLbl;
        private Button loginBtn;
        private ErrorProvider firstErr;
        private ErrorProvider lastErr;
        private ErrorProvider addressErr;
        private ErrorProvider employeeErr;
        public TextBox firstTxt;
        public TextBox addressTxt;
        public TextBox lastTxt;
    }
}