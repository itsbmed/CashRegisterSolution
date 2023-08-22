using CashRegisterApp.Views;
using CashRegisterLibrary.Bussiness_Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CashRegisterLibrary.Models;

namespace CashRegisterApp.Controllers
{
    public class NewPurchaseController
    {
        private PurchaseManager _purchaseManager;
        private ItemManager _itemManager;

        private List<PurchaseItem> _shoppingList = new List<PurchaseItem>();
        private double _discount = 0.0;

        public NewPurchaseController(PurchaseManager purchaseManager, ItemManager itemManager)
        {
            _purchaseManager = purchaseManager;
            _itemManager = itemManager;
        }

        // Adds an item to the shopping list with the specified quantity and discount.
        public void AddItemToShoppingList(string itemCode, int quantity, double discount)
        {
            Item item = _itemManager.GetItemByCode(itemCode);

            if (item != null)
            {
                // Calculate the discounted price per unit
                double discountedPrice = item.Price * (1 - discount / 100);

                // Check if the item is already in the shopping list
                PurchaseItem existingItem = _shoppingList.Find(pi => pi._Item.Id == item.Id);
                if (existingItem != null)
                {
                    existingItem._Quantity += quantity;
                }
                else
                {
                    _shoppingList.Add(new PurchaseItem(item, quantity, discount, discountedPrice));
                }
            }
            else
            {
                ShowErrorMessage("Item not found. Please enter a valid item code.");
            }
        }

        // Displays an error message using a message box.
        public void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Saves the shopping list to a file with the specified file path.
        public void SaveShoppingListToFile(string filePath)
        {
            StringBuilder receiptBuilder = new StringBuilder();

            // Build the receipt header
            receiptBuilder.AppendLine("====================================");
            receiptBuilder.AppendLine("          Shopping List");
            receiptBuilder.AppendLine("====================================");

            // Iterate through each purchase item and add details to the receipt
            foreach (PurchaseItem purchaseItem in _shoppingList)
            {
                // Calculate item and total prices
                double pricePerUnit = purchaseItem._Item.Price;
                double discountedPricePerUnit = pricePerUnit * (1 - purchaseItem._Discount / 100);
                double totalItemPrice = discountedPricePerUnit * purchaseItem._Quantity;

                string itemLine = $"{purchaseItem._Item.Name} ({purchaseItem._Quantity} x {pricePerUnit:C})";
                string totalLine = $"{totalItemPrice:C}";

                receiptBuilder.AppendLine(itemLine.PadRight(30) + totalLine.PadLeft(20));
            }

            // Calculate and add subtotal, discount, and total to the receipt
            receiptBuilder.AppendLine("------------------------------------");
            receiptBuilder.AppendLine($"Subtotal:               {CalculateSubtotal():C}");
            receiptBuilder.AppendLine($"Discount:               {GetDiscount():C}");
            receiptBuilder.AppendLine("====================================");
            receiptBuilder.AppendLine($"Total:                  {CalculateFinalPrice():C}");
            receiptBuilder.AppendLine("====================================");

            // Write the receipt content to the specified file path
            File.WriteAllText(filePath, receiptBuilder.ToString());
        }

        // Clears the shopping list and discount.
        public void ClearShoppingList()
        {
            _shoppingList.Clear();
            _discount = 0.0;
        }

        // Retrieves the shopping list with item details.
        public List<ShoppingListItem> GetShoppingList()
        {
            List<ShoppingListItem> shoppingList = new List<ShoppingListItem>();
            foreach (PurchaseItem purchaseItem in _shoppingList)
            {
                double totalPrice = purchaseItem._Item.Price * purchaseItem._Quantity;
                shoppingList.Add(new ShoppingListItem(purchaseItem._Item.Name, purchaseItem._Quantity, purchaseItem._Item.Price, totalPrice, purchaseItem._Discount));
            }
            return shoppingList;
        }

        // Calculates the subtotal of the items in the shopping list.
        public double CalculateSubtotal()
        {
            double subtotal = 0.0;
            foreach (PurchaseItem purchaseItem in _shoppingList)
            {
                double pricePerUnit = purchaseItem._Item.Price;
                double totalItemPrice = pricePerUnit * purchaseItem._Quantity;
                subtotal += totalItemPrice;
            }
            return subtotal;
        }

        // Calculates the total discount applied to the shopping list.
        public double GetDiscount()
        {
            double totalDiscount = 0.0;
            foreach (PurchaseItem purchaseItem in _shoppingList)
            {
                double pricePerUnit = purchaseItem._Item.Price;
                double totalItemPrice = pricePerUnit * purchaseItem._Quantity;
                double discountedTotalPrice = totalItemPrice * (1 - purchaseItem._Discount / 100);
                totalDiscount += (totalItemPrice - discountedTotalPrice);
            }
            return totalDiscount;
        }

        // Calculates the final total price after applying discounts.
        public double CalculateFinalPrice()
        {
            double finalTotal = 0.0;
            foreach (PurchaseItem purchaseItem in _shoppingList)
            {
                double pricePerUnit = purchaseItem._Item.Price;
                double totalItemPrice = pricePerUnit * purchaseItem._Quantity;
                double discountedTotalPrice = totalItemPrice * (1 - purchaseItem._Discount / 100);
                finalTotal += discountedTotalPrice;
            }
            return finalTotal;
        }
    }
}