using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CashRegisterApp.Controllers;
using System.Windows.Forms;
using CashRegisterLibrary.Bussiness_Logic;

namespace CashRegisterApp.Views
{
    public partial class NewCashier : Form
    {
        private CashierRegistrationController _controller;
        private string enteredText = "";
        public NewCashier(CashierRegistrationController controller)
        {
            InitializeComponent();
            _controller = controller;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DashboardController dashboardController = new DashboardController();
            this.Hide();
            // Open the new purchase form here
            Home newHomeFrom = new Home(dashboardController);
            newHomeFrom.Show();

        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {

            this.Hide();
            // Open the new purchase form here
            Settings settingsForm = new Settings();
            settingsForm.Show();
        }

        private void logouBtn_Click(object sender, EventArgs e)
        {

        }

        private void AddCashierBtn_Click(object sender, EventArgs e)
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
                MessageBox.Show("Cashier added successfully.");
                ClearFields();
            }
            else
            {
                MessageBox.Show("Username already exists. Please choose a different username.");
            }
        }
        private void ClearFields()
        {
            firstnameTxt.Text = "";
            lastnameTxt.Text = "";
            usernameTxt.Text = "";
            passwordTxt.Text = "";
        }

        private void GobackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            // Open the new purchase form here
            Settings settingsForm = new Settings();
            settingsForm.Show();
        }

        private void cashierBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            // Open the new purchase form here
            ItemManager itemManager = new ItemManager();
            PurchaseManager purchaseManager = new PurchaseManager();
            NewPurchaseController purchaseController = new NewPurchaseController(purchaseManager, itemManager);
            newPurchase addPurchaseForm = new newPurchase(purchaseController);
            addPurchaseForm.Show();
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
        private void ShowPass_CheckedChanged(object sender, EventArgs e)
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


    }
}
