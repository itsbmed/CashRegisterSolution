using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegisterLibrary.Models
{
    public class ShoppingListItem
    {
        // Properties representing the attributes of a shopping list item
        public string ProductName { get; }      // Name of the product
        public int Quantity { get; }            // Quantity of the product
        public double PricePerUnit { get; }     // Price per unit of the product
        public double TotalPrice { get; }       // Total price of the product (quantity * price per unit)
        public double Discount { get; }         // Discount applied to the product

        public ShoppingListItem(string productName, int quantity, double pricePerUnit, double totalPrice, double discount)
        {
            ProductName = productName;
            Quantity = quantity;
            PricePerUnit = pricePerUnit;
            TotalPrice = totalPrice;
            Discount = discount;
        }
    }
}