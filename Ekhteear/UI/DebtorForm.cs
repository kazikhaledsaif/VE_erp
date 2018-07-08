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
    public partial class DebtorForm : Form
    {

        DebtorManager  debtorManager = new DebtorManager();
        List<DebtorModel> debtorModels = new List<DebtorModel>();
        DebtorModel selectedDebtorModel = new DebtorModel();



        public DebtorForm()
        {
            InitializeComponent();
        }

        private void DebtorForm_Load(object sender, EventArgs e)
        {
            DebtorGridLoad();

        }
        //Debtor datagrid view load
        private void  DebtorGridLoad()
        {
            debtorModels = debtorManager.GetDebtorGridList();
            debtorGridView.DataSource = debtorModels;
            debtorGridView.ClearSelection();
            debtorGridView.Tag = selectedDebtorModel;
            debtorGridView.MultiSelect = false;
            debtorGridView.ClearSelection();
            debtorGridView.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
        }
        //debtor data grid view cell  click 
        private void debtorGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (debtorGridView.CurrentRow != null)
            {

                selectedDebtorModel = (DebtorModel) debtorGridView.CurrentRow.DataBoundItem;
                debtorId.Text = selectedDebtorModel.DebtorId.ToString();
                debtorDue.Text = selectedDebtorModel.DebtorDue.ToString();
            }
        }

        // debtor search code

        private void DebotrSearch_TextChanged(object sender, EventArgs e)
        {
            List<DebtorModel> filtered = new List<DebtorModel>(debtorModels.Where(
                p => p.CustomerName.Contains(Search.Text)).ToList());
            debtorGridView.DataSource = filtered;
            debtorGridView.Refresh();
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
        // save button click 
        private void SaveButton_Click(object sender, EventArgs e)
        {


            if (debtorCashPaid.Text != "")
            {
                decimal num;
                if (decimal.TryParse(debtorCashPaid.Text.Trim(), out num))
                {

                    if (Convert.ToDecimal(debtorDue.Text) > Convert.ToDecimal(debtorCashPaid.Text))
                    {
                        selectedDebtorModel.DebtorDate= DateTime.Today;
                        selectedDebtorModel.DebtorDue = Convert.ToDecimal(debtorCashPaid.Text);
                        int isDone = debtorManager.UpdateDebtor(selectedDebtorModel);
                        if (isDone > 0)
                        {
                            MessageBox.Show("Update Sucessfully");
                        }
                        else
                        {
                            MessageBox.Show("Update Unsucessful");
                        }
                    }


                    else if (Convert.ToDecimal(debtorDue.Text) == Convert.ToDecimal(debtorCashPaid.Text))
                    {
                        int isDone = debtorManager.DeleteDebtor(selectedDebtorModel);
                        if (isDone > 0)
                        {
                            MessageBox.Show("Creditor has been Removed");
                        }
                        else
                        {
                            MessageBox.Show("Remove Unsucessful");
                        }
                    }
                    else
                    {
                        MessageBox.Show("You Cant Paid More Then Due");
                        debtorCashPaid.Clear();

                    }
                    DebtorGridLoad();
                    debtorDue.Text = "";
                    debtorCashPaid.Clear();
                    debtorId.Text = "";
                }
                else
                {
                    debtorCashPaid.ResetText();
                }

            }
            else
            {
                MessageBox.Show("Fill the Paid Amount");

            }
        }
     




    }
}
