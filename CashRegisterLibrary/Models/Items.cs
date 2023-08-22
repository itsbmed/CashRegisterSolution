using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegisterLibrary.Models
{
    public class Item
    {
        // Properties representing the attributes of an item
        public int Id { get; set; }            // Unique identifier for the item
        public string Code { get; set; }       // User-friendly item code associated with the item
        public string Name { get; set; }       // Name of the item
        public string Description { get; set; } // Description of the item
        public double Price { get; set; }      // Price of the item
    }
}