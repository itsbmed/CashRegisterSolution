using CashRegisterLibrary.Bussiness_Logic;
using CashRegisterLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegisterApp.Controllers
{
    public class AddItemController
    {
        private ItemManager _itemManager;

        // Constructor to initialize the controller with an ItemManager instance.
        public AddItemController(ItemManager itemManager)
        {
            _itemManager = itemManager;
        }

        // Adds an item to the inventory.
        public void AddItem(string name, double price, string description)
        {
            // Generate a unique code for the item based on its name
            string generatedCode = _itemManager.GenerateItemCode(name);

            // Add the item to the inventory
            _itemManager.AddItem(name, description, price, generatedCode);
        }
    }
}