using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_superheroes
{
    class Superhero
    {
        // All Variables
        private string fear;
        private string realName;
        private string superpower;
        private string superheroName;
        private string costumeDescription;
        private string secretHideoutLocation;
        private bool wearmask;
        private bool wearcostume;
        private bool secretidentity;

        // Properties

        public string Fear
        {
            get { return fear; }
            private set { fear = value; }
        }

        public string RealName
        {
            get { return realName; }
            private set { realName = value; }
        }

        public string Superpower
        {
            get { return superpower; }
            private set { superpower = value; }
        }

        public string SuperheroName
        {
            get { return superheroName; }
            private set { superheroName = value; }
        }

        public string CostumeDescription
        {
            get { return costumeDescription; }
            private set { costumeDescription = value; }
        }

        public string SecretHideoutLocation
        {
            get { return secretHideoutLocation; }
            private set { secretHideoutLocation = value; }
        }

        public bool WearMask
        {
            get { return wearmask; }
            private set { wearmask = value; }
        }

        public bool WearCostume
        {
            get { return wearcostume; }
            private set { wearcostume = value;}
        }

        public bool SecretIdentity
        {
            get { return secretidentity; }
            private set { secretidentity = value; }
        }
    }
}
