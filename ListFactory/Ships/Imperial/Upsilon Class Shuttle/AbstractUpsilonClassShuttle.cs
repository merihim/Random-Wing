using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListFactory.Ships.Imperial.Upsilon_Class_Shuttle
{
    class AbstractUpsilonClassShuttle : Baseship
    {
        public string Systems { get; set; }

        public string Crew1 { get; set; }

        public string Crew2 { get; set; }

        public string Title { get; set; }

        public string Tech1 { get; set; }

        public string Tech2 { get; set; }
    }
}
