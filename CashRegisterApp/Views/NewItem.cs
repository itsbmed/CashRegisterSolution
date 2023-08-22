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
using CashRegisterLibrary.Bussiness_Logic;

namespace CashRegisterApp.Views
{
    public partial class NewItem : Form
    {
        private AddItemController _controller;

        public NewItem(AddItemController controller)
        {
            InitializeComponent();

            _controller = controller;
        }

        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            string itemName = ProductName.Text;
            string description = ProductDescription.Text;

            if (double.TryParse(ProductPrice.Text, out double price))
            {
                if (string.IsNullOrWhiteSpace(itemName))
                {
                    MessageBox.Show("Please enter an item name.");
                    return;
                }

                if (price <= 0)
                {
                    MessageBox.Show("Please enter a valid price.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(description))
                {
                    MessageBox.Show("Please enter a description.");
                    return;
                }

                _controller.AddItem(itemName, price, description);
                MessageBox.Show("Item added successfully.");
                ClearFields();
            }
            else
            {
                MessageBox.Show("Invalid price. Please enter a valid number.");
            }
        }

        private void ClearFields()
        {
            ProductName.Text = "";
            ProductPrice.Text = "";
            ProductDescription.Text = "";
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            DashboardController dashboardController = new DashboardController();
            Home homeForm = new Home(dashboardController);
            homeForm.Show();
        }

        private void GobackBtn_Click(object sender, EventArgs e)
        {

            this.Hide();

            Settings settingsForm = new Settings();
            settingsForm.Show();
        }

        private void newPurchaseBtn_Click(object sender, EventArgs e)
        {

            this.Hide();
            // Open the new purchase form here
            ItemManager itemManager = new ItemManager();
            PurchaseManager purchaseManager = new PurchaseManager();
            NewPurchaseController purchaseController = new NewPurchaseController(purchaseManager, itemManager);
            newPurchase addPurchaseForm = new newPurchase(purchaseController);
            addPurchaseForm.Show();
        }
    }

}
