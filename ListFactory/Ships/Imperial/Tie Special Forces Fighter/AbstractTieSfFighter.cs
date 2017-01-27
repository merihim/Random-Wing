using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListFactory.Ships.Imperial.Tie_Special_Forces_Fighter
{
    class AbstractTieSfFighter : Baseship
    {
        public string Systems { get; set; }

        public string Missile { get; set; }

        public string Title { get; set; }

        public string Tech { get; set; }
    }
}
