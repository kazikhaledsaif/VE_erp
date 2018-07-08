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
    public partial class LoginForm : Form

    {
            LoginModel loginModel = new LoginModel();
         LoginManager loginManager = new LoginManager();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
                loginModel.Username = userNameTextBox.Text;
                loginModel.Password = passwordTextBox.Text;

                bool isDone = loginManager.GetLogInfo(loginModel);

                if (isDone)
                {
                    var test = new Dashboard();
                    test.Closed += (s, args) => this.Close();
                    test.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Please Enter Correct Username And Password");

                    Reset();

                }
           
          
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

        private void Reset()
        {
            userNameTextBox.ResetText();
            passwordTextBox.ResetText();
            userNameTextBox.Focus();
        }
    }
}
