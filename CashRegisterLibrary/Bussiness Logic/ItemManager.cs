using CashRegisterLibrary.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CashRegisterLibrary.Bussiness_Logic
{

    public class ItemManager
    {
        private List<Item> items;
        private string itemsFilePath = "items.txt";
        private int nextItemId = 1;

        public ItemManager()
        {
            items = new List<Item>();
            LoadItems();
            InitializeNextItemId();
        }

        // Initializes the next available item ID based on existing items.
        private void InitializeNextItemId()
        {
            if (items.Count > 0)
            {
                nextItemId = items.Max(item => item.Id) + 1;
            }
        }

        // Returns a list of all available items.
        public List<Item> GetItems()
        {
            return items;
        }

        // Retrieves an item by its user-friendly item code.
        public Item GetItemByCode(string itemCode)
        {
            // Normalize the input by trimming any leading or trailing spaces
            itemCode = itemCode.Trim();

            // Find the item based on the normalized item code
            Item item = items.FirstOrDefault(item => item.Code == itemCode);

            if (item == null)
            {
                // Item not found, log the issue for debugging
                Debug.WriteLine($"Item with code '{itemCode}' not found.");
            }

            return item;
        }

        // Adds a new item to the collection.
        public void AddItem(string name, string description, double price, string generatedCode)
        {
            Item newItem = new Item
            {
                Id = nextItemId,
                Code = generatedCode, // Assign the generated code
                Name = name,
                Description = description,
                Price = price
            };

            items.Add(newItem);
            nextItemId++;
            SaveItems();
        }

        // Loads items from a file into the collection.
        private void LoadItems()
        {
            if (File.Exists(itemsFilePath))
            {
                try
                {
                    string[] lines = File.ReadAllLines(itemsFilePath);
                    foreach (string line in lines)
                    {
                        string[] values = line.Split('|');
                        if (values.Length == 5)
                        {
                            if (int.TryParse(values[0].Trim(), out int itemId) &&
                                double.TryParse(values[4].Trim(), out double price))
                            {
                                string code = values[1].Trim();
                                string name = values[2].Trim();
                                string description = values[3].Trim();

                                Item item = new Item
                                {
                                    Id = itemId,
                                    Code = code,
                                    Name = name,
                                    Description = description,
                                    Price = price
                                };
                                items.Add(item);
                            }
                            else
                            {
                                Debug.WriteLine($"Error parsing line: {line}");
                            }
                        }
                        else
                        {
                            Debug.WriteLine($"Invalid line format: {line}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"Error loading items: {ex.Message}");
                }
            }
        }

        // Generates a unique item code based on the item name and current ID.
        public string GenerateItemCode(string itemName)
        {
            string itemCode = itemName.Substring(0, Math.Min(3, itemName.Length)).ToUpper(); // First 3 letters in uppercase
            itemCode += nextItemId.ToString(); // Unique identifier
                                               // You can add more components to the item code if needed
            return itemCode;
        }

        // Saves the items collection to a file.
        private void SaveItems()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(itemsFilePath))
                {
                    foreach (Item item in items)
                    {
                        writer.WriteLine($"{item.Id}|{item.Code}|{item.Name}|{item.Description}|{item.Price}");
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error saving items: {ex.Message}");
            }
        }
    }
}