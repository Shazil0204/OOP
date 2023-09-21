using Breeding_station.Model.Class;
using Breeding_station.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breeding_station.Controller
{
    internal class Controller
    {
        InsertData insertData = new InsertData();
        MainView view = new MainView();

        public void MainController()
        {
            insertData.AllInsert();
            ShowGUI();
        }

        void ShowGUI()
        {
            int i = 0;
            foreach (Animal animal in insertData.listMethod.list.animals)
            {
                i++;
                view.Count(i);
                view.GUI(animal.ToString());
                view.Count(i);
                view.SoundGUI(animal.MakeSound());
            }

            foreach (Animal animal in insertData.listMethod.list.animalsAvailable)
            {
                i++;
                view.Count(i);
                view.GUI(animal.ToString());
            }
        }
    }
}
