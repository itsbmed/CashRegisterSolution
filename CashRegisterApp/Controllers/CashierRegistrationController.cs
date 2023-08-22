using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CashRegisterLibrary.Business_Logic;
using CashRegisterLibrary.Bussiness_Logic;
using CashRegisterLibrary.Models;

namespace CashRegisterApp.Controllers
{
    public class CashierRegistrationController
    {
        private CashierManager _cashierManager;

        // Constructor to initialize the controller with a CashierManager instance.
        public CashierRegistrationController()
        {
            _cashierManager = new CashierManager();
        }

        // Registers a new cashier with the provided information.
        public bool RegisterCashier(string firstName, string lastName, string username, string password)
        {
            return _cashierManager.Register(firstName, lastName, username, password);
        }

        // Checks if there are any registered cashiers.
        public bool HasCashiers()
        {
            return _cashierManager.HasCashiers();
        }
    }
}