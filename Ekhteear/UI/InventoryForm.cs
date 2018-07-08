using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gateway;
using Manager;
using Model;

namespace Ekhteear.UI
{
    public partial class InventoryForm : Form
    {
       InventoryManager inventoryManager= new InventoryManager();
        InventoryModel selectedInventoryModel = new InventoryModel();
        List<InventoryModel> inventoryModels = new List<InventoryModel>();
        public InventoryForm()
        {
            InitializeComponent();
        }
        // fill inventorydata grid view
        public void  FillDataGrid()
        {

            inventoryModels = inventoryManager.getInventoryGrid();
            Inventorygridview.DataSource = inventoryModels;
            Inventorygridview.ClearSelection();
            Inventorygridview.Tag = selectedInventoryModel;
            Inventorygridview.Columns[7].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {
            FillDataGrid();
        }
        //inventorydata grid view cell click
        private void Inventorygridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (Inventorygridview.CurrentRow != null)
                selectedInventoryModel = (InventoryModel)Inventorygridview.CurrentRow.DataBoundItem;
        }

        private void inventoryViewButton_Click(object sender, EventArgs e)
        {
         

            if (Inventorygridview.SelectedRows.Count > 0)
            {
               // MessageBox.Show(" Row First");
                InventoryViewForm inventoryViewForm = new InventoryViewForm(selectedInventoryModel);
                inventoryViewForm.ShowDialog();
                FillDataGrid();
                Inventorygridview.Update();
                Inventorygridview.ClearSelection();
            }
            else
            {
                MessageBox.Show("Please Select a Row First");
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

            var test = new Dashboard();
            test.Closed += (s, args) => this.Close();
            test.Show();
            this.Hide();
        }

        private void inventoryAddButton_Click(object sender, EventArgs e)
        {

            var test = new InventoryAddForm();
            test.Closed += (s, args) => this.Close();
            test.Show();
            this.Hide();
        }

        private void returnGoodsButton_Click(object sender, EventArgs e)
        {
            if (Inventorygridview.SelectedRows.Count > 0)
            {
                // MessageBox.Show(" Row First");
                ReturnGoodsForm returnGoods = new ReturnGoodsForm(selectedInventoryModel);
                returnGoods.ShowDialog();
                FillDataGrid();
                Inventorygridview.Update();
                Inventorygridview.ClearSelection();
            }
            else
            {
                MessageBox.Show("Please Select a Row First");
            }
        }
    }
}
