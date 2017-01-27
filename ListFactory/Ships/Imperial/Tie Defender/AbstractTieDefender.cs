using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListFactory.Ships.Imperial.Tie_Defender
{
    class AbstractTieDefender : Baseship
    {
        public string Title { get; set; }

        public string Cannon { get; set; }

        public string Missile { get; set; }
    }
}
