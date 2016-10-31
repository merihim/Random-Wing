using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListFactory.Ships
{
    public class Baseship
    {
        public string Modification { get; set; }
                
        public Baseship()
        {
        }
    }

    public class UpgradeLooper
    {
        public List<Tuple<string, string, string>> ListOfProp<T>(string Name)
        {
            var list = new List<Tuple<string, string, string>>();
            T foo = Activator.CreateInstance<T>();
            foreach (var prop in foo.GetType().GetProperties())
            {
                if (prop.Attributes.ToString() != "None")
                {
                    list.Add(new Tuple<string, string, string>(Name, prop.Name, ""));
                }
                else
                {
                    list.Add(new Tuple<string, string, string>(Name, prop.Name, prop.Attributes.ToString()));
                }
            }

            return list;
        }
    }
    
    public class DictionaryStorage 
    {
        public Dictionary<string, int> ScumShips = new Dictionary<string, int>()
        {
            // Firespray
             { "Boba Fett" , 39 }, { "Kath Scarlett" , 38 }, { "Emom Azzameen" , 36 }, { "Mandalorian Mercenary" , 36 }, 
             // Aggressor
             { "IG88A" , 36 }, { "IG88B" , 36 }, { "IG88C" , 36 }, { "IG88D" , 36 },
             // G-1A
             { "Ruthless Freelancer", 23}, { "GandFindsman", 23}, { "4-Lom", 23}, { "Zuckuss", 28},
             // Hawk-290             
             { "Spice Runner", 16}, { "Torkil Mux", 19}, { "PalobGodalhi", 20}, { "Dace Bonearm", 23},
             // JM5k             
             { "Contracted Scout", 25}, { "Manaroo", 27}, { "Tel Trevura", 30}, { "Dengar", 33},
             //Kihraxz Fighter             
             { "Cartel Marauder", 20}, { "Black Sun Ace", 23}, { "Graz the Hunter", 25}, { "Talonbane Cobra", 28},
             // Lancer-Class Pursuit Craft
             { "Shadowport Hunter", 33},  { "Sabine Wren", 35}, { "Asajj Ventress", 37}, { "Ketsu Onyo", 38},
             // M3-A Interceptor
             { "Cartel Spicer", 14}, { "Tansarii Point Veteran", 17}, { "Laetin Ashera", 18}, { "Serissu", 20},
             // Protectorate Starfighter
             { "Zealous Recruit", 20}, { "Concord Dawn Veteran", 22}, { "Concord Dawn Ace", 23}, { "KadSolus", 25}, { "Old Teroch", 26}, { "Fenn Rau", 28},
             // Quadjumper
             { "Unkar Plutt", 17},
             // Starviper
             { "Black Sun Enforcer", 25}, { "Black Sun Vigo", 27}, { "Guri", 30}, { "Prince Xizor", 31},
             // Y Wing
             { "Syndicate Thug", 18}, { "Hired Gun", 20}, { "Drea Renthal", 22}, { "Kavil", 24},
             // YV-666
             { "Trandoshan Slaver", 29}, { "LattsRazzi", 33}, { "Moralo Eval", 34}, { "Bossk", 35},
             // Z-95
             { "Binayre Pirate", 12}, { "Black Sun Enforcer Z-95", 13}, { "Kaato Leeachos", 15}, { "N'dru Suhlak", 17}
        };
    }
}
