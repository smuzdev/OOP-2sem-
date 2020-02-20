using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    // Singleton
    class Planet
    {
        public PlanetName PlanetName { get; set; }
        public void GiveName(string planetName)
        {
            PlanetName = PlanetName.getInstance(planetName);
        }
    }
    class PlanetName
    {
        private static PlanetName instance;

        public string Name { get; private set; }

        protected PlanetName(string name)
        {
            this.Name = name;
        }

        public static PlanetName getInstance(string name)
        {
            if (instance == null)
                instance = new PlanetName(name);
            return instance;
        }
    }
}
