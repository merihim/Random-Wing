using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListFactory.Upgrades
{
    class Modification
    {
        public Dictionary<string, int> Modifications = new Dictionary<string, int>()
        {
            { "Guidance Chips" , 0 }, { "Long-Range Scanners" , 0 }, { "Munitions Failsafe" , 1 }, 
            { "Advanced SLAM" , 1 }, { "Autothrusters" , 2 }, { "Stgium Particle Accelerator" , 2 }, 
            { "Targeting Computer" , 2 }, { "Vectored Thrusters" , 2 }, { "Experimental Interfact" , 3 }, 
            { "Hull Upgrade" , 3 }, { "Stealth Device" , 3 }, { "Engine Upgrade" , 4 }, { "Shield Upgrade" , 4 }
        };
    }
}
