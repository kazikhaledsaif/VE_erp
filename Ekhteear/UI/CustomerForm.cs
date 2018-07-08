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
    public partial class CustomerForm : Form
    {

        private List<CustomerModel> customerList;
        private CustomerManager customerManager = new CustomerManager();
        private CustomerAddForm customerAddForm = new CustomerAddForm();
        private CustomerModel selectedCustomerModel = new CustomerModel();
        

        public CustomerForm()
        {
            InitializeComponent();
        }
        // minimize button
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
        private void CustomerForm_Load(object sender, EventArgs e)
        {
            LoadCustomer();
        }
        //load data to  grid view
        private void LoadCustomer()
        {
            customerList = customerManager.GetCustomerList();
            customerGridView.DataSource = customerList;
            customerGridView.ClearSelection();
            customerGridView.Tag = selectedCustomerModel;
            customerGridView.MultiSelect = false;

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            customerAddForm.ShowDialog();
            LoadCustomer();
            customerGridView.Update();
            customerGridView.ClearSelection();

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            CustomerUpdateForm customerUpdateForm = new CustomerUpdateForm(selectedCustomerModel);
            

            if (customerGridView.SelectedRows.Count > 0)
            {
                customerUpdateForm.ShowDialog();
                LoadCustomer();
                customerGridView.Update();
                customerGridView.ClearSelection();
            }
            else
            {
                MessageBox.Show("Please Select a Row First");
            }

        }

        private void customerGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (customerGridView.CurrentRow != null)
                selectedCustomerModel = (CustomerModel) customerGridView.CurrentRow.DataBoundItem;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int isDone = customerManager.DeleteCustomert(selectedCustomerModel);
            if (isDone > 0)
            {
                MessageBox.Show("Customer Is Deleted");
                LoadCustomer();
            }
            else
            {
                MessageBox.Show("Please Select a Row First");
            }
        }

        private void searchByName_TextChanged(object sender, EventArgs e)
        {
            List<CustomerModel> filtered = new List<CustomerModel>(customerList.Where(
                p => p.CustomerName.Contains(searchByName.Text)).ToList());
            customerGridView.DataSource = filtered;
            customerGridView.Refresh();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
         LoadCustomer();

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            var test = new Dashboard();
            test.Closed += (s, args) => this.Close();
            test.Show();
            this.Hide();
        }
    }
}
