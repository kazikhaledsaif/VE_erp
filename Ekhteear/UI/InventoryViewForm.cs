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
    public partial class InventoryViewForm : Form
    {
        private InventoryModel inventoryModel;
        List<InventoryDetailModel> inventoryDetailModels = new List<InventoryDetailModel>();
        public InventoryViewForm(InventoryModel selectedInventoryModel)
        {
            InitializeComponent();
            inventoryModel = selectedInventoryModel;
        }

        private void InventoryViewForm_Load(object sender, EventArgs e)
        {
            FillInventory();
        }

        public void FillInventory()
        {
            InventoryManager  imanage = new InventoryManager();
            inventoryDetailModels = imanage.GetInventoryDetailViewLists(inventoryModel);
            InventoryViewgridview.DataSource = inventoryDetailModels;
            InventoryViewgridview.ClearSelection();
           
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
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

    }
}
