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
    public partial class AgentForm : Form
    {
        
        AddAgentForm addAgentForm = new AddAgentForm();
        private List<AgentModel> agentModels;
        private AgentManager agentManager = new AgentManager();
       // AgentModel agentModel = new AgentModel();
        AgentModel selectedAgentModel = new AgentModel();

        public AgentForm()
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
            var test = new Dashboard();
            test.Closed += (s, args) => this.Close();
            test.Show();
            this.Hide();
        }

        private void addAgent_Click(object sender, EventArgs e)
        {
            addAgentForm.ShowDialog();
            LoadAgentList();
            agentGridView.Update();
            agentGridView.ClearSelection();
        }

        private void AgentForm_Load(object sender, EventArgs e)
        {
            LoadAgentList();
           
        }
        //load all agent data on grid view
        private void LoadAgentList()
        {
            agentModels = agentManager.GetAgentModels();
            agentGridView.DataSource = agentModels;
            agentGridView.ClearSelection();
            agentGridView.Tag = selectedAgentModel;
            agentGridView.MultiSelect = false;
         
            agentGridView.ClearSelection();

        }

        //sreach by agent name
        private void SearchByAgentName_TextChanged(object sender, EventArgs e)
        {

            List<AgentModel> filtered = new List<AgentModel>(agentModels.Where(
                p => p.AgentName.Contains(searchByName.Text)).ToList());
            agentGridView.DataSource = filtered;
            agentGridView.Refresh();

        }

        private void refresh_Click(object sender, EventArgs e)
        {
            LoadAgentList();
        }
        // agent update
        private void updateAgent_Click(object sender, EventArgs e)
        {
            UpdateAgentForm updateAgentForm = new UpdateAgentForm(selectedAgentModel);

            if (agentGridView.SelectedRows.Count > 0)
            {
                updateAgentForm.ShowDialog();
                LoadAgentList();
                agentGridView.Update();
                agentGridView.ClearSelection();
            }
            else
            {
                MessageBox.Show("Please Select a Row First");
            }
        }
        //agent grid view cell click
        private void agentGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (agentGridView.CurrentRow != null)
                selectedAgentModel = (AgentModel)agentGridView.CurrentRow.DataBoundItem;
        }
        // delete agent 
        private void deleteAgent_Click(object sender, EventArgs e)
        {

            int isDone = agentManager.DeleteAgent(selectedAgentModel);
            if (isDone > 0)
            {
                MessageBox.Show("Agent is Deleted");
                LoadAgentList();
            }
            else
            {
                MessageBox.Show("Please Select a Row First");
            }
        }
    }
}
