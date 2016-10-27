using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListFactory.Upgrades
{
    class Systems
    {
        public Dictionary<string, int> SystemsUpgrade = new Dictionary<string, int>()
        {
            { "Collision Detector" , 0 }, { "Electronic Baffle" , 1 }, { "Enhanced Scopes" , 1 }, 
            { "Fire Control System" , 2}, { "Accuracy Corrector" , 3 }, { "Advanced Sensors" , 3}, { "Sensor Jammer" , 4 }
        };
    }
}
