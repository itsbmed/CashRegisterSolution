using CashRegisterLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegisterLibrary.Business_Logic
{
    public class CashierManager
    {
        private List<Cashier> cashiers;
        private string cashiersFilePath = "cashiers.txt";

        public CashierManager()
        {
            cashiers = new List<Cashier>();
            LoadCashiers();
        }

        // Authenticates a cashier using their username and password.
        public bool Authenticate(string username, string password)
        {
            Cashier cashier = cashiers.Find(c => c.Username == username && c.Password == password);
            return cashier != null;
        }

        // Registers a new cashier with the provided information.
        public bool Register(string firstName, string lastName, string username, string password)
        {
            if (CashierExists(username))
            {
                return false; // Cashier with the same username already exists
            }

            Cashier newCashier = new Cashier
            {
                FirstName = firstName,
                LastName = lastName,
                Username = username,
                Password = password
            };

            cashiers.Add(newCashier);
            SaveCashiers();
            return true; // Cashier registered successfully
        }

        // Checks if there are any cashiers registered.
        public bool HasCashiers()
        {
            return cashiers.Any(); // Returns true if there are any cashiers
        }

        // Checks if a cashier with the given username exists.
        public bool CashierExists(string username)
        {
            return cashiers.Exists(c => c.Username == username);
        }

        // Loads cashiers' information from a file.
        private void LoadCashiers()
        {
            if (File.Exists(cashiersFilePath))
            {
                string[] lines = File.ReadAllLines(cashiersFilePath);
                foreach (string line in lines)
                {
                    string[] values = line.Split('|');
                    if (values.Length == 4)
                    {
                        Cashier cashier = new Cashier
                        {
                            FirstName = values[0],
                            LastName = values[1],
                            Username = values[2],
                            Password = values[3]
                        };
                        cashiers.Add(cashier);
                    }
                }
            }
        }

        // Retrieves the full name of a cashier using their username.
        public string GetCashierFullNameByUsername(string username)
        {
            Cashier cashier = cashiers.FirstOrDefault(c => c.Username == username);
            if (cashier != null)
            {
                return $"{cashier.FirstName} {cashier.LastName}";
            }
            return "Unknown Cashier";
        }

        // Saves cashiers' information to a file.
        private void SaveCashiers()
        {
            using (StreamWriter writer = new StreamWriter(cashiersFilePath))
            {
                foreach (Cashier cashier in cashiers)
                {
                    writer.WriteLine($"{cashier.FirstName}|{cashier.LastName}|{cashier.Username}|{cashier.Password}");
                }
            }
        }
    }
}