using CashRegisterLibrary.Models;
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
using CashRegisterLibrary.Business_Logic;
using System.Diagnostics;
using CashRegisterLibrary;

namespace CashRegisterApp.Views
{
    public partial class Home : Form
    {

        public string Username { get; set; }
        private DashboardController _controller;
        private bool _isSubscribed = false;
        string _cashierFullName;

        public Home(DashboardController controller)
        {
            InitializeComponent();
            _controller = controller;
            this.VisibleChanged += Home_VisibleChanged;

        }

        private void Home_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible && !_isSubscribed)
            {
                // Subscribe to the event only when the form becomes visible
                _controller.SignOutRequested += OnSignOutRequested;
                _isSubscribed = true;
            }
        }
        private void purchaseBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            // Open the new purchase form here
            ItemManager itemManager = new ItemManager();
            PurchaseManager purchaseManager = new PurchaseManager();
            NewPurchaseController purchaseController = new NewPurchaseController(purchaseManager, itemManager);
            newPurchase addPurchaseForm = new newPurchase(purchaseController);
            addPurchaseForm.Show();

        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            // Open the settings form here
            Settings settingsForm = new Settings();
            settingsForm.Show();
        }

        private void newPurchaseBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            // Open the new purchase form here
            ItemManager itemManager = new ItemManager();
            PurchaseManager purchaseManager = new PurchaseManager();
            NewPurchaseController purchaseController = new NewPurchaseController(purchaseManager, itemManager);
            newPurchase addPurchaseForm = new newPurchase(purchaseController);
            addPurchaseForm.Show();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {

            // Trigger the SignOutRequested event to initiate the sign-out process
            _controller.RequestSignOut();

        }

        private void Home_Load(object sender, EventArgs e)
        {

            FunctionToExecuteOnLoad();




        }
        public void FunctionToExecuteOnLoad()
        {
            CashierManager cashierManager = new CashierManager();
            string loggedInUsername = LoggedInUser.Username; // Replace with the actual username of the logged-in cashier


            string cashierFullName = cashierManager.GetCashierFullNameByUsername(loggedInUsername);
            fullnameLbl.Text = $"{cashierFullName}";
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Unsubscribe from the event when the form is closed

        }
        private void OnSignOutRequested(object sender, EventArgs e)
        {
            // Perform sign-out actions here
            // For example, show the login form and hide the home form
            LoginController loginController = new LoginController();
            loginForm _loginForm = new loginForm(loginController, _controller);

            _loginForm.Visible = true;
            this.Visible = false;
        }

    }
}
