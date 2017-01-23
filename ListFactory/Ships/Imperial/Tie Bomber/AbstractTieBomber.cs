using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListFactory.Ships.Imperial.Tie_Bomber
{
    class AbstractTieBomber : Baseship
    {
        public string Torpedo1 { get; set; }

        public string Torpedo2 { get; set; }

        public string Missile1 { get; set; }

        public string Missile2 { get; set; }

        public string Bomb1 { get; set; }

        public string Bomb2 { get; set; }
    }
}
