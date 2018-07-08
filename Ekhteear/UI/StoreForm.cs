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
    public partial class StoreForm : Form
    {
        private List<StoreModel> storeModels;
        private InventoryManager inventoryManager  = new InventoryManager();
        public StoreForm()
        {
            InitializeComponent();
        }

        public void GetStoreData()
        {
            storeModels = inventoryManager.GetAgentModels();
            storeGridview.DataSource = storeModels;
            storeGridview.ClearSelection();
        
        }

        private void StoreForm_Load(object sender, EventArgs e)
        {
            GetStoreData();
        }

        private void SearchByProduct_TextChanged(object sender, EventArgs e)
        {
            List<StoreModel> filtered = new List<StoreModel>(storeModels.Where(
                p => p.ProductName.Contains(SearchByProduct.Text)).ToList());
            storeGridview.DataSource = filtered;
            storeGridview.Refresh();
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

        private void backButton_Click(object sender, EventArgs e)
        {

            var test = new Dashboard();
            test.Closed += (s, args) => this.Close();
            test.Show();
            this.Hide();
        }
    }
}
