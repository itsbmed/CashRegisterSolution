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
using CashRegisterLibrary.Models;
using static System.Net.Mime.MediaTypeNames;

namespace CashRegisterApp.Views
{
    public partial class newPurchase : Form
    {
        private NewPurchaseController _newPurchaseController;

        public newPurchase(NewPurchaseController newPurchaseController)
        {
            InitializeComponent();

            _newPurchaseController = newPurchaseController;


        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }




        private void newPurchase_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            // Open the new purchase form here
            Settings settingsForm = new Settings();
            settingsForm.Show();
        }

        private void addItemBtn_Click(object sender, EventArgs e)
        {
            string itemCode = SearchBox.Text.Trim();
            int quantity = int.TryParse(quantityTxt.Text, out int parsedQuantity) ? parsedQuantity : 1;
            double discount = double.TryParse(discountTxt.Text, out double parsedDiscount) ? parsedDiscount : 0.0;

            _newPurchaseController.AddItemToShoppingList(itemCode, quantity, discount);
            SearchBox.Text = "";
            quantityTxt.Text = "";
            discountTxt.Text = "";
            UpdateUI();
        }





        private void button3_Click(object sender, EventArgs e)
        {
            _newPurchaseController.SaveShoppingListToFile("Receipt.txt");
            MessageBox.Show("Shopping list saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void UpdateUI()
        {
            // Update subtotal label
            double subtotal = _newPurchaseController.CalculateSubtotal();
            subTotalTxt.Text = $"€{subtotal:C}";

            // Update discount label
            double discount = _newPurchaseController.GetDiscount();
            discountshowTxt.Text = $"{discount:C}";

            // Update final price label
            double finalPrice = _newPurchaseController.CalculateFinalPrice();
            finalpriceTxt.Text = $"€{finalPrice:C}";

            // Populate DataGridView with shopping list items
            PurchasedItemsDataGridView.Rows.Clear();
            List<ShoppingListItem> shoppingList = _newPurchaseController.GetShoppingList();
            foreach (ShoppingListItem item in shoppingList)
            {

                double totalPrice = item.PricePerUnit * item.Quantity;

                PurchasedItemsDataGridView.Rows.Add(item.ProductName, item.Quantity, item.Discount, item.PricePerUnit, totalPrice);
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            _newPurchaseController.ClearShoppingList();
            UpdateUI();
        }

        private void GobackBtn_Click(object sender, EventArgs e)
        {
            DashboardController dashboardController = new DashboardController();
            this.Hide();
            // Open the new purchase form here
            Home newHomeFrom = new Home(dashboardController);
            newHomeFrom.Show();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            DashboardController dashboardController = new DashboardController();
            this.Hide();
            // Open the new purchase form here
            Home newHomeFrom = new Home(dashboardController);
            newHomeFrom.Show();
        }
    }
}