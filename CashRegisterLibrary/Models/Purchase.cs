using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegisterLibrary.Models
{
    public class Purchase
    {
        // Properties representing the attributes of a purchase
        public DateTime Date { get; }                   // Date of the purchase
        public List<PurchaseItem> Items { get; }        // List of items in the purchase
        public double TotalPrice { get; }               // Total price of the purchase

        public Purchase(DateTime date, double totalPrice)
        {
            Date = date;
            Items = new List<PurchaseItem>();
            TotalPrice = totalPrice;
        }

        // Adds an item to the list of items in the purchase.
        public void AddItem(PurchaseItem purchaseItem)
        {
            Items.Add(purchaseItem);
        }
    }

    public class PurchaseItem
    {
        // Properties representing the attributes of a purchase item
        public Item _Item { get; }              // The associated item
        public int _Quantity { get; set; }      // Quantity of the item
        public double _Discount { get; set; }   // Discount applied to the item
        public double _DiscountedPrice { get; set; } // Discounted price of the item

        public PurchaseItem(Item item, int quantity, double discount, double discountedPrice)
        {
            _Item = item;
            _Quantity = quantity;
            _Discount = discount;
            _DiscountedPrice = discountedPrice;
        }
    }
}
