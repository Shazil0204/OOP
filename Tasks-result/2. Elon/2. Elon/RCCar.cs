using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Elon
{
    #region Model
    internal class RCCar
    {
        #region Fields
        private int _batteryCapacity = 100; // Initialized to 100%
        private int _distanceDriven = 0;    // Initialized to 0 meters
        private string _color;
        #endregion

        #region Properties
        public int BatteryCapacity
        {
            get { return _batteryCapacity; }
            private set { _batteryCapacity = Math.Max(0, value); } // Ensure battery doesn't go below 0%
        }

        public int DistanceDriven
        {
            get { return _distanceDriven; }
            private set { _distanceDriven = value; }
        }

        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }
        #endregion

        #region Methods
        public void Drive()
        {
            if (_batteryCapacity > 0)
            {
                _distanceDriven += 20;
                _batteryCapacity -= 1;
                UpdateDisplay();
            }
            else
            {
                Console.WriteLine("Battery is empty. Car cannot drive!");
            }
        }

        public void Charge()
        {
            _batteryCapacity = 100;
            _distanceDriven = 0;
            UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            Console.WriteLine($"Car Color: {Color}");
            Console.WriteLine($"Distance Driven: {_distanceDriven} meters");
            Console.WriteLine($"Battery Life: {_batteryCapacity}%");
            Console.WriteLine("=================================");
        }
        #endregion
    }
    #endregion
}