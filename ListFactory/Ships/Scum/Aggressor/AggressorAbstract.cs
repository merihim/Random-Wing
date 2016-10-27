using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListFactory.Ships
{
    class AggressorAbstract : Baseship
    {
        public string ElitePilotTalent { get; set; }

        public string Cannon1 { get; set; }
        
        public string Cannon2 { get; set; }
        
        public string Systems { get; set; }
        
        public string Bomb { get; set; }
        
        public string Missile { get; set; }
        
        public string Title { get; set; }
    }
}
