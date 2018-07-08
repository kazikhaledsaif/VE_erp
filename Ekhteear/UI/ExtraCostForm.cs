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
    public partial class ExtraCostForm : Form
    {

        ExtraCostManager extraCostManager  = new ExtraCostManager();
        ExtraCostModel selectedExtraCostModel = new ExtraCostModel();
        ExtraCostModel extraCostModel = new ExtraCostModel();
        private List<ExtraCostModel> extraCostModels ;
        public ExtraCostForm()
        {
            InitializeComponent();
        }

        private void ExtraCostForm_Load(object sender, EventArgs e)
        {

            GetExtraCostId();
            ExtraCostGrid();
        }


        // minmize
        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //close button
        private void crossButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //maximize  button
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
        //back button
        private void back_Click(object sender, EventArgs e)
        {
            var test = new Dashboard();
            test.Closed += (s, args) => this.Close();
            test.Show();
            this.Hide();
        }


        //get extracost id 

        public void GetExtraCostId()
        {
            string id = extraCostManager.GetExtraCostId();
            costId.Text = id;

        }
        // load ex cost grid 

        public void ExtraCostGrid()
        {

            extraCostModels = extraCostManager.GetExtraCostModels();
            ExtraCostGridView.DataSource = extraCostModels;
            ExtraCostGridView.ClearSelection();
            ExtraCostGridView.Tag = selectedExtraCostModel;
            ExtraCostGridView.MultiSelect = false;
            ExtraCostGridView.ClearSelection();
            ExtraCostGridView.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            decimal num;
            if (amountTextbox.Text.Length > 0 && costDescTextbox.Text.Length > 0)
            {
                if (decimal.TryParse(amountTextbox.Text,  out num))
                {
                    try
                    {
                        extraCostModel.CostType = costDescTextbox.Text;
                        extraCostModel.Amount = Convert.ToDecimal(amountTextbox.Text);
                        extraCostModel.CostDate =  DateTime.Today;
                        int isDone = extraCostManager.ExtraCostInsert(extraCostModel);
                        if (isDone > 0)
                        {
                            MessageBox.Show("Inserted Sucessfully");
                            Reset();
                            ExtraCostGrid();

                        }
                        else
                        {
                            MessageBox.Show("Insert Unsucessful");
                            Reset();
                        }



                    }
                    catch (Exception en)
                    {
                        MessageBox.Show("Try Again");
                        Reset();
                    }
                }
                else
                {
                    MessageBox.Show("Number Only");
                    amountTextbox.ResetText();
                }


            }
            else
            {
                MessageBox.Show("Fill All Data");
            }
            
        }

        private void ExtraCostGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ExtraCostGridView.CurrentRow != null)
            {
                selectedExtraCostModel = (ExtraCostModel)ExtraCostGridView.CurrentRow.DataBoundItem;
                costId.Text = selectedExtraCostModel.ExtraCostId.ToString();
                costDescTextbox.Text = selectedExtraCostModel.CostType;
                amountTextbox.Text = selectedExtraCostModel.Amount.ToString();
            }
        }

        private void CreditorSearch_TextChanged(object sender, EventArgs e)
        {
            List<ExtraCostModel> filtered = new List<ExtraCostModel>(extraCostModels.Where(
                p => p.CostType.Contains(Search.Text)).ToList());
            ExtraCostGridView.DataSource = filtered;
            ExtraCostGridView.Refresh();
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime oDate = Convert.ToDateTime(dateTimePicker.Text);
            List<ExtraCostModel> filtered = new List<ExtraCostModel>(extraCostModels.Where(
                p => p.CostDate== oDate).ToList());
            ExtraCostGridView.DataSource = filtered;
            ExtraCostGridView.Refresh();
        }


        public void Reset()
        {
            GetExtraCostId();
            amountTextbox.ResetText();
            costDescTextbox.ResetText();
            
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {

            decimal num;
            if (amountTextbox.Text.Length > 0 && costDescTextbox.Text.Length > 0)
            {
                if (decimal.TryParse(amountTextbox.Text, out num))
                {
                    try
                    {
                        extraCostModel.ExtraCostId = Convert.ToInt32(costId.Text);
                        extraCostModel.CostType = costDescTextbox.Text;
                        extraCostModel.Amount = Convert.ToDecimal(amountTextbox.Text);
                       // extraCostModel.CostDate = DateTime.Today;
                        int isDone = extraCostManager.ExtraCostUpdate(extraCostModel);
                        if (isDone > 0)
                        {
                            MessageBox.Show("Update Sucessfully");
                            Reset();
                            ExtraCostGrid();

                        }
                        else
                        {
                            MessageBox.Show("Update Unsucessful");
                            Reset();
                        }



                    }
                    catch (Exception en)
                    {
                        MessageBox.Show("Try Again");
                        Reset();
                    }
                }
                else
                {
                     MessageBox.Show("Number Only");
                    amountTextbox.ResetText();
                }


            }
            else
            {
                MessageBox.Show("Fill All Data");
            }

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int isDone = extraCostManager.DeleteExtraCost(selectedExtraCostModel);
            if (isDone > 0)
            {
                MessageBox.Show("Expense Is Deleted");
                ExtraCostGrid();
            }
            else
            {
                MessageBox.Show("Please Select a Row First");
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
