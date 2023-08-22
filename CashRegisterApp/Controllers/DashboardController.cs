using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CashRegisterApp.Views;
using CashRegisterLibrary;
using CashRegisterLibrary.Business_Logic;

namespace CashRegisterApp.Controllers
{
    public class DashboardController
    {
        private loginForm _loginForm;
        private Home _dashboardForm;
        private newPurchase _addPurchaseForm;
        public event EventHandler SignOutRequested;

        // Sets the reference to the login form.
        public void SetLoginForm(loginForm loginForm)
        {
            _loginForm = loginForm;
        }

        // Sets the reference to the dashboard form.
        public void SetDashboardForm(Home dashboardForm)
        {
            _dashboardForm = dashboardForm;
        }

        // Sets the reference to the add purchase form.
        public void SetAddPurchaseForm(newPurchase addPurchaseForm)
        {
            _addPurchaseForm = addPurchaseForm;
        }

        // Displays the dashboard form after successful login.
        public void ShowDashboardForm(string username)
        {
            CashierManager cashierManager = new CashierManager();
            _dashboardForm.Username = username;
            string cashierFullName = cashierManager.GetCashierFullNameByUsername(username);
            LoggedInUser.Username = username;
            LoggedInUser.CashierFullName = cashierFullName;
            _loginForm.Visible = false; // Hide the login form
            _dashboardForm.Visible = true; // Show the dashboard form
            _dashboardForm.FunctionToExecuteOnLoad();
        }

        // Requests sign out by triggering the SignOutRequested event.
        public void RequestSignOut()
        {
            SignOutRequested?.Invoke(this, EventArgs.Empty);
        }

      
    }
}