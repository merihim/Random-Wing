using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListFactory.Upgrades
{
    class Crew
    {
        public Dictionary<string, int> ScumCrew = new Dictionary<string, int>()
        {
            { "4-Lom" , 1 }, { "Boba Fett" , 1 }, { "Greedo" , 1 }, 
            { "IG88D" , 1}, { "Ketsu Onyo" , 1 }, { "Unkar Plutt" , 1 }, { "Zuckuss" , 1 },
            { "Bossk" , 1 }, { "'Gonk'" , 1 }, { "Latts Razzi" , 2 }, { "Outlaw Tech" , 2 }, 
            { "Dengar" , 3 }, { "K4 Security Droid" , 3 }, 
        };

        public Dictionary<string, int> GenCrew = new Dictionary<string, int>()
        {
            { "Bombadier" , 1 }, { "Intelligence Agent" , 1 }, { "Mercenary Copilot" , 2 }, { "Saboteur" , 2 }, 
            { "Tactician" , 2 }, { "Tail Gunner" , 2 }, { "Navigator" , 3 }, { "Operations Specialist" , 3 },
            { "Recon Specialist" , 3 }, { "Weapons Engineer" , 3 }, { "Flight Instructor" , 4 }, { "Hot Shot Co-Pilot" , 4 }, 
            { "Gunner" , 5 }
        };

        public Dictionary<string, int> RebelCrew = new Dictionary<string, int>()
        {
            { "Black Market Slicer Tools" , 1 }, { "Intertial Dampeners" , 1 }, { "Cloaking Device" , 2 }, 
            { "Dead Man's Switch" , 2}, { "EMP Device" , 2 }, { "Feedback Array" , 2 }, { "Glitterstim" , 2 },
            { "'Hot Shot' Blaster" , 3 }
        };

        public Dictionary<string, int> ImperialCrew = new Dictionary<string, int>()
        {
            { "Black Market Slicer Tools" , 1 }, { "Intertial Dampeners" , 1 }, { "Cloaking Device" , 2 }, 
            { "Dead Man's Switch" , 2}, { "EMP Device" , 2 }, { "Feedback Array" , 2 }, { "Glitterstim" , 2 },
            { "'Hot Shot' Blaster" , 3 }
        };
    }
}
