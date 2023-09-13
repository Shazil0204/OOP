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

        #region Main Controller

        void MainController()
        {

        }

        #endregion


        #region Inserting Data in List
        public void InsertData()
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

            foreach (var list in lists.planets)
            {
                Console.WriteLine(
                    $"Name:{list.Name} \n" +
                    $"Mass:{list.Mass} \n" +
                    $"Diameter: {list.Diameter} \n" +
                    $"Density: {list.Density} \n" +
                    $"Gravity: {list.Gravity} \n" +
                    $"Rotation Period: {list.RotationPeriod} \n" +
                    $"Length Of Day: {list.LengthOfDay} \n" +
                    $"Distance from sun: {list.DistanceFromSon} \n" +
                    $"Orbitan Period: {list.OrbitalPeriod} \n" +
                    $"Orbitan Velocity: {list.OrbitalVelocity} \n" +
                    $"Mean Temperature: {list.MeanTemperature} \n" +
                    $"Number of Moons: {list.NumberOfMoons} \n" +
                    $"Does have a ring system: {list.RingSystem} \n");
            }
        }
        #endregion
    }
}
