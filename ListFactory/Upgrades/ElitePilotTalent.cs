using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListFactory.Upgrades
{
    class ElitePilotTalent
    {
        public Dictionary<string, int> GenEPT = new Dictionary<string, int>()
        {
            { "'A Score To Settle" , 0 }, { "Adaptability" , 0 }, { "Trick Shot" , 0 }, 
            { "Adrenaline Rush" , 1}, { "Attani Mindlink" , 1 }, { "Calculation" , 1 }, { "Cool Hand" , 1 },
            { "Crack Shot" , 1 }, { "Deadeye" , 1 }, { "Determination" , 1 }, { "Draw Their Fire" ,12 }, 
            { "Fearlessness" , 1 }, { "Lightning Reflexes" , 1 }, { "Rage" , 1 }, { "Veteran Instincts" , 1 },
            { "Wired" , 1 }, { "Decoy" , 2 }, { "Elusiveness" , 2 }, { "Expert Handling" , 2 }, { "Intimidation" , 2 }, 
            { "Juke" , 2 }, { "Lone Wolf" , 2 }, { "Snap Shot" , 2 }, { "Squad Leader" , 2 }, { "Stay on Target" , 2 }, 
            { "Swarm Tactics" , 2 }, { "Wingman" , 2 }, { "Daredevil" , 3 }, { "Marksmanship" , 3 }, { "Outmaneuver" , 3 }, 
            { "Predator" , 3 }, { "Push The Limit" , 3 }, { "Expose" , 4 }, { "Opportunist" , 4 }
        };
        
        public Dictionary<string, int> ScumEPT = new Dictionary<string, int>()
        {
            { "BodyGuard" , 2 }
        };
    }
}
