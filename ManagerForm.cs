using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//The Manager/Inventory was created by Jeffrey Chabot
namespace UI_Project
{
    public partial class ManagerForm : Form
    {
        public LoginForm main_menu;
        List<Product> products = new List<Product>();

        public ManagerForm()
        {
            InitializeComponent();
            string data;
            using var fs = new FileStream("test.txt", FileMode.Open, FileAccess.ReadWrite, FileShare.None);
            using var sr = new StreamReader(fs);

            //read inventory from text file, and create the inventory list
            while((data = sr.ReadLine()) != null)
            {
                string[] s = data.Split(',');
                products.Add(new Product(s[0], s[1], Convert.ToDouble(s[2]), Convert.ToInt32(s[3])));
                productList.Items.Add(s[0]);
            }
        }
       
        //Logout the user to the main menu
        private void logoutBtn_Click(object sender, EventArgs e)
        {
            File.WriteAllText("test.txt", String.Empty);
            using var fs = new FileStream("test.txt", FileMode.Open, FileAccess.ReadWrite, FileShare.None);
            using var sw = new StreamWriter(fs);

            //save inventory information to the textfile
            foreach (Product product in products)
            {
                sw.WriteLine(product.name + "," + product.category + "," + product.price + "," + product.quantity);
            }

            //open the main menu, and close manager
            main_menu.Show();
            main_menu.Reset();
            this.Close();
        }

        //add a product to the inventory
        private void addBtn_Click(object sender, EventArgs e)
        {
            string category="";

            //check to see all appropriate fields are entered and valid
            if(ValidateProductName(nameTxt,nameErr) && ValidatePrice(priceTxt,priceErr) && ValidateCategory(categoryErr) && !ProductExists(nameTxt.Text,nameErr))
            {
                productList.Items.Add(nameTxt.Text);

                //determine the category
                if(dairyRadio.Checked)
                {
                    category = "dairy";
                }
                else if(grainRadio.Checked)
                {
                    category = "grain";
                }
                else if(meatRadio.Checked)
                {
                    category = "meat";
                }
                else if(vegetableRadio.Checked)
                {
                    category = "vegetable";
                }

                products.Add(new Product(nameTxt.Text, category, Convert.ToDouble(priceTxt.Text), Convert.ToInt32(qtyCounter.Value)));
                Reset();
            }
        }

        //check the name textbox and make sure that an appropriate value has been entered
        private bool ValidateProductName(TextBox txt, ErrorProvider err) //check customer name is valid
        {
            if (txt.Text == "") //check if a name is entered
            {
                err.SetError(txt, "Please enter product name");
                return false;
            }

            err.SetError(txt, ""); //name is valid
            return true; ;
        }

        //Check the price text box and make sure that an appropriate value has been entered
        private bool ValidatePrice(TextBox txt, ErrorProvider err)
        {
            double price;

            if (txt.Text == "") //check if a name is entered
            {
                err.SetError(txt, "Please enter price");
                return false;
            }

            if(Double.TryParse(txt.Text,out price)) //check if price is a number (whole or decimal)
            {
                err.SetError(txt, "");
                return true;
            }
            else
            {
                err.SetError(txt, "Please enter either a whole number, or decimal");
                return false;
            }
        }

        //check to make sure that a category has been selected
        private bool ValidateCategory(ErrorProvider err)
        {
            if(dairyRadio.Checked == false && meatRadio.Checked == false && vegetableRadio.Checked == false && grainRadio.Checked==false)
            {
                err.SetError(categoryLbl, "Select one of the categories for the product");
                return false;
            }
            else
            {
                return true;
                err.SetError(categoryLbl,"");
            }
        }

        //reset the display
        private void Reset() //reset all entry fields
        {
            nameErr.SetError(nameTxt,"");
            productList.SelectedIndex = -1;
            productList.Sorted = true;
            addBtn.Enabled = true;
            removeBtn.Enabled = false;
            updateBtn.Enabled = false;
            nameTxt.Clear();
            priceTxt.Clear();
            dairyRadio.Checked = false;
            meatRadio.Checked = false;
            vegetableRadio.Checked = false;
            grainRadio.Checked = false;
            qtyCounter.Value = 0;
        }

        class Product
        {
            public string name;
            public double price;
            public int quantity;
            public string category;

            public Product()
            {
                name = "";
                category = "";
                quantity = 0;
                price = 0;
            }
            public Product(string n, string c, double p, int q)
            {
                name = n;
                category = c;
                quantity = q;
                price = p;
            }
        }

        //modify display and show the values of the selected product
        private void productList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string listName = productList.GetItemText(productList.SelectedItem); //get the name from the passengerlist
            for (int i = 0; i < products.Count; i++)
            {
                if(listName == products[i].name)
                {
                    nameTxt.Text = products[i].name; //edit the text fields to match the product
                    priceTxt.Text = products[i].price.ToString();
                    qtyCounter.Value = products[i].quantity;

                    //check the appropriate category radio button
                    if (products[i].category == "meat") 
                    {
                        meatRadio.Checked = true;
                    }
                    else if(products[i].category == "dairy")
                    {
                        dairyRadio.Checked = true;
                    }
                    else if(products[i].category == "vegetable")
                    {
                        vegetableRadio.Checked = true;
                    }
                    else
                    {
                        grainRadio.Checked = true;
                    }


                    DisplaySelect();
                    return;
                }
            }
        }


        private void DisplaySelect()
        {
            nameErr.SetError(nameTxt,"");
            addBtn.Enabled = false;
            removeBtn.Enabled = true;
            updateBtn.Enabled = true;
        }

        //check to see if the product exists in the list
        private bool ProductExists(string s, ErrorProvider err)
        {
  
            foreach(Product p in products)
            {
                if(p.name == s)
                {
                    err.SetError(nameTxt, "Product already exists in the inventory");
                    return true;                    
                }
            }

            err.SetError(nameTxt, "");
            return false;
        }

        //Update a selected product in the product list
        private void updateBtn_Click(object sender, EventArgs e)
        {
            string category = "";
            int i = 0;
            int select = productList.SelectedIndex;

            //determine if the updated name is already in the product list
            foreach (var product in productList.Items)
            {
                if (i != select) //check all items except the currently selected
                {
                    if (product.ToString() == nameTxt.Text)
                    {
                        select = -1;
                    }
                }
                i++;
            }

            //check to make sure all valid fields are entered
            if (ValidateProductName(nameTxt, nameErr) && ValidatePrice(priceTxt, priceErr) && ValidateCategory(categoryErr) && select != -1)
            {
                productList.Items.Add(nameTxt.Text);
                if (dairyRadio.Checked)
                {
                    category = "dairy";
                }
                else if (grainRadio.Checked)
                {
                    category = "grain";
                }
                else if (meatRadio.Checked)
                {
                    category = "meat";
                }
                else if (vegetableRadio.Checked)
                {
                    category = "vegetable";
                }

                //update the inventory list box
                if (productList.Items.Count > 0 && productList.SelectedItem != null) //find entry, and remove from the list
                {
                    //update item in the product list
                    var itemToFind = products.Single(r => r.name == productList.SelectedItem.ToString());
                    itemToFind.name = nameTxt.Text;
                    itemToFind.category = category;
                    itemToFind.price = Convert.ToDouble(priceTxt.Text);
                    itemToFind.quantity = Convert.ToInt32(qtyCounter.Value);

                    productList.Items.RemoveAt(productList.Items.IndexOf(productList.SelectedItem));
                }
                Reset();
            }
            if (select == -1)
            {
                nameErr.SetError(nameTxt, "Product already exists in the inventory");
            }
        }

        //remove a item from the product list
        private void removeBtn_Click(object sender, EventArgs e)
        {
            var itemToRemove = products.Single(r => r.name == productList.SelectedItem.ToString());
            products.Remove(itemToRemove);

            if (productList.Items.Count > 0 && productList.SelectedItem != null) //find entry, and remove from the list
            {
                productList.Items.RemoveAt(productList.Items.IndexOf(productList.SelectedItem));
            }

            Reset();
        }

        private void nameTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
