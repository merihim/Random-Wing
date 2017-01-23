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
             { "Boba Fett" , 39 }, { "Kath Scarlett" , 38 }, { "Emom Azzameen" , 36 }, { "Mandalorian Mercenary" , 33 }, 
             // Aggressor
             { "IG88A" , 36 }, { "IG88B" , 36 }, { "IG88C" , 36 }, { "IG88D" , 36 },
             // G-1A
             { "Ruthless Freelancer", 23}, { "GandFindsman", 23}, { "4-Lom", 23}, { "Zuckuss", 28},
             // Hawk-290             
             { "Spice Runner", 16}, { "Torkil Mux", 19}, { "Palob Godalhi", 20}, { "Dace Bonearm", 23},
             // JM5k             
             { "Contracted Scout", 25}, { "Manaroo", 27}, { "Tel Trevura", 30}, { "Dengar", 33},
             //Kihraxz Fighter             
             { "Cartel Marauder", 20}, { "Black Sun Ace", 23}, { "Graz the Hunter", 25}, { "Talonbane Cobra", 28},
             // Lancer-Class Pursuit Craft
             { "Shadowport Hunter", 33},  { "Sabine Wren", 35}, { "Asajj Ventress", 37}, { "Ketsu Onyo", 38},
             // M3-A Interceptor
             { "Cartel Spicer", 14}, { "Tansarii Point Veteran", 17}, { "Laetin Ashera", 18}, { "Serissu", 20},
             // Protectorate Starfighter
             { "Zealous Recruit", 20}, { "Concord Dawn Veteran", 22}, { "Concord Dawn Ace", 23}, { "Kad Solus", 25}, { "Old Teroch", 26}, { "Fenn Rau", 28},
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

        public Dictionary<string, int> ImperialShips = new Dictionary<string, int>()
        {
            // Firespray
             { "Boba Fett" , 39 }, { "Kath Scarlett" , 38 }, { "Krassis Trelix" , 36 }, { "Bounty Hunter" , 33 }, 
             // Lamba Shuttle
             { "Captain Kagi" , 27 }, { "Colonel Jendon" , 26 }, { "Captain Yorr" , 24 }, { "Omicron Group Pilot" , 21 },
             // Tie Advanced
             { "Darth Vader", 29}, { "Juno Eclipse", 28}, { "Maarek Stele", 27}, { "Zertik Strom", 26}, { "Commander Alozen", 25}, { "Storm Squadron Pilot", 23}, { "Lieutenant Colzet", 23}, { "Tempest Squadron Pilot", 21}, 
             // Tie Advanced Prototype
             { "The Inquisitor", 25}, { "Valen Rudor", 22}, { "Baron of the Empire", 19}, { "Sienar Test Pilot", 16}, 
             // Tie Bomber           
             { "Tomax Bren", 24}, { "Major Rhymer", 26}, { "Captain Jonus", 22}, { "Gamma Squadron Veteran", 19}, { "Gamma Squadron Pilot", 18}, { "Deathfire", 17}, { "Scimitar Squardon Pilot", 16},
             // Tie Defender 
             { "Rexler Brath", 37}, { "Maarek Stele", 35}, { "Colonel Vessery", 35}, { "Glaive Squadron Pilot", 34}, { "Countess Ryad", 34}, { "Onyx Squadron Pilot", 32}, { "Delta Squadron Pilot", 30},
             // OG Tie Fightere             
             { "Howlrunnner", 18}, { "Scourge", 17}, { "Mauler Mithel", 17}, { "Backstabber", 16}, { "Dark Curse", 16}, { "Youngster", 15}, { "Winged Gundark", 15}, { "NIght Beast", 15}, { "Wampa", 14}, { "Black Squadron Pilot", 14}, { "Chaser", 14}, { "Obsidian Squadron Pilot", 13}, { "Academy Pilot", 12}, 
             // Tie Interceptor
             { "Soontir Fel", 27},  { "Carnor Jax", 26}, { "Turr Phennir", 25}, { "Tetran Cowall", 24}, { "Kir Kanos", 24}, { "Royal Guard Pilot", 22}, { "Lieutenant Lorrir", 23}, { "Fel's Wrath", 23}, { "Saber Squadron Pilot", 21}, { "Avenger Squadron Pilot", 20}, { "Alpha Squadron Pilot", 18}, 
             // Tie Phantom
             { "Whisper", 32}, { "Echo", 30}, { "Shadow Squadron Pilot", 27}, { "Sigma Squadron Pilot", 25},
             // Tie Punisher
             { "Redline", 27}, { "Deathrain", 26}, { "Black Eight Squadron Pilot", 23}, { "Cutlas Squadron Pilot", 21}, 
             // Tie striker
             { "Duchess", 23},
             // Tie/Fo Fighter
             { "Omega Leader", 21}, { "Zeta Leader", 20}, { "Omega Ace", 20}, { "Epsilon Leader", 19}, { "Zeta Ace", 18}, { "Epsilon Ace", 17}, { "Omega Squadron Pilot", 17}, { "Zeta Squadron Pilot", 16}, { "Epsilon Squadron Pilot", 15}, 
             // Tie/Sf Figher
             { "Quickdraw", 29}, { "Backdraft", 27}, { "Omega Specialist", 25}, { "Zeta Specialist", 23},
             // Upsilon-Class Shuttle
             { "Kylo Ren", 34}, { "Major Stridan", 32}, { "Lieutenant Dormitz", 31}, { "Starkiller Base Pilot", 30},
             // VT-40 Decimator
             { "Rear Admiral Chiraneau", 46}, { "Commander Kenkirk", 44}, { "Captain Oicunn", 42}, { "Patrol Leader", 3}
        };
    }
}
