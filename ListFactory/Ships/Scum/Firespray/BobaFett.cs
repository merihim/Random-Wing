using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListFactory.Ships
{
    class BobaFett : FiresprayAbstract
    {
        public string ElitePilotTalent { get; set; }

        public string Torpedo { get; set; }

        public string PilotSkill = "9";

        public BobaFett() : base()
        {

        }
    }
}
