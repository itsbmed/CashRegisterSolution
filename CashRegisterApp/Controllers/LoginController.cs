using CashRegisterLibrary.Business_Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegisterApp.Controllers
{
    public class LoginController
    {
        private CashierManager _cashierManager;
        private string _loggedInUsername;

        // Constructor that initializes the CashierManager.
        public LoginController()
        {
            _cashierManager = new CashierManager();
        }

        // Authenticates the user with the provided username and password.
        public bool Authenticate(string username, string password)
        {
            return _cashierManager.Authenticate(username, password);
        }

        // Checks if there are any registered cashiers.
        public bool HasCashiers()
        {
            return _cashierManager.HasCashiers();
        }
    }
}