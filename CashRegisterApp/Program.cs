namespace CashRegisterApp
{
    using System;
    using System.Windows.Forms;
    using CashRegisterLibrary.Bussiness_Logic;
    using CashRegisterApp.Views;
    using CashRegisterApp.Controllers;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;

    static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            CashierRegistrationController firstTimeController = new CashierRegistrationController();
            LoginController loginController = new LoginController();

            if (!loginController.HasCashiers())
            {
                Application.Run(new firstTimeForm(firstTimeController));
            }
            else
            {
                DashboardController dashboardController = new DashboardController();

                loginForm loginForm = new loginForm(loginController, dashboardController);
                Home dashboardForm = new Home(dashboardController);
               
                ItemManager itemManager = new ItemManager();
                PurchaseManager purchaseManager = new PurchaseManager();
                NewPurchaseController purchaseController = new NewPurchaseController(purchaseManager, itemManager);
                newPurchase addPurchaseForm = new newPurchase(purchaseController);

                dashboardController.SetLoginForm(loginForm);
                dashboardController.SetDashboardForm(dashboardForm);
                dashboardController.SetAddPurchaseForm(addPurchaseForm);



                Application.Run(loginForm);
            }
        }
    }
}