using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListFactory.Ships
{
    class FiresprayAbstract : Baseship
    {
        public string Missile { get; set; }

        public string Cannon { get; set; }

        public string Bomb { get; set; }

        public string Title { get; set; }
        
        public FiresprayAbstract() : base()
        {

        }
    }
}
