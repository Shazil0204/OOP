using System;
using System.Collections.Generic;
using Breeding_station.Model.Class;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Breeding_station.Model.List
{
    internal class ListMethod
    {
        internal Lists list = new Lists();
        public void InsertAll()
        {
            InsertDog();
            InsertChicken();
            InsertRabbit();
            InsertAvailable();
        }
        private void InsertDog()
        {
            Random random = new Random();
            bool available = true;
            for (int i = 0; i < 10; i++)
            {
                int age = random.Next(0, 20);
                if (age > 10)
                {
                    available = false;
                }
                else
                {
                    available = true;
                }
                Dog dog = new Dog("Dog", "Male", "No", 4, "Fluffy", age, available, "vuf vuf");
                list.animals.Add(dog);
                if(dog.IsAvailable() == true)
                {
                    list.animalsAvailable.Add(dog);
                }
                Debug.WriteLine("Added A Dog");
            }
        }
        private void InsertChicken()
        {
            Random random = new Random();
            bool available = true;
            for (int i = 0; i < 10; i++)
            {
                int age = random.Next(0, 20);
                if (age > 10)
                {
                    available = false;
                }
                else
                {
                    available = true;
                }
                Chicken chicken = new Chicken("Chicken", "Female", "No", 2, "Fluffy", age, available, "ku ka ru ka duu");
                list.animals.Add(chicken);
                if(chicken.IsAvailable() == true)
                {
                    list.animalsAvailable.Add(dog);
                }
                Debug.WriteLine("Added A Chicken");
            }
        }
        private void InsertRabbit()
        {
            Random random = new Random();
            bool available = true;
            for (int i = 0; i < 10; i++)
            {
                int age = random.Next(0, 20);
                if (age > 10)
                {
                    available = false;
                }
                else
                {
                    available = true;
                }
                Rabbit rabbit = new Rabbit("Rabbit", "Male", "No", 4, "Fluffy", age, available, "I don't know!");
                list.animals.Add(rabbit);
                if(rabbit.IsAvailable() == true)
                {
                    list.animalsAvailable.Add(dog);
                }
                Debug.WriteLine("Added A Rabbit");
            }
        }
        private void InsertAvailable()
        {
            for(int i = 0; i < list.animals.Count; i++)
            {
                if (1 == 1)
                {

                }
            }
        }
    }
}
