using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Planet.Model
{
    internal class Planet
    {
        #region Vairables

        private int density;
        private int meanTemperature;
        private bool ringSystem;
        private sbyte numberOfMoons;
        private float mass;
        private float distanceFromSon;
        private float orbitalPeriod;
        private float orbitalVelocity;
        private float gravity;
        private float rotationPeriod;
        private float diameter;
        private float lengthOfDay;
        private string name;

        #endregion

        #region getter and setter

        /*1*/ public int      Density         { get { return density;         } set { density = value;          } }
        /*2*/ public int      MeanTemperature { get { return meanTemperature; } set { meanTemperature = value;  } }
        /*3*/ public bool     RingSystem      { get { return ringSystem;      } set { ringSystem = value;       } }
        /*4*/ public sbyte    NumberOfMoons   { get { return numberOfMoons;   } set { numberOfMoons = value;    } }
        /*5*/ public float    Mass            { get { return mass;            } set { mass = value;             } }
        /*6*/ public float    DistanceFromSon { get { return distanceFromSon; } set { distanceFromSon = value;  } }
        /*7*/ public float    OrbitalPeriod   { get { return orbitalPeriod;   } set { orbitalPeriod = value;    } }
        /*8*/ public float    OrbitalVelocity { get { return orbitalVelocity; } set { orbitalVelocity = value;  } }
        /*9*/ public float    Gravity         { get { return gravity;         } set { gravity = value;          } }
        /*10*/public float    RotationPeriod  { get { return  rotationPeriod; } set { rotationPeriod = value;   } }
        /*11*/public float    Diameter        { get { return diameter;        } set { diameter = value;         } }
        /*12*/public float    LengthOfDay     { get { return lengthOfDay;     } set { lengthOfDay = value;      } }
        /*13*/public string   Name            { get { return name;            } set { name = value;             } }
        #endregion

        
    }
}
