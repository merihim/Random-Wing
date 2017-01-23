using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListFactory.Upgrades
{
    class Cannon
    {
        public Dictionary<string, int> CannonUpgrades = new Dictionary<string, int>()
        {
            { "Flechette Cannon" , 2 }, { "Tractor Beam" , 1 }, { "Ion Cannon" , 3 }, 
            { "Mangler" , 4}, { "Autoblaster" , 5 }, { "Heavy Laser Canon" , 7 }
        };
    }
}
