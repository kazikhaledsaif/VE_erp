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
    public partial class ReturnGoodsForm : Form
    {
        
        private InventoryModel inventoryModel;
        List<InventoryDetailModel> inventoryDetailModels = new List<InventoryDetailModel>();
        InventoryDetailModel selectedInventoryDetailModel = new InventoryDetailModel();
        InventoryManager inventoryManager  = new InventoryManager();
        public ReturnGoodsForm(InventoryModel selectedInventoryModel)
        {
            InitializeComponent();

            inventoryModel = selectedInventoryModel;
        }

        private void ReturnGoods_Load(object sender, EventArgs e)
        {
            FillInventory();
        }
        public void FillInventory()
        {
            InventoryManager imanage = new InventoryManager();
            inventoryDetailModels = imanage.GetInventoryDetailViewLists(inventoryModel);
            InventoryReturnDataGridView.DataSource = inventoryDetailModels;
            InventoryReturnDataGridView.Tag = selectedInventoryDetailModel;
            InventoryReturnDataGridView.ClearSelection();
           
        }

        private void InventoryReturnDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (InventoryReturnDataGridView.CurrentRow != null)
            {
                selectedInventoryDetailModel = (InventoryDetailModel)InventoryReturnDataGridView.CurrentRow.DataBoundItem;

                productName.Text = selectedInventoryDetailModel.ProductName;
                productQuantity.Text = selectedInventoryDetailModel.Quantity.ToString();
            }
              
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

            if (Return.Text != "")
            {
                if (Convert.ToDecimal(Return.Text) <= Convert.ToDecimal(productQuantity.Text))
                {
                    selectedInventoryDetailModel.Quantity = Convert.ToDecimal(Return.Text);
                    int isDone = inventoryManager.InventoryDecreaseCall(selectedInventoryDetailModel);
                    if (isDone > 0)
                    {
                        inventoryManager.GetProductDecrease(selectedInventoryDetailModel);
                        MessageBox.Show("Return Sucessfull");

                        FillInventory();
                    }
                    else
                    {
                        MessageBox.Show("Return Unsucessfull");
                    }
                }
                else
                {
                    MessageBox.Show("You Can't Return More Then Purchase");
                    Return.ResetText();
                }

              
            }
            else
            {

                MessageBox.Show("Fill Return Data");
            }
        }

        private void Return_TextChanged(object sender, EventArgs e)
        {
            decimal num;

            if (decimal.TryParse(Return.Text, out num))
            {
               

            }
            else
            {
                Return.ResetText();
              
            }
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
        // back button click
        private void BackButtonClick(object sender, EventArgs e)
        {
           
         this.Close();


        }




    }
}
