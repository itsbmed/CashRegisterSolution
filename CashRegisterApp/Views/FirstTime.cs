using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CashRegisterApp.Controllers;


namespace CashRegisterApp.Views
{
    public partial class firstTimeForm : Form
    {
        private CashierRegistrationController _controller;
        private string enteredText = "";
        public firstTimeForm(CashierRegistrationController controller)
        {
            InitializeComponent();
            _controller = new CashierRegistrationController();
        }



        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Toggle between showing and hiding password based on the CheckBox state
            passwordTxt.Clear();
            if (ShowPass.Checked)
            {
                passwordTxt.AppendText(enteredText);
            }
            else
            {
                passwordTxt.AppendText(new string('*', enteredText.Length));
            }
        }


        private void addCashier_Click(object sender, EventArgs e)
        {

            string firstName = firstnameTxt.Text;
            string lastName = lastnameTxt.Text;
            string username = usernameTxt.Text;
            string password = enteredText;

            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (_controller.RegisterCashier(firstName, lastName, username, password))
            {
                
                MessageBox.Show("Cashier registered successfully.");
                this.Close();
                

            }
            else
            {
                MessageBox.Show("Username already exists. Please choose a different username.");
            }
        }

        private void passwordTxt_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
