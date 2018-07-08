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
    public partial class UpdateAgentForm : Form
    {
        private AgentModel updateAgentModel;
       
        private AgentManager agentManager = new AgentManager();
        

        public UpdateAgentForm(AgentModel agentModel)
        {
            InitializeComponent();
            //change reference
            updateAgentModel = agentModel;
            FillData();
        }
        //fill agent data to  form 
        public void FillData()
        {

            addAgentId.Text = updateAgentModel.AgentId.ToString();
            addAgentName.Text = updateAgentModel.AgentName;
            addCompanyName.Text = updateAgentModel.CompanyName;
            addPhoneNumber.Text = updateAgentModel.PhoneNumber;
           
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {


            if (addCompanyName.Text != "" && addAgentName.Text != "")
            {

                try
                {
                    //creating  ProductModel class and Save All data to object
                    updateAgentModel.AgentName = addAgentName.Text;
                    updateAgentModel.CompanyName = addCompanyName.Text;
                    updateAgentModel.PhoneNumber = addPhoneNumber.Text;
                    // calling manager to update data

                    int isDone = agentManager.AgentUpdate(updateAgentModel);
                    if (isDone > 0)
                    {
                        MessageBox.Show("Update Sucessfully");
                    this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Update Unsucessful");
                     
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Try Again");
                    
                }







            }


            else
            {
                MessageBox.Show("Fill All the data ");
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
        // close form 
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
