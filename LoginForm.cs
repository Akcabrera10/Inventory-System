using System.Collections.Generic;
using System.Xml.Linq;

//Main menu/login was created by Jeffrey Chabot
namespace UI_Project
{
    
    public partial class LoginForm : Form
    {
        string fName = "";
        string lName = "";
        string postal = "";
        public LoginForm()
        {
            InitializeComponent();
            fName = "";
            lName = "";
            postal = "";
        }

        //Display Customer login information
        private void customerRadio_CheckedChanged(object sender, EventArgs e)
        {
            addressLbl.Visible = true; //show customer log in fields
            addressTxt.Visible = true;
            employeeLbl.Visible = false;
            employeeTxt.Visible = false;
            employeeTxt.Clear();
        }

        //display manager login information
        private void managerRadio_CheckedChanged(object sender, EventArgs e)
        {
            addressLbl.Visible = false; //display manager login fields
            addressTxt.Visible = false;
            employeeLbl.Visible = true;
            employeeTxt.Visible = true;
            addressTxt.Clear();
        }

        //determine if name is valid
        private bool ValidateName(TextBox txt, ErrorProvider err) //check customer name is valid
        {
            if (txt.Text == "") //check if a name is entered
            {
                err.SetError(txt, "Please enter name");
                return false;
            }

            foreach (char c in txt.Text) //check if name is alphanumeric
            {
                if (!char.IsLetter(c))
                {
                    err.SetError(txt, "Invalid input. Name must only contain letters. Please re-enter your name\n");
                    return false;
                }
            }

            err.SetError(txt, ""); //name is valid
            return true; ;
        }

        //determine if employee number is valid
        private bool ValidateEmployeeNumber(TextBox txt, ErrorProvider err)
        {
            if(txt.Text == "")
            {
                err.SetError(txt,"Please enter your 4-digit employee number");
                return false;
            }

            foreach (char c in txt.Text) //check if name is alphanumeric
            {
                if (!char.IsDigit(c))
                {
                    err.SetError(txt, "Invalid input. Employee number must only contain digits. Please re-enter your name\n");
                    return false;
                }
            }

            if (txt.Text.Length != 4) //check if number is 10 digits long
            {
                err.SetError(txt, "Employee number must be EXACTLY 4 digits. Please re-enter employee number.");
                return false;
            }

            err.SetError(txt, ""); //number is valid
            return true;
        }

        //determine if address is valid
        private bool ValidateAddress(TextBox txt, ErrorProvider err) //check if postal code is valid
        {
            if (txt.Text.Length != 7) //check if postal is appropriate length
            {
                err.SetError(txt, "Postal code is not correct length. Format: LDL LDL");
                return false;
            }

            if (!char.IsLetter(txt.Text[0]) || !char.IsDigit(txt.Text[1]) || !char.IsLetter(txt.Text[2]) || txt.Text[3] != ' ' || !char.IsDigit(txt.Text[4]) || !char.IsLetter(txt.Text[5]) || !char.IsDigit(txt.Text[6])) //check if postal code is LDL LDL format
            {
                err.SetError(txt, "Postal code is not in the format: LDL LDL");
                return false;
            }

            err.SetError(txt, ""); //postal code is valid
            return true;
        }


        private void firstTxt_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateName(firstTxt, firstErr);
        }

        private void lastTxt_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateName(lastTxt, lastErr);
        }

        private void addressTxt_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateAddress(addressTxt, addressErr);
        }

        private void employeeTxt_Validating_1(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateEmployeeNumber(employeeTxt, employeeErr);
        }

        //Login as the chosen user type (manager or customer)
        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (managerRadio.Checked) //if logging in as manager, open the Inventory Manager
            {
                if (ValidateName(firstTxt, firstErr) && ValidateName(lastTxt, lastErr) && ValidateEmployeeNumber(employeeTxt, employeeErr))
                {
                    Hide();
                    ManagerForm mf = new ManagerForm();
                    mf.main_menu = this; 
                    mf.Show();
                }
            }

            if (customerRadio.Checked) //if logging in as customer, open the storefront
            {
                if (ValidateName(firstTxt, firstErr) && ValidateName(lastTxt, lastErr) && ValidateAddress(addressTxt, addressErr))
                {
                    Hide();
                    CustomerForm cf = new CustomerForm();
                    cf.main_menu = this;
                    cf.first = firstTxt.Text;
                    cf.last = lastTxt.Text;
                    cf.postal = addressTxt.Text;
                    cf.Show();
                }
            }
        }

        //reset all text fields
        public void Reset()
        {
            firstTxt.Text = "";
            lastTxt.Text = "";
            addressTxt.Text = "";
            employeeTxt.Text = "";
        }

        private void firstTxt_TextChanged(object sender, EventArgs e)
        {

        }


        /*public void getName()
        {
            fName = firstTxt.Text;
            lName = lastTxt.Text;
            postal = addressTxt.Text;
        }*/
    }
}