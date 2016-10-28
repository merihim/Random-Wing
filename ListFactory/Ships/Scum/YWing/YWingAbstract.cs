using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListFactory.Ships
{
    class YWingAbstract : Baseship
    {
        public string Turret { get; set; }

        public string SalvagedAstromech { get; set; }

        public string Torpedo1 { get; set; }

        public string Torpedo2 { get; set; }

        public string Title { get; set; }
    }
}
