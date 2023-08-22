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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void newCashierBtn_Click(object sender, EventArgs e)
        {
            CashierRegistrationController controller = new CashierRegistrationController();
            this.Hide();
            // Open the new purchase form here
            NewCashier newPurchaseForm = new NewCashier(controller);
            newPurchaseForm.Show();
        }

        private void newProductBtn_Click(object sender, EventArgs e)
        {
            ItemManager manager = new ItemManager(); ;
            AddItemController controller = new AddItemController(manager);
            this.Hide();
            // Open the new purchase form here
            NewItem newPurchaseForm = new NewItem(controller);
            newPurchaseForm.Show();
        }

        private void purchase_Click(object sender, EventArgs e)
        {
            this.Hide();
            // Open the new purchase form here
            ItemManager itemManager = new ItemManager();
            PurchaseManager purchaseManager = new PurchaseManager();
            NewPurchaseController purchaseController = new NewPurchaseController(purchaseManager, itemManager);
            newPurchase addPurchaseForm = new newPurchase(purchaseController);
            addPurchaseForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DashboardController dashboardController = new DashboardController();
            this.Hide();
            Home homeForm = new Home(dashboardController);
            homeForm.Visible = true;

        }
    }
}
