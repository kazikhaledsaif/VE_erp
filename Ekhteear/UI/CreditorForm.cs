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
    public partial class CreditorForm : Form
    {

        CreditorManager creditorManager = new CreditorManager();
        List<CreditorModel> creditorModels = new List<CreditorModel>();
        CreditorModel selectedCreditorModel  =  new CreditorModel();
        public CreditorForm()
        {
            InitializeComponent();
        }

        private void CreditorForm_Load(object sender, EventArgs e)
        {
            CreditorGridLoad();
        

        }
        //creditor datagrid view load
        private void CreditorGridLoad()
        {
            creditorModels = creditorManager.GetCreditorGridList();
            creditorGridView.DataSource = creditorModels;
            creditorGridView.ClearSelection();
            creditorGridView.Tag = selectedCreditorModel;
            creditorGridView.MultiSelect = false;
            creditorGridView.ClearSelection();
            creditorGridView.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        //creditor grid view cell click
        private void creditorGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (creditorGridView.CurrentRow != null)
            {

                selectedCreditorModel = (CreditorModel)creditorGridView.CurrentRow.DataBoundItem;
                creditorId.Text = selectedCreditorModel.CreditorId.ToString();
                creditorDue.Text = selectedCreditorModel.CreditorDue.ToString();
            }



        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

            if (CreditorCashPaid.Text != "")
            {
                decimal num;
                if (decimal.TryParse(CreditorCashPaid.Text.Trim(), out num))
                {

                    if (Convert.ToDecimal(creditorDue.Text) > Convert.ToDecimal(CreditorCashPaid.Text))
                    {
                        selectedCreditorModel.Date = DateTime.Today;
                        selectedCreditorModel.CreditorDue = Convert.ToDecimal(CreditorCashPaid.Text) ;
                        int isDone = creditorManager.UpdateCreditor(selectedCreditorModel);
                        if (isDone > 0)
                        {
                            MessageBox.Show("Update Sucessfully");
                        }
                        else
                        {
                            MessageBox.Show("Update Unsucessful");
                        }
                    }


                    else if (Convert.ToDecimal(creditorDue.Text) == Convert.ToDecimal(CreditorCashPaid.Text))
                    {
                        int isDone = creditorManager.DeleteCreditor(selectedCreditorModel);
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
                        CreditorCashPaid.Clear();

                    }
                    CreditorGridLoad();
                    creditorDue.Text = "";
                    CreditorCashPaid.Clear();
                    creditorId.Text = "";
                }
                else
                {
                   CreditorCashPaid.ResetText();
                }

            }
            else
            {
                MessageBox.Show("Fill the Paid Amount");

            }

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
        // creditor search code 

        private void CreditorSearch_TextChanged(object sender, EventArgs e)
        {
            List<CreditorModel> filtered = new List<CreditorModel>(creditorModels.Where(
                p => p.AgentName.Contains(CreditorSearch.Text)).ToList());
            creditorGridView.DataSource = filtered;
            creditorGridView.Refresh();
        }
    }
}
