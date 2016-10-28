using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListFactory.Ships
{
    class JM5KAbstract : Baseship
    {
        public string ShipName = "Jump Master 5000";

        public string ElitePilotTalent { get; set; }

        public string Torpedo1 { get; set; }

        public string Torpedo2 { get; set; }

        public string SalvagedAstromech { get; set; }

        public string Title { get; set; }

        public string Crew { get; set; }

        public string Illicit { get; set; }

        public JM5KAbstract() : base()
        {}

    }
}
