using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListFactory.Upgrades
{
    class Bombs
    {
        public Dictionary<string, int> BombUpgrades = new Dictionary<string, int>()
        {
            { "Ion Bombs" , 2 }, { "Seismic Charges" , 2 }, { "Proximity Mines" , 3 }, 
            { "Proximity Mines" , 3}, { "Thermal Detonators" , 3 }, { "Cluster Mines" , 4 },
            { "Conner Net", 4 }, { "Proton Bombs", 5 }
        };
    }
}
