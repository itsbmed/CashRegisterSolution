using System;
using System.Collections.Generic;
using CashRegisterApp.Controllers;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using CashRegisterLibrary;

namespace CashRegisterApp.Views
{

    public partial class loginForm : Form
    {
        private string enteredText = "";
        private LoginController _controller;
        private DashboardController _dashboardController;

        public loginForm(LoginController controller, DashboardController dashboardController)
        {
            InitializeComponent();
            _controller = controller;
            _dashboardController = dashboardController;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = enteredText;
           

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill in both fields.");
                return;
            }
            
            if (_controller.Authenticate(username, password))
            {
               
                
                _dashboardController.ShowDashboardForm(username);
                ClearTextBoxes();

            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                // Handle control keys (e.g., backspace)
                if (e.KeyChar == '\b' && enteredText.Length > 0)
                {
                    enteredText = enteredText.Substring(0, enteredText.Length - 1);
                }
            }
            else
            {
                // Replace the entered character with an asterisk
                enteredText += e.KeyChar;
            }

                        // Clear the RichTextBox and display asterisks
                        ((RichTextBox)sender).Clear();
            ((RichTextBox)sender).AppendText(new string('*', enteredText.Length));

            // Prevent the entered character from being displayed
            e.Handled = true;
        }

        private void ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            // Toggle between showing and hiding password based on the CheckBox state
            txtPassword.Clear();
            if (ShowPass.Checked)
            {
                txtPassword.AppendText(enteredText);
            }
            else
            {
                txtPassword.AppendText(new string('*', enteredText.Length));
            }
        }
        private void ClearTextBoxes()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            ShowPass.Checked = false;
            enteredText = "";
        }
    }



}
