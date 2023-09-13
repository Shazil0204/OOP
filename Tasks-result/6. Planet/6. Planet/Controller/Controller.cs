using _6.Planet.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Planet.Controller
{
    internal class Controller
    {
        Model.Lists lists = new Model.Lists();

        View.View view = new View.View();

        #region Main Controller

        /// <summary>
        /// This method is the main Controller
        /// </summary>
        public void MainController()
        {
            view.StartingView();
            InsertData();
            Output();
            view.QuestionBreak();
            InsertVenus();
            Output();
            view.QuestionBreak();
            view.RemovingPlutoGUI();
            RemovingPluto();
            Output();
            view.QuestionBreak();
            view.AddingPlutoAgainGUI();
            AddingPluto();
            Output();
            view.QuestionBreak();
            CountingPlanets();
            view.QuestionBreak();
            view.NewListStartingGUI();
            NewTemperatureList();
            view.QuestionBreak();
            view.NewListDiameterGUI();
            NewDiameterList();
            view.QuestionBreak();
            view.RemovingListGUI();
            RemoveLists();
            Console.ReadKey();
        }

        #endregion


        #region Inserting Data in List
        /// <summary>
        /// This method will insert basic data
        /// </summary>
        void InsertData()
        {
            Model.Planet mercury = new Model.Planet
            {
                Name = "Mercury",
                Mass = 0.330f,
                Diameter = 4879,
                Density = 5427,
                Gravity = 3.7f,
                RotationPeriod = 1407.6f,
                LengthOfDay = 4222.6f,
                DistanceFromSon = 57.9f,
                OrbitalPeriod = 88.0f,
                OrbitalVelocity = 47.4f,
                MeanTemperature = 167,
                NumberOfMoons = 0,
                RingSystem = false

            };

            Model.Planet earth = new Model.Planet
            {
                Name = "Earth",
                Mass = 5.97f,
                Diameter = 12756,
                Density = 5514,
                Gravity = 9.8f,
                RotationPeriod = 23.9f,
                LengthOfDay = 24,
                DistanceFromSon = 149.6f,
                OrbitalPeriod = 365.2f,
                OrbitalVelocity = 29.8f,
                MeanTemperature = 15,
                NumberOfMoons = 1,
                RingSystem = false
            };

            Model.Planet mars = new Model.Planet
            {
                Name = "Mars",
                Mass = 0.642f,
                Diameter = 6792,
                Density = 3933,
                Gravity = 3.7f,
                RotationPeriod = 24.6f,
                LengthOfDay = 24.7f,
                DistanceFromSon = 227.9f,
                OrbitalPeriod = 687,
                OrbitalVelocity = 24.1f,
                MeanTemperature = -65,
                NumberOfMoons = 2,
                RingSystem = false
            };

            Model.Planet jupiter = new Model.Planet
            {
                Name = "Jupiter",
                Mass = 1898,
                Diameter = 142984,
                Density = 1326,
                Gravity = 23.1f,
                RotationPeriod = 9.9f,
                LengthOfDay = 9.9f,
                DistanceFromSon = 778.6f,
                OrbitalPeriod = 4331,
                OrbitalVelocity = 13.1f,
                MeanTemperature = -110,
                NumberOfMoons = 67,
                RingSystem = true
            };

            Model.Planet saturn = new Model.Planet
            {
                Name = "Saturn",
                Mass = 568,
                Diameter = 120536,
                Density = 687,
                Gravity = 9.0f,
                RotationPeriod = 10.7f,
                LengthOfDay = 10.7f,
                DistanceFromSon = 1433.5f,
                OrbitalPeriod = 10747,
                OrbitalVelocity = 9.7f,
                MeanTemperature = -140,
                NumberOfMoons = 62,
                RingSystem = true
            };

            Model.Planet uranus = new Model.Planet
            {
                Name = "Uranus",
                Mass = 86.8f,
                Diameter = 51118,
                Density = 1271,
                Gravity = 8.7f,
                RotationPeriod = -17.2f,
                LengthOfDay = 17.2f,
                DistanceFromSon = 2872.5f,
                OrbitalPeriod = 30589,
                OrbitalVelocity = 6.8f,
                MeanTemperature = -195,
                NumberOfMoons = 27,
                RingSystem = true
            };

            Model.Planet neptune = new Model.Planet
            {
                Name = "Neptune",
                Mass = 102,
                Diameter = 49528,
                Density = 1638,
                Gravity = 11.0f,
                RotationPeriod = 16.1f,
                LengthOfDay = 16.1f,
                DistanceFromSon = 4495.1f,
                OrbitalPeriod = 59.8f,
                OrbitalVelocity = 5.4f,
                MeanTemperature = -200,
                NumberOfMoons = 14,
                RingSystem = true
            };

            Model.Planet pluto = new Model.Planet
            {
                Name = "Pluto",
                Mass = 0.0146f,
                Diameter = 2370,
                Density = 2095,
                Gravity = 0.7f,
                RotationPeriod = -153.3f,
                LengthOfDay = 153.3f,
                DistanceFromSon = 5906.4f,
                OrbitalPeriod = 90.56f,
                OrbitalVelocity = 4.7f,
                MeanTemperature = -225,
                NumberOfMoons = 5,
                RingSystem = false
            };

            lists.planets.Add(mercury);
            lists.planets.Add(earth);
            lists.planets.Add(mars);
            lists.planets.Add(jupiter);
            lists.planets.Add(saturn);
            lists.planets.Add(uranus);
            lists.planets.Add(neptune);
            lists.planets.Add(pluto);

            
        }
        #endregion

        /// <summary>
        /// This method will show output
        /// </summary>
        void Output()
        {
            foreach (var list in lists.planets)
            {
                //Console.WriteLine(
                //$"Name:{list.Name} \n" +
                //$"Mass:{list.Mass} \n" +
                //$"Diameter: {list.Diameter} \n" +
                //$"Density: {list.Density} \n" +
                //$"Gravity: {list.Gravity} \n" +
                //$"Rotation Period: {list.RotationPeriod} \n" +
                //$"Length Of Day: {list.LengthOfDay} \n" +
                //$"Distance from sun: {list.DistanceFromSon} \n" +
                //$"Orbitan Period: {list.OrbitalPeriod} \n" +
                //$"Orbitan Velocity: {list.OrbitalVelocity} \n" +
                //$"Mean Temperature: {list.MeanTemperature} \n" +
                //$"Number of Moons: {list.NumberOfMoons} \n" +
                //$"Does have a ring system: {list.RingSystem} \n");

                view.outputGUI(
                    list.Name,
                    list.Mass,
                    list.Diameter,
                    list.Density,
                    list.Gravity,
                    list.RotationPeriod,
                    list.LengthOfDay,
                    list.DistanceFromSon,
                    list.OrbitalPeriod,
                    list.OrbitalVelocity,
                    list.MeanTemperature,
                    list.NumberOfMoons,
                    list.RingSystem
                    );
            }
        }

        /// <summary>
        /// This method will add venus
        /// </summary>
        void InsertVenus()
        {
            Model.Planet venus = new Model.Planet
            {
                Name = "Venus",
                Mass = 4.87f,
                Diameter = 12104f,
                Density = 5243,
                Gravity = 8.9f,
                RotationPeriod = -5832.5f,
                LengthOfDay = 2802.0f,
                DistanceFromSon = 108.2f,
                OrbitalPeriod = 224.7f,
                OrbitalVelocity = 35.0f,
                MeanTemperature = 464,
                NumberOfMoons = 0,
                RingSystem = false

            };

            lists.planets.Insert(1, venus);

        }

        /// <summary>
        /// This will remove pluto
        /// </summary>
        void RemovingPluto()
        {
            for (int i = 0; i < lists.planets.Count; i++)
            {
                if (lists.planets[i].Name == "Pluto")
                {
                    lists.planets.RemoveAt(i);
                    i--; // Decrement the index to account for the removed item
                }
            }
        }

        /// <summary>
        /// adding pluto once again
        /// </summary>
        void AddingPluto()
        {
            Model.Planet pluto = new Model.Planet
            {
                Name = "Pluto",
                Mass = 0.0146f,
                Diameter = 2370,
                Density = 2095,
                Gravity = 0.7f,
                RotationPeriod = -153.3f,
                LengthOfDay = 153.3f,
                DistanceFromSon = 5906.4f,
                OrbitalPeriod = 90.56f,
                OrbitalVelocity = 4.7f,
                MeanTemperature = -225,
                NumberOfMoons = 5,
                RingSystem = false
            };

            lists.planets.Add(pluto);
        }

        /// <summary>
        /// counting total number of lists inside the list
        /// </summary>
        void CountingPlanets()
        {
            byte count = 0;
            count = Convert.ToByte(lists.planets.Count);

            view.CountPlantes(count);

        }

        /// <summary>
        /// This method will insert planets where temperature is under 0
        /// </summary>
        void NewTemperatureList()
        {
            foreach (Model.Planet planet in lists.planets)
            {
                if (planet.MeanTemperature < 0)
                {
                    lists.planetsMeanTemperature.Add(planet);
                }
            }

            foreach (Model.Planet planet in lists.planetsMeanTemperature)
            {
                view.NewList(planet.Name);
            }
        }

        /// <summary>
        /// This method will insert planets where diameter is more then 10000 and less then 50000 km
        /// </summary>
        void NewDiameterList()
        {
            foreach (Model.Planet planet in lists.planets)
            {
                if (planet.Diameter > 10000 && planet.Diameter < 50000)
                {
                    lists.planetsDiameter.Add(planet);
                }
            }

            foreach (Model.Planet planet in lists.planetsDiameter)
            {
                view.DiameterList(planet.Name);
            }
        }

        /// <summary>
        /// This will remove all the data from all the lists i have
        /// </summary>
        void RemoveLists()
        {
            lists.planets.Clear();

            lists.planetsMeanTemperature.Clear();

            lists.planetsDiameter.Clear();
        }
    }
}
