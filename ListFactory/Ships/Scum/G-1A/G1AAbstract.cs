using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListFactory.Ships.Scum.G_1A
{
    class G1AAbstract : Baseship
    {
        public string Crew { get; set; }

        public string Systems { get; set; }

        public string Illict { get; set; }

        public string Title { get; set; }

        public G1AAbstract() : base()
        {

        }
    }
}
