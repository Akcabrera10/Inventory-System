using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Linq;
using System.Collections.Generic;
using System.CodeDom.Compiler;
using System.Globalization;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

//The Customer/Checkout was created by Arvyn Cabrera
namespace UI_Project
{
    public partial class CustomerForm : Form
    {
        public LoginForm main_menu;
        public string first;
        public string last;
        public string postal;
        List<Product> products = new List<Product>();
        List<Product> cart = new List<Product>();
        public CustomerForm()
        {
            
            InitializeComponent();
            var path = Path.Combine(Directory.GetCurrentDirectory(), "\\test.txt");
            string data;
            using var fs = new FileStream("test.txt", FileMode.Open, FileAccess.ReadWrite, FileShare.None);

            using var sr = new StreamReader(fs);

            while ((data = sr.ReadLine()) != null)
            {
                string[] s = data.Split(',');
                products.Add(new Product(s[0], s[1], Convert.ToDouble(s[2]), Convert.ToInt32(s[3])));
                customerList.Items.Add(s[0]);

            }
            customerList.Sorted = true;
            
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            ManagerForm f;
        }

        private void CustomerForm_Load_1(object sender, EventArgs e)
        {

        }

        // loads the value of inventory based on item selected
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            quantityTxt.Value = 1;

            string listName = customerList.GetItemText(customerList.SelectedItem); //get the name from the passengerlist
            for (int i = 0; i < products.Count; i++)
            {
                if (listName == products[i].name)
                {
                    productTxt.Text = products[i].name;
                    priceTxt.Text = products[i].price.ToString();
                    categoryTxt.Text = products[i].category;
                    labelQty.Text = "Product quantity: " + products[i].quantity.ToString();
                    labelAdd.Visible = false;
                    labelOver.Visible = false;
                    return;

                }
            }
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

        // signs out and saves inventory to a text file
        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            main_menu.Show();
            this.Close();

            File.WriteAllText("test.txt", String.Empty);
            using var fs = new FileStream("test.txt", FileMode.Open, FileAccess.ReadWrite, FileShare.None);
            using var sw = new StreamWriter(fs);

            foreach (Product product in products)
            {
                sw.WriteLine(product.name + "," + product.category + "," + product.price + "," + product.quantity);
            }
            main_menu.Show();
            main_menu.Reset();
            this.Close();
        }


        // whenever add to cart is clicked, function runs, it checks if the item is already in the cart and if it is, it doesn't add the name
        private void button1_Click(object sender, EventArgs e)
        {
            bool cartUsed = false;
            int temp = 0;
            string listName = customerList.GetItemText(customerList.SelectedItem); //get the name from the passengerlist

            for (int i = 0; i < products.Count; i++)
            { 
                if (listName == products[i].name)
                {
                    temp = Math.Abs(products[i].quantity) - Convert.ToInt32(quantityTxt.Value);

                    if (temp >= 0) {
                        for (int j = 0; j < cart.Count; j++)
                        {
                            if (listName == cart[j].name)
                            {
                                cart[j].quantity = cart[j].quantity + Convert.ToInt32(quantityTxt.Value);
                                products[i].quantity = products[i].quantity - Convert.ToInt32(quantityTxt.Value);
                                labelAdd.Visible = true;
                                cartUsed = true;
                                for (int a = 0; a < products.Count; a++)
                                {
                                    if (listName == products[a].name)
                                    {
                                 
                                        labelQty.Text = "Product quantity: " + products[a].quantity.ToString();
                                 
                                        return;

                                    }
                                }


                                return;
                            }
                        }
                    }

                    else
                    {
                        labelAdd.Visible = false;
                        labelOver.Visible = true;
                        cartUsed = true;
                    }
                }
            }

            if (cartUsed == false)
            {
                
                for (int i = 0; i < products.Count; i++)
                {
                    if (listName == products[i].name)
                    {
                        temp = products[i].quantity - Convert.ToInt32(quantityTxt.Value);
                        if (temp >= 0)
                        {
                            products[i].quantity = products[i].quantity - Convert.ToInt32(quantityTxt.Value);
                            cart.Add(new Product(productTxt.Text, categoryTxt.Text, Convert.ToDouble(priceTxt.Text), Convert.ToInt32(quantityTxt.Value)));
                            labelAdd.Visible = true;
                            for (int a = 0; a < products.Count; a++)
                            {
                                if (listName == products[a].name)
                                {

                                    labelQty.Text = "Product quantity: " + products[a].quantity.ToString();

                                    return;

                                }
                            }

                        }
                    }
                }
                cartUsed = false;
            }
            temp = 0;
          
           
        }

        // resets ui items and clears them
        private void Reset()
        {
            customerList.SelectedIndex = -1;
            customerList.Sorted = true;
            cartProd.Clear();
            cartQty.Value = 1;
            cartPrice.Clear();
            productTxt.Clear();
            priceTxt.Clear();
            quantityTxt.Value = 1;
        }

        // button used to click to go to the cart
        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            cartList.Items.Clear();
            foreach (Product item in cart)
            {
                cartList.Items.Add(item.name);
            }

            cartList.Sorted = true;
            
        }

        // btn used to go back to the customer inventory list
        private void btnBack1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
            checkBtn.Enabled = true;
            txtReceipt.Visible = false;
            customerList.SelectedIndex = -1;
        }

        private void btnBack2_Click(object sender, EventArgs e)
        {

        }

        // same list shows value in the cart whenever selected
        private void cartList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string listName = cartList.GetItemText(cartList.SelectedItem); //get the name from the passengerlist
            lblNoUpdate.Visible = false;
            labelUpdate.Visible = false;
            for (int i = 0; i < cart.Count; i++)
            {
                if (listName == cart[i].name)
                {
                    cartProd.Text = cart[i].name;
                    cartPrice.Text = cart[i].price.ToString();
                    cartQty.Value = cart[i].quantity;
                    return;
                }
            }
            lblNoUpdate.Visible = false;
            labelUpdate.Visible = false;
        }

        // updates values of the cart quantity, adds to customer list and deducts when needed
        private void cartUpdateBtn_Click(object sender, EventArgs e)
        {
            cartList.Sorted = true;
            if (cartList.Items.Count > 0 && cartList.SelectedItem != null) //find entry, and remove from the list
            {
                //update item in the product list
                string listName = cartList.GetItemText(cartList.SelectedItem); //get the name from the passengerlist
                var itemToFind = cart.Single(r => r.name == cartList.SelectedItem.ToString());
                int temp = itemToFind.quantity;
                int min = 0;
                itemToFind.quantity = Convert.ToInt32(cartQty.Value);
                cartList.Items.Add(cartProd.Text);
                cartList.Items.RemoveAt(cartList.Items.IndexOf(cartList.SelectedItem));
               

                if (Convert.ToInt32(cartQty.Value) > temp)
                {
                    min =  Convert.ToInt32(cartQty.Value) - temp;
                    var itemToRemove = cart.Single(r => r.name == cartList.SelectedItem.ToString());
                    for (int i = 0; i < products.Count; i++)
                    {
                        if (listName == products[i].name && min >= 0 && products[i].quantity - min >= 0 && products[i].quantity > 0)
                        {
                            products[i].quantity = products[i].quantity - min;


                            for (int j = 0; j < cart.Count; j++)
                            {

                                if (listName == cart[j].name && cart[j].quantity == 0)
                                {
                                    cartList.Items.RemoveAt(cartList.Items.IndexOf(cartList.SelectedItem));
                                    cart.Remove(itemToRemove);
                                    return;
                                }

                                else if (listName == cart[j].name && products[i].quantity > 0)
                                {
                                    cart[j].quantity = Convert.ToInt32(cartQty.Value);
                                    lblNoUpdate.Visible = false;
                                    labelUpdate.Visible = true;
                                    return;
                                }
                            }
                        }

                        else if(products[i].quantity <= 0)
                        {

                            lblNoUpdate.Visible = true;
                            labelUpdate.Visible = false;
                            for (int j = 0; j < cart.Count; j++)
                            { 
                                if (listName == cart[j].name)
                                {
                                    cart[j].quantity = temp;
                                    return;
                                }
                            }
                            
                        }
                    }
                }
                    
                else if (Convert.ToInt32(cartQty.Value) < temp)
                        {
                            min = temp - Convert.ToInt32(cartQty.Value);
                            var itemToRemove = cart.Single(r => r.name == cartList.SelectedItem.ToString());
                            for (int i = 0; i < products.Count; i++)
                            {
                               if (listName == products[i].name && min >= 0)
                               {
                                    products[i].quantity = products[i].quantity + min;

                                      for (int j = 0; j < cart.Count; j++)
                                      {

                                         if (listName == cart[j].name)
                                         {
                                              cart[j].quantity = Convert.ToInt32(cartQty.Value);

                                                  if (cart[j].quantity == 0)
                                                  {
                                                    cartList.Items.RemoveAt(cartList.Items.IndexOf(cartList.SelectedItem));
                                                    cart.Remove(itemToRemove);
                                                  }
                                         }
                                      }
                               }
                     
                            }
                }
            }
        }

        // toolstrip menu bubble sort for produce
        private void produceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(tabControl1.SelectedIndex == 0)
            {
                customerList.Items.Clear();
                foreach (Product item in products)
                {
                    if (item.category == "meat")
                    {
                        customerList.Items.Add(item.name);
                    }
                }

            }
        }

        // bubble sort to sort vegetable category

        private void vegetableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                customerList.Items.Clear();
                foreach (Product item in products)
                {
                    if (item.category == "vegetable")
                    {
                        customerList.Items.Add(item.name);
                    }
                }

            }
        }

        // bubble sort to sort dairy category
        private void dairyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                customerList.Items.Clear();
                foreach (Product item in products)
                {
                    if (item.category == "dairy")
                    {
                        customerList.Items.Add(item.name);
                    }
                }

            }
        }

        // bubble sort to sort grain category
        private void grainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                customerList.Items.Clear();
                foreach (Product item in products)
                {
                    if (item.category == "grain")
                    {
                        customerList.Items.Add(item.name);
                    }
                }

            }
        }

        // to sort a-z using bubble sort

        private void aZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                customerList.Items.Clear();
                foreach (Product item in products)
                {
                 
                  customerList.Items.Add(item.name);
                    
                }

            }
            customerList.Sorted = true;
        }

        // to sort z-a using bubble sort

        private void zAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product temp;

            if (tabControl1.SelectedIndex == 0)
            {
                customerList.Sorted = false;
                customerList.Items.Clear();
                for (int i = 0; i < products.Count; i++)
                {
                    for (int j = 0; j < products.Count-1; j++)
                    {
                        if (products[i].name.CompareTo(products[j].name) > 0)
                        {
                            temp = products[i];
                            products[i] = products[j];
                            products[j] = temp;
                        }
                    }
                }


                foreach (Product prod in products)
                {
                    customerList.Items.Add(prod.name);
                }
            }
        }

        // to sort list from highest price to lowest using bubble sort
        private void highestToLowestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product temp;

            if (tabControl1.SelectedIndex == 0)
            {
                customerList.Sorted = false;
                customerList.Items.Clear();
                for (int i = 0; i < products.Count; i++)
                {
                    for (int j = 0; j < products.Count - 1; j++)
                    {
                        if (products[j].price < products[j + 1].price)
                        {
                            temp = products[j];
                            products[j] = products[j+1];
                            products[j+1] = temp;
                        }
                    }
                }


                foreach (Product prod in products)
                {
                    customerList.Items.Add(prod.name);
                }
            }
        }

        // sort list from lowest to highest price using bubble sort
        private void lowestToHighestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product temp;
            if (tabControl1.SelectedIndex == 0)
            {
                customerList.Sorted = false;
                customerList.Items.Clear();
                for (int i = 0; i < products.Count; i++)
                {
                    for (int j = 0; j < products.Count-1; j++)
                    {
                        if (products[j].price > products[j+1].price)
                        {
                            temp = products[j+1];
                            products[j+1] = products[j];
                            products[j] = temp;
                        }
                    }
                }

                foreach (Product prod in products)
                {
                    customerList.Items.Add(prod.name);
                }
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void quantityTxt_ValueChanged(object sender, EventArgs e)
        {

        }


        // checkout function to show receipt
        private void checkBtn_Click(object sender, EventArgs e)
        {
            int temp = 0;

                if (txtCard.Text.ToString().Length == 12 && txtCV.Text.ToString().Length == 3)
                {
                    errorProvider1.Clear();
                    errorProvider2.Clear();

                if (radDelivery.Checked == true)
                {
                    txtReceipt.Visible = true;
                    txtReceipt.AppendText("******* CHECK OUT CART *******");
                    txtReceipt.AppendText(Environment.NewLine);
                    txtReceipt.AppendText("Order for DELIVERY");
                    txtReceipt.AppendText(Environment.NewLine);
                    txtReceipt.AppendText("Address: "); txtReceipt.AppendText(txtAddress.Text);
                    txtReceipt.AppendText(Environment.NewLine);

                    foreach (Product prod in cart)
                    {
                        txtReceipt.AppendText(prod.name.ToString() + " (" + prod.quantity + ") " + "($" + prod.price + ")");
                        txtReceipt.AppendText(Environment.NewLine);
                    }

                    foreach (Product prod in cart)
                    {
                        temp = (int)(temp + prod.price * prod.quantity);
                    }

                    txtReceipt.AppendText(Environment.NewLine);
                    txtReceipt.AppendText("******* TOTAL *******");
                    txtReceipt.AppendText(Environment.NewLine);
                    txtReceipt.AppendText("Total without taxes: $" + temp.ToString());
                    txtReceipt.AppendText(Environment.NewLine);
                    temp = (int)(temp * 1.13);
                    txtReceipt.AppendText("Total with taxes: $" + temp.ToString());

                    NewOrder();
                    checkBtn.Enabled = false;
                }

                else if (radPickup.Checked == true)
                {
                    txtReceipt.Visible = true;
                    txtReceipt.AppendText("******* CHECK OUT CART *******");
                    txtReceipt.AppendText(Environment.NewLine);
                    txtReceipt.AppendText("Order for PICKUP");
                    txtReceipt.AppendText(Environment.NewLine);
                    txtReceipt.AppendText("Time for pickup: "); txtReceipt.AppendText(timePickup.Value.ToString());
                    txtReceipt.AppendText(Environment.NewLine);

                    foreach (Product prod in cart)
                    {
                        txtReceipt.AppendText(prod.name.ToString() + " (" + prod.quantity + ") " + "($" + prod.price + ")");
                        txtReceipt.AppendText(Environment.NewLine);
                    }

                    foreach (Product prod in cart)
                    {
                        temp = (int)(temp + prod.price * prod.quantity);
                    }

                    txtReceipt.AppendText(Environment.NewLine);
                    txtReceipt.AppendText("******* TOTAL *******");
                    txtReceipt.AppendText(Environment.NewLine);
                    txtReceipt.AppendText("Total without taxes: $" + temp.ToString());
                    txtReceipt.AppendText(Environment.NewLine);
                    temp = (int)(temp * 1.13);
                    txtReceipt.AppendText("Total with taxes: $" + temp.ToString());

                    NewOrder();
                    checkBtn.Enabled = false;
                }

            }

                else if (txtCard.Text.ToString().Length != 12)
                {
                     errorProvider1.SetError(txtCard, "Please input correct 12-digit card information");

                          if (txtCV.Text.ToString().Length != 3)
                          {
                            errorProvider2.SetError(txtCV, "Please input correct 3-digit CV information");
                          }

                if (txtAddress.Text.ToString().Length == 0)
                {
                    errorProvider2.SetError(txtCV, "Please input correct 3-digit CV information");
                }

            }
            }

            private void button2_Click(object sender, EventArgs e)
        {

        }

        private void txtCard_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCard_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                errorCard.SetError(txtCard, "Invalid input prevented. Please input numerical input only.");
                e.Handled = true;
            }

            else
            {
                errorCard.Clear();
            }
        }

        private void txtCV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                errorCV.SetError(txtCV, "Invalid input prevented. Please input numerical input only.");
                e.Handled = true;
            }

            else
            {
                errorCV.Clear();
            }
        }

        private void CustomerForm_Shown(object sender, EventArgs e)
        {
            csPostal.Text = postal;
            csName.Text = first + " " + last;
            cartPostal.Text = postal;
            cartName.Text = first + " " + last;
        }

        private void cartPostal_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewOrder()
        {
            cartList.Items.Clear();
            cartProd.Clear();
            cartName.Clear();
            cartPostal.Clear();
            cartPrice.Clear();
            cartName.Clear();
            cartPostal.Clear();
            txtCard.Clear();
            txtCV.Clear();
            dateTimePicker1.Value = DateTime.Today;
            cartQty.Value = 1;
            cart.Clear();
            radDelivery.Checked = false;
            radPickup.Checked = false;
            txtAddress.Clear();
            timePickup.Value = DateTime.Today;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetterOrDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                errorAddress.SetError(txtAddress, "Invalid input prevented. Please use only alphanumberical characters.");
                e.Handled = true;
            }
        }

        private void radDelivery_CheckedChanged(object sender, EventArgs e)
        {
            lblDelivery.Visible = true;
            txtAddress.Visible = true;
            lblPickup.Visible = false;
            timePickup.Visible = false;
        }

        private void radPickup_CheckedChanged(object sender, EventArgs e)
        {
            lblDelivery.Visible = false;
            txtAddress.Visible = false;
            lblPickup.Visible = true;
            timePickup.Visible = true;
        }
    }   
}
