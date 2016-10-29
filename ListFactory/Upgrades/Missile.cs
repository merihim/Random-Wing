using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListFactory.Upgrades
{
    class Missile
    {
        public Dictionary<string, int> MissileUpgrade = new Dictionary<string, int>()
        {
            { "XX-23 S-Thread Tracers" , 1 }, { "Adv. Homing Missile" , 3 }, { "Ion Pulse Missiles" , 3 }, 
            { "Proton Rockets" , 3}, { "Cluster Missiles" , 4 }, { "Concussion Missiles" , 4 },
            { "Assault Missiles" , 5 }, { "Homing Missiles" , 5 }
        };
    }
}
