using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using Manager;
using Model;


namespace Ekhteear.UI
{
    public partial class ProductForm : Form
    {
 
        private  ProductModel SelectedProduct = new ProductModel();
        private ProductManager aProductManager = new ProductManager();
        private ProductsAddForm addForm = new ProductsAddForm();
        private List<ProductModel> productslList;
       // private  ProductModel aModel  = new ProductModel();

        public ProductForm()
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




        private void ProductForm_Load(object sender, EventArgs e)
        {
            LoadProduct();

        }
        //load all products data on grid view
        private void LoadProduct()
        {
            productslList = aProductManager.GetProductList();
            productsgridview.DataSource = productslList;
            productsgridview.ClearSelection();
            productsgridview.Tag = SelectedProduct;
            //image zoom 
            ((DataGridViewImageColumn)productsgridview.Columns[10]).ImageLayout = DataGridViewImageCellLayout.Zoom;
            productsgridview.MultiSelect = false;
            //remove quantity
           // productsgridview.Columns[5].Visible = false;
        }
        // click product  grid  view
        private void productsgridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
            if (productsgridview.CurrentRow != null)
                SelectedProduct = (ProductModel) productsgridview.CurrentRow.DataBoundItem;
        }
        // product delete 
        private void productdelete_Click(object sender, EventArgs e)
        {
            int isDone = aProductManager.DeleteProduct(SelectedProduct);
            if (isDone>0)
            {
                MessageBox.Show("Product Is Deleted");
                LoadProduct();
            }
            else
            {
                MessageBox.Show("Please Select a Row First");
            }
        }

        // search by product name 
        private void SearchProduct_TextChanged(object sender, EventArgs e)
        {
            List<ProductModel> filtered = new List<ProductModel>(productslList.Where(
                p => p.ProductName.Contains(SearchProduct.Text)).ToList());
            productsgridview.DataSource = filtered;
            productsgridview.Refresh();
        }
        
        //sreach by product type
        private void SearchByType_TextChanged(object sender, EventArgs e)
        {

            List<ProductModel> filtered = new List<ProductModel>(productslList.Where(
                p => p.ProductType.Contains(SearchType.Text)).ToList());
            productsgridview.DataSource = filtered;
            productsgridview.Refresh();

        }
        // click add button
        private void productadd_Click(object sender, EventArgs e)
        {
      
            addForm.ShowDialog();
            LoadProduct();
            productsgridview.Update();
            productsgridview.ClearSelection();
        }
        // click  refresh button
        private void ProductRefreshButton_Click(object sender, EventArgs e)
        {
            LoadProduct();
        }
        // product update button click 
        private void productupdate_Click(object sender, EventArgs e)
        {
            ProductUpdateForm updateForm = new ProductUpdateForm(SelectedProduct);

            if (productsgridview.SelectedRows.Count>0)
            {
                updateForm.ShowDialog();
                LoadProduct();
                productsgridview.Update();
                productsgridview.ClearSelection();
            }
            else
            {
                MessageBox.Show("Please Select a Row First");
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
