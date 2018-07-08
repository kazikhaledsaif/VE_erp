using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ekhteear.UI
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            var test = new UI.ProductForm();
            test.Closed += (s, args) => this.Close();
            test.Show();
            this.Hide();

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            var test = new UI.AgentForm();
            test.Closed += (s, args) => this.Close();
            test.Show();
            this.Hide();

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

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            var test = new CustomerForm();
            test.Closed += (s, args) => this.Close();
            test.Show();
            this.Hide();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            var test = new AboutForm();
            test.Closed += (s, args) => this.Close();
            test.Show();
            this.Hide();
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            var test = new StoreForm();
            test.Closed += (s, args) => this.Close();
            test.Show();
            this.Hide();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            var test = new InventoryForm();
            test.Closed += (s, args) => this.Close();
            test.Show();
            this.Hide();
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            var test = new ExtraCostForm();
            test.Closed += (s, args) => this.Close();
            test.Show();
            this.Hide();
        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {

            var test = new DebtorForm();
            test.Closed += (s, args) => this.Close();
            test.Show();
            this.Hide();

        }
        private void bunifuFlatButton9_Click(object sender, EventArgs e)
        {

            var test = new CreditorForm();
            test.Closed += (s, args) => this.Close();
            test.Show();
            this.Hide();

        }
    }
}
