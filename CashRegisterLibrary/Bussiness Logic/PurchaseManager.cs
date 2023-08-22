using CashRegisterLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegisterLibrary.Bussiness_Logic
{
    public class PurchaseManager
    {
        private List<Purchase> _purchases;
        private string _purchasesFilePath = "purchases.txt";

        public PurchaseManager()
        {
            _purchases = new List<Purchase>();
            LoadPurchases();
        }

        // Adds a new purchase to the list and saves the list to a file.
        public void AddPurchase(Purchase purchase)
        {
            _purchases.Add(purchase);
            SavePurchases();
        }

        // Loads purchases from a file into the list.
        private void LoadPurchases()
        {
            if (File.Exists(_purchasesFilePath))
            {
                _purchases.Clear();

                string[] lines = File.ReadAllLines(_purchasesFilePath);
                foreach (string line in lines)
                {
                    string[] values = line.Split('|');
                    if (values.Length >= 3)
                    {
                        DateTime date = DateTime.Parse(values[0]);
                        double totalPrice = double.Parse(values[1]);

                        Purchase purchase = new Purchase(date, totalPrice);

                        // Parse and add purchase items if needed

                        _purchases.Add(purchase);
                    }
                }
            }
        }

        // Saves the list of purchases to a file.
        private void SavePurchases()
        {
            using (StreamWriter writer = new StreamWriter(_purchasesFilePath))
            {
                foreach (Purchase purchase in _purchases)
                {
                    writer.WriteLine($"{purchase.Date}|{purchase.TotalPrice}");

                    // Implement writing purchase items if needed
                }
            }
        }
    }
}