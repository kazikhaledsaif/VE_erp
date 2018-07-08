using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manager;
using Model;

namespace Ekhteear.UI
{
    public partial class CustomerAddForm : Form
    {

        private CustomerManager customerManager = new CustomerManager();

        public CustomerAddForm()
        {
            InitializeComponent();
        }

        // minimzebutton
        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //cross button
        private void crossButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //maximize button 
        private void maximizeButton_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }

        }

        //Get customer id 
        public void GetCustomerId()
        {
            string CustomerId = customerManager.GetCustomerId();
            customerIdLabel.Text = CustomerId;
        }

        //reset all textbox

        public void Reset()
        {
            GetCustomerId();
            CustomerName.ResetText();
            CustomerCompany.ResetText();
            CustomerPhn.ResetText();
            CustomerTypeDD.SelectedIndex = -1;
        }

        private void CustomerAddForm_Load(object sender, EventArgs e)
        {
            Reset();

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (CustomerName.Text  != null && CustomerTypeDD.SelectedIndex !=-1)
            {
                try
                {
                    //creating  ProductModel class and Save All data to object
                      CustomerModel customerModel = new CustomerModel();
                    customerModel.CustomerName = CustomerName.Text;
                    customerModel.CompanyName = CustomerCompany.Text;
                    customerModel.PhoneNumber = CustomerPhn.Text;
                    customerModel.CustomerType = CustomerTypeDD.Text;
                    customerModel.Date = DateTime.Today;
         
                    // calling manager to insert data

                    int isDone = customerManager.CustomerInsert(customerModel);
                    if (isDone > 0)
                    {
                        MessageBox.Show("Inserted Sucessfully");
                        Reset();

                    }
                    else
                    {
                        MessageBox.Show("Insert Unsucessful");
                        Reset();
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Try Again");
                    Reset();
                }



            }
            else
            {
                MessageBox.Show("Please Fill all Data");
                
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
