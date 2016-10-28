using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListFactory.Upgrades
{
    class Torpedo
    {
        public Dictionary<string, int> TorpedoUpgrades = new Dictionary<string, int>()
        {
            { "Extra Munitions" , 2 }, { "Flechette Torpedoes" , 2 }, { "SeismicTorpedo" , 2 }, 
            { "Plasma Torpedoes" , 3}, { "Proton Torpedoes" , 4 }, { "Ion Torpedoes" , 5 },
            { "Advanced Proton Torpedoes" , 6 }
        };
    }
}
