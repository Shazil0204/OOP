using System;
using System.Collections.Generic;
using System.Linq;
using Queue.Model;
using System.Text;
using System.Threading.Tasks;

namespace Queue.Controller
{
    internal class Controller
    {
        View.Views view = new View.Views();
        Queue<Model.VendingMachine> vendingQueue = new Queue<Model.VendingMachine>();

        #region Main Controller

        /// <summary>
        /// this is the main controller
        /// </summary>
        public void MainController()
        {
            while (true)
            {
              
                Controllers();

            }
        }
        #endregion

        #region Controller
        /// <summary>
        /// This controller will collect all the methods together
        /// </summary>
        void Controllers()
        {
            Options();
            view.Readkey();
        }
        #endregion

        #region Option

        void Options()
        {
            view.SelectOptions();

            byte mainOption = Convert.ToByte(Console.ReadLine());

            switch (mainOption)
            {

                case 1:
                    view.AddItemGUI();
                    string n = AddName();
                    view.AddBrandGUI();
                    string b = AddBrand();
                    AddItems(n, b);
                    break;
                case 2:
                    view.DeleteItemGUI();
                    Delete();
                    break;
                case 3:
                    TotalNumber();
                    break;
                case 4:
                    //view.MinAndMaxItemGUI();
                    MinAndMax();
                    break;
                case 5:
                    FindItem();
                    break;
                case 6:
                    view.PrintAllItemsGUI();
                    PrintAllItem();
                    break;
                case 7:
                    Environment.Exit(0);
                    break;

                default: break;

            }
        }

        #endregion

        #region Insert Data

        string AddName()
        {
            string name = view.ReadOut();

            return name;
        }

        string AddBrand()
        {
            string brand = view.ReadOut();

            return brand;
        }

        void AddItems(string name, string brand)
        {
            vendingQueue.Enqueue(new VendingMachine() { Drink = name, Brand = brand});
            
        }
        #endregion

        #region delete

        void Delete()
        {
            if (vendingQueue.Count != 0)
            {
                vendingQueue.Dequeue();
                view.DeleteSuccess();
            }
            else
            {
                view.DeleteNotExsist();
            }
        }

        #endregion

        #region show number of item

        void TotalNumber()
        {
            int total = Convert.ToInt32(vendingQueue.Count);

            view.ShowNumberOfItemGUI(total);
        }

        #endregion

        #region MIN and MAX

        void MinAndMax()
        {
            string  firstName = "";
            string  firstBrand = "";
            string  LastName = "";
            string  LastBrand = "";
            bool onlyOnce = true;

            foreach(var items in vendingQueue)
            {
                if(onlyOnce)
                {
                    firstName = items.Drink;
                    firstBrand = items.Brand;

                    onlyOnce = false;
                }
                else
                {
                    LastName = items.Drink;
                    LastBrand = items.Brand;
                }
            } 

            if(vendingQueue.Count == 0)
            {
                Console.WriteLine("There is nothing inside your queue");  
            }
            else if(vendingQueue.Count == 1)
            {
                Console.WriteLine($"First name: {firstName} and Brand: {firstBrand}");
            }
            else
            {
                Console.WriteLine($"First name: {firstName} and Brand: {firstBrand}");
                Console.WriteLine($"Last name: {LastName} and Brand: {LastBrand}");
            }
        }

        #endregion

        #region Find Item

        void FindItem()
        {
            bool ifFound = false;

            string find = view.FindItemGUI();

            foreach ( var item in vendingQueue)
            {
                if (item.Drink == find)
                {
                    view.ShowFoundItem(item.Drink, item.Brand);
                    ifFound = true;
                }
            }

            if (!ifFound)
            {
                view.NoItem(find);
            }
        }

        #endregion


        #region Print all items

        void PrintAllItem()
        {
            foreach (var drink in vendingQueue)
            {
                view.Drinks(drink.Drink, drink.Brand);
            }
        }

        #endregion
    }
}
