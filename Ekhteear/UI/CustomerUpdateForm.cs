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
    public partial class CustomerUpdateForm : Form
    {
        private  CustomerManager customerManager = new CustomerManager();
        private CustomerModel updateCustomerModel;

        public CustomerUpdateForm( CustomerModel customerModel)
        {
            InitializeComponent();
            updateCustomerModel = customerModel;

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
        private void CustomerUpdateForm_Load(object sender, EventArgs e)
        {
            Filldate();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (CustomerName.Text != null && CustomerTypeDD.SelectedIndex != -1)
            {
                try
                {
                    //creating  Customer class and Save All data to object

                    updateCustomerModel.CustomerName = CustomerName.Text;
                    updateCustomerModel.CompanyName = CustomerCompany.Text;
                    updateCustomerModel.PhoneNumber = CustomerPhn.Text;
                    updateCustomerModel.CustomerType = CustomerTypeDD.Text;
                   // updateCustomerModel.Date = DateTime.Today;

                    // calling manager to insert data

                    int isDone = customerManager.CustomerUpdate(updateCustomerModel);
                    if (isDone > 0)
                    {
                        MessageBox.Show("Update Sucessfully");
                      this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Update Unsucessful");
                    
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Try Again");
             
                }


            }
            else
            {
                MessageBox.Show("Please Fill all Data");

            }
        }

        public void Filldate()
        {
            customerIdLabel.Text = updateCustomerModel.CustomerId.ToString();
            CustomerName.Text = updateCustomerModel.CustomerName;
            CustomerCompany.Text = updateCustomerModel.CompanyName;
            CustomerPhn.Text = updateCustomerModel.PhoneNumber;
            CustomerTypeDD.Text = updateCustomerModel.CustomerType;
        }
    }
}
