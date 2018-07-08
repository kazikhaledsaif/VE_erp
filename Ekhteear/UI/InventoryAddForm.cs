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
    public partial class InventoryAddForm : Form
    {
        Decimal newCost;
        Decimal dueAmount;
        Decimal totalBillAmount;
        InventoryManager inventoryManager = new InventoryManager();
        ProductModel productModel = new ProductModel();
        AgentModel agentModel = new AgentModel();
        private InventoryDetailModel inventoryDetailModel = new InventoryDetailModel();
        InventoryModel inventoryModel = new InventoryModel();
        CreditorModel creditorModel = new CreditorModel();
        CreditorManager creditorManager  = new CreditorManager();

        InventoryDetailModel selectedInventoryDetailModel = new InventoryDetailModel();
        private List<InventoryDetailModel> inventoryDetailModels;

        public InventoryAddForm()
        {
            InitializeComponent();
            dateTimePicker.Value = DateTime.Today;
            inventoryDetailsGrid.DataSource = null;
            FillGrid();
        }

        // minimzebutton
        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //cross button
        private void crossButton_Click(object sender, EventArgs e)
        {
            if (inventoryDetailsGrid.RowCount > 0)
            {
                MessageBox.Show("Please Remove All Data First");
            }
            else
            {
                Application.Exit();
            }
   
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
        // back button click
        private void BackButtonClick(object sender, EventArgs e)
        {
            if (inventoryDetailsGrid.RowCount>0)
            {
                MessageBox.Show("Please Remove All Data First");
            }
            else
            {
                var test = new InventoryForm();
                test.Closed += (s, args) => this.Close();
                test.Show();
                this.Hide();
            }

           
        }




        private void InventoryAddForm_Load(object sender, EventArgs e)
        {
            getStoreId();
            productDropDownFill();
            agentDropDownFill();
            FillGrid();
        }

        //get store id
        public void getStoreId()
        {
            string id = inventoryManager.GetStoreId();
            storeId.Text = id;

        }

        // product drop down
        public void productDropDownFill()
        {
            productModel.ProductId = -1;
            productModel.ProductName = "--Select--";
            List<ProductModel> productModels = inventoryManager.GetProductlList();
            productModels.Insert(0, productModel);
            productNameDD.DataSource = productModels;
            productNameDD.DisplayMember = "ProductName";
            productNameDD.ValueMember = "ProductId";
            productNameDD.Tag = productModel;

        }

        // agent drop down
        public void agentDropDownFill()
        {
            agentModel.AgentId = -1;
            agentModel.AgentName = "--Select--";
            List<AgentModel> agentModels = inventoryManager.GetAgentList();
            agentModels.Insert(0, agentModel);
            agentNameDD.DataSource = agentModels;
            agentNameDD.DisplayMember = "AgentName";
            agentNameDD.ValueMember = "AgentId";
            agentNameDD.Tag = agentModel;
        }

        //using product drop down get product info
        private void productNameDD_SelectedIndexChanged(object sender, EventArgs e)
        {

            ProductModel selectedProductModel = new ProductModel();
            selectedProductModel = (ProductModel) productNameDD.SelectedItem;
            productModel = inventoryManager.ProductInfo(selectedProductModel);
            productRate.Text = productModel.ProductBuyingRate.ToString();
            UnitTextBox.Text = productModel.ProductUnit;
        }

        //using agent drop down get agent info 
        private void agentNameDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            AgentModel selectedAgentModel = new AgentModel();
            selectedAgentModel = (AgentModel) agentNameDD.SelectedItem;
            agentModel = inventoryManager.AgentInfo(selectedAgentModel);
            companyName.Text = agentModel.CompanyName;
        }

        //quantity text changed
        private void quantity_TextChanged(object sender, EventArgs e)
        {

            decimal num;
            
           if (decimal.TryParse(quantity.Text, out num))
                {
                    decimal productRateData = Convert.ToDecimal(productRate.Text);
                    decimal quantityData = Convert.ToDecimal(quantity.Text);
                    newCost = productRateData * quantityData;

                    cost.Text = newCost.ToString();

                }
           else
           {
               quantity.ResetText();
               cost.ResetText();
           }


            
        }

        //cash paid text changed
        private void cashPaid_TextChanged(object sender, EventArgs e)
        {
            
                 decimal num;
           
                if (decimal.TryParse(cashPaid.Text, out num))
                {
                    decimal s = Convert.ToDecimal(cashPaid.Text);
                    dueAmount = totalBillAmount -s;
                    if (dueAmount <0)
                    {
                        MessageBox.Show("You Can't Pay More");
                          cashPaid.Clear();
                        due.ResetText();
                }
                    else
                    {
                        due.Text = dueAmount.ToString(); 
                    }
                   
                }
                  else
                   {
                
                         cashPaid.Clear();
                          due.ResetText();
                   }
       
           
        }

        //fill datagrid view
        private void FillGrid()
        {
           
            int StoreId = Convert.ToInt32(this.storeId.Text);
            inventoryDetailsGrid.DataSource = null;
            inventoryDetailModels = inventoryManager.GetInventoryDetailLists(StoreId);
            inventoryDetailsGrid.DataSource = inventoryDetailModels;
            inventoryDetailsGrid.ClearSelection();
            inventoryDetailsGrid.Tag = inventoryDetailModel;
            inventoryDetailsGrid.MultiSelect = false;
        }

        //reload dta grid view
        private void Reload_Click(object sender, EventArgs e)
        {
            FillGrid();
            inventoryDetailsGrid.Refresh();
        }
        //datagrid view cell click 

        private void inventoryDetailsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (inventoryDetailsGrid.CurrentRow != null)
                selectedInventoryDetailModel =
                    (InventoryDetailModel) inventoryDetailsGrid.CurrentRow.DataBoundItem;
        }

        //delete invetroy
        private void delete_Click(object sender, EventArgs e)
        {
            int isDone = inventoryManager.DeleteInvetory(selectedInventoryDetailModel);
            if (isDone > 0)
            { 
                MessageBox.Show("Item have been Removed");

                inventoryManager.GetProductDecrease(selectedInventoryDetailModel);
                totalBillAmount -= selectedInventoryDetailModel.Cost;
                totalBill.Text = totalBillAmount.ToString();
                FillGrid();
            }
            else
            {
                MessageBox.Show("Please Select a Row First");
            }
        }

        // add to inventory
        private void AddButton_Click(object sender, EventArgs e)
        {

            if (quantity.Text != "" && Convert.ToInt32(productNameDD.SelectedValue) != -1)
            {
               // InventoryDetailModel inventoryDetailModel = new InventoryDetailModel();
                inventoryDetailModel.InventoryId = Convert.ToInt32(storeId.Text);
                inventoryDetailModel.ProductId = (int) productNameDD.SelectedValue;
                inventoryDetailModel.Quantity = Convert.ToDecimal(quantity.Text);
                inventoryDetailModel.Cost = Convert.ToDecimal(cost.Text);
               // calling manager to insert data

                int isDone = inventoryManager.AddToInvetoryDetails(inventoryDetailModel);
                if (isDone > 0)
                {
                    MessageBox.Show("Inserted Sucessfully");
                    inventoryManager.GetProductIncrease(inventoryDetailModel);
                    totalBillAmount += Convert.ToDecimal(cost.Text);
                    totalBill.Text = totalBillAmount.ToString();
                    agentNameDD.Enabled = false;
                    Reset();
                    FillGrid();
                }
                else
                {
                    MessageBox.Show("Insert Unsucessful");
                     Reset();
                  
                }
            }
            else
            {
                MessageBox.Show("Fill All the Data");
            }
        }
        //reset fields

        public void Reset()
        {
            productNameDD.SelectedIndex = 0;
            quantity.Clear();
            cost.Text = "";
            productRate.Text = "";
            UnitTextBox.Text = "";
        }
        //purchse button
        private void Purchase_Click(object sender, EventArgs e)
        {
            if (cashPaid.Text != "" && totalBill.Text != "")
            {

                if (Convert.ToDecimal(totalBill.Text) > Convert.ToDecimal(cashPaid.Text))
                {
                    
                    AddToPurchase();

                    CreditorInsert();
                    inventoryDetailsGrid.DataSource = null;
                    inventoryDetailsGrid.Rows.Clear();
                    BackButtonClick(sender, e);

                }
                else if (Convert.ToDecimal(totalBill.Text) == Convert.ToDecimal(cashPaid.Text))
                {
                    AddToPurchase();
                    inventoryDetailsGrid.DataSource = null;
                    inventoryDetailsGrid.Rows.Clear();
                    BackButtonClick( sender,  e);
                }
                else
                {
                    MessageBox.Show("You Cannot Pay More than Total Ammount ");
                    cashPaid.Clear();
                    due.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Fill All the data ");
            }

        }
        //purshase method work to call manager and insert data
        private void AddToPurchase()

        {
            inventoryModel.AgentId = (int) agentNameDD.SelectedValue;
            inventoryModel.TotalBill =  Convert.ToInt32(this.totalBillAmount);
             inventoryModel.CashPaid= Convert.ToDecimal(this.cashPaid.Text);
            inventoryModel.Due= Convert.ToDecimal(this.due.Text);
            inventoryModel.Date = dateTimePicker.Value;



            int isDone = inventoryManager.Purchase(inventoryModel);
            if (isDone > 0)
            {

                MessageBox.Show("Purshased Sucessfully");
                

            }
            else
            {
                MessageBox.Show("Insert Unsucessful");
               
            }

        }

        private void CreditorInsert()
        {
            creditorModel.AgentId = inventoryModel.AgentId;
            creditorModel.CreditorDue = Convert.ToDecimal(this.due.Text);
            creditorModel.Date = dateTimePicker.Value;
            int isDone = creditorManager.InsertCreditor(creditorModel);
            if (isDone > 0)
            {

                MessageBox.Show("You are on Debt");


            }
            else
            {
                MessageBox.Show("Creditor Not working");

            }
        }

    }
}
