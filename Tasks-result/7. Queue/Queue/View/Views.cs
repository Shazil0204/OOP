using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Queue.View
{
    internal class Views
    {
        #region Options
        /// <summary>
        /// Shows the select options
        /// </summary>
        public void SelectOptions()
        {
            Console.WriteLine("You have these options" +
                "\n1. Add items" +
                "\n2. Delete items" +
                "\n3. Show the number of items" +
                "\n4. Show min and max items" +
                "\n5. Find an item" +
                "\n6. Print all items" +
                "\n7. Exit");
            Console.Write("\n> ");
        }
        #endregion
        
        public void Readkey()
        {
            Console.ReadKey();
            Console.Clear();
        }

        /// <summary>
        /// GUI for drink and brand
        /// </summary>
        /// <param name="drink"></param>
        /// <param name="brand"></param>
        public void Drinks(string drink, string brand)
        {
            Console.WriteLine($"Drink:\t{drink}\n" + 
                $"Brand:\t{brand}\n");
        }

        #region GUI
        
        /// <summary>
        /// GUI for add item
        /// Task 1
        /// </summary>
        public void AddItemGUI()
        {
            Console.Clear();
            Console.Title = "Add Items";
            Console.Write("What item do you want to add?" +
                "\nItem: ");

        }

        /// <summary>
        /// GUI for add brand
        /// Task 1
        /// </summary>
        public void AddBrandGUI()
        {
            Console.Title = "Add Brand";
            Console.Write("\nWhat brand do you want to add?" +
                "\nBrand: ");

        }

        /// <summary>
        /// GUI for delete item
        /// Task 2
        /// </summary>
        public void DeleteItemGUI()
        {
            Console.Clear();
            Console.Title = "Delete Items";
            
        }

        /// <summary>
        /// GUI for successfully deleting a item
        /// </summary>
        public void DeleteSuccess()
        {
            Console.WriteLine("Item has been removed succesfully"); 
        }

        /// <summary>
        /// GUI if Queue is empty
        /// </summary>
        public void DeleteNotExsist()
        {
            Console.WriteLine("There is nothing inside our Queue");
        }

        /// <summary>
        /// GUI for shop item
        /// Task 3
        /// </summary>
        public void ShowNumberOfItemGUI(int total)
        {
            Console.Clear();
            Console.Title = "Shows number of items";
            Console.Write($"Total of items: {total}");
        }

        /// <summary>
        /// GUI for min and max item
        /// Task 4
        /// </summary>
        public void MinAndMaxItemGUI(string fn, string fb, string ln, string lb)
        {
            Console.Clear();
            Console.Title = "Min and Max";
            Console.Write("Min: " +
                "\nMax: ");
        }

        /// <summary>
        /// GUI for find item
        /// Task 5
        /// </summary>
        public string FindItemGUI()
        {
            Console.Clear();
            Console.Title = "Find a item";
            Console.Write("What item do you want to find?" +
                "\nItem: ");
            string fItem = Console.ReadLine();

            return fItem;
        }

        public void ShowFoundItem(string FoundIt, string brand)
        {
            Console.WriteLine($"Your item name is {FoundIt} and the Brand is {brand}");
        }

        public void NoItem(string name)
        {
            Console.WriteLine($"There is no such item \"{name}\" in our queue");
        }

        /// <summary>
        /// GUI for print all item
        /// Task 6
        /// </summary>
        public void PrintAllItemsGUI()
        {
            Console.Clear();
            Console.Title = "Print all items";
            Console.Write("All items" +
                "\n");
        }

        public string ReadOut()
        {
            string n = Console.ReadLine();

            return n;
        }

        #endregion
    }
}
