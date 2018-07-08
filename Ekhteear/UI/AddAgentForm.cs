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
    public partial class AddAgentForm : Form
    {
        AgentManager agentManager = new AgentManager();
        AgentModel agentModel = new AgentModel();
        public AddAgentForm()
        {
            InitializeComponent();

        }
        //minimize Button
        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //Close button
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
        //back button
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //save button
        private void SaveButton_Click(object sender, EventArgs e)
        {

            if (addCompanyName.Text != "" && addAgentName.Text != "")
            {

                try
                {
                    //creating  ProductModel class and Save All data to object
                    agentModel.AgentName = addAgentName.Text;
                    agentModel.CompanyName = addCompanyName.Text;
                    agentModel.PhoneNumber = addPhoneNumber.Text;
                    // calling manager to insert data
                 
                    int isDone = agentManager.AgentInsert(agentModel);
                    if (isDone > 0)
                    {
                        MessageBox.Show("Inserted Sucessfully");
                        Reset();

                    }
                    else
                    {
                        MessageBox.Show("Insert Unsucessful");
                        Reset();
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Try Again");
                    Reset();
                }







            }


            else
            {
                MessageBox.Show("Fill All the data ");
            }

        }
        //display Agent id
        private void GetAgentId()
        {

            string agentId = agentManager.GetAgentId();
            addAgentId.Text = agentId;
        }

        private void AddAgentForm_Load(object sender, EventArgs e)
        {
            GetAgentId();
        }

        // reset all the fields
        public void Reset()
        {
            GetAgentId();
          
            addAgentName.Text = null;
            addCompanyName.Text = null;
            addPhoneNumber.Text = null;
         
        }

        
    }
}
