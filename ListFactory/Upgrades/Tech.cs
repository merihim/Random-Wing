using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListFactory.Upgrades
{
    class Tech
    {
        public Dictionary<string, int> TechUpgrades = new Dictionary<string, int>()
        {
            { "Hyperwave Comm Scanner" , 1 }, { "Primed Thrusters" , 1 }, { "Pattern Analyzer" , 2 }, 
            { "Sensor Cluster" , 2}, { "Weapons Guidance" , 2 }, { "Comm Relay" , 3 }, { "Targeting Synchronizer", 3 }
        };
    }
}
