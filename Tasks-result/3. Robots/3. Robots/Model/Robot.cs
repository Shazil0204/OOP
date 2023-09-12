using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace _3.Robots.Model
{
    internal class Robot
    {
        #region Variables
        public bool _hasWifi;
        public bool _hasTires;
        public byte _battery;
        public float _soapCapacity;
        public string _size;
        public string _color;
        public string _robotType;
        public string _optionalChip;

        #endregion

        /// <summary>
        /// Define the default values, to the variables
        /// </summary>
        #region Default Constructor
        public Robot()
        {
            _size = "";
            _hasWifi = false;
            _hasTires = false;
            _optionalChip = "default";
            _color = "";
            _battery = 255;
            _soapCapacity = 2.3F;
            _robotType = "";
        }
        #endregion

        #region Common Constructor

        // Constructor for specifying size
        private Robot(string size) : this()
        {
            _size = size;
        }

        // Constructor for specifying size and type
        private Robot(string size, string type) : this(size)
        {
            _robotType=type;
        }

        // Constructor for specifying size, type, and chip
        private Robot(string size, string type, string chip) : this(size, type)
        {
            _optionalChip = chip;
        }

        // Constructor for specifying size, type, chip, and tire
        private Robot(string size, string type, string chip, bool tire) : this(size, type, chip)
        {
            _hasTires = tire;
        }

        // Constructor for specifying size, type, chip, tire, and WIFI
        private Robot(string size, string type, string chip, bool tire, bool WIFI) : this(size, type, chip, tire)
        {
            _hasWifi = WIFI;
        }

        // Constructor for specifying size, type, chip, tire, WIFI, and color
        public Robot(string size, string type, string chip, bool tire, bool WIFI, string color) : this(size, type, chip, tire, WIFI)
        {
            _color = color;
        }

        #endregion

        #region floor cleaner & tire changer

        // Constructor for floor cleaner & tire changer
        // If the color is white then the user can use this constructor; otherwise, the user won't be able to use this
        public Robot(string size, string type, string chip, bool tire, bool WIFI, string color, byte battery) : this(size, type, chip, tire, WIFI, color)
        {
            _battery = battery;
        }

        #endregion

        #region soap Robot

        // Constructor for soap Robot
        // Because window cleaner robot has a soap container fixed in it, it can't have any battery
        public Robot(string size, string type, string chip, bool tire, bool WIFI, string color, float soapCapacity) : this(size, type, chip, tire, WIFI, color)
        {
            _soapCapacity = soapCapacity;
        }

        #endregion
    }
}
