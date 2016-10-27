using ListFactory.JM5K;
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

        public string Name { get; set; }
        
        public Baseship()
        {
        }
    }

    public class UpgradeLooper
    {
        public List<Tuple<Type, string, string>> ListOfProp<T>()
        {
            var list = new List<Tuple<Type, string, string>>();

            T foo = Activator.CreateInstance<T>();
            foreach (var prop in foo.GetType().GetProperties())
            {
                if (prop.Attributes.ToString() != "None")
                {
                    list.Add(new Tuple<Type, string, string>(typeof(T), prop.Name, ""));
                }
                else
                {
                    list.Add(new Tuple<Type, string, string>(typeof(T), prop.Name, ""));
                }
            }

            return list;
        }
    }
    
    public class DictionaryStorage 
    {
        public Dictionary<Type, int> ScumShips = new Dictionary<Type, int>()
        {
            // Firespray
             { typeof(BobaFett) , 39 }, { typeof(KathScarlett) , 38 }, { typeof(EmomAzzameen) , 36 }, { typeof(MandalorianMercenary) , 36 }, 
             // Aggressor
             { typeof(IG88A) , 36 }, { typeof(IG88B) , 36 }, { typeof(IG88C) , 36 }, { typeof(IG88D) , 36 },
             // G-1A
             {typeof(RuthlessFreelancer), 23}, {typeof(GandFindsman), 23}, {typeof(FOURLOM), 23}, {typeof(Zuckuss), 23},
             // Hawk-290             
             {typeof(SpiceRunner), 16}, {typeof(TorkilMux), 19}, {typeof(PalobGodalhi), 20}, {typeof(DaceBonearm), 23},
             // JM5k             
             {typeof(ContractedScout), 25}, {typeof(Manaroo), 27}, {typeof(TelTrevura), 30}, {typeof(Dengar), 33},
             //Kihraxz Fighter             
             {typeof(CartelMarauder), 20}, {typeof(BlackSunAce), 23}, {typeof(GrazTheHunter), 25}, {typeof(TalonbaneCobra), 28},
             // Lancer-Class Pursuit Craft
             {typeof(ShadowportHunter), 33}, {typeof(SabineWren), 35}, {typeof(AsajjVentress), 37}, {typeof(KetsuOnyo), 38},
             // M3-A Interceptor
             {typeof(CartelSpicer), 14}, {typeof(TansariiPointVeteran), 17}, {typeof(LaetinAshera), 18}, {typeof(Serissu), 20},
             // Protectorate Starfighter
             {typeof(ZealousRecruit), 20}, {typeof(ConcordDawnVeteran), 22}, {typeof(ConcordDawnAce), 23}, {typeof(KadSolus), 25}, {typeof(OldTeroch), 26}, {typeof(FennRau), 28},
             // Quadjumper
             {typeof(UnkarPlutt), 17},
             // Starviper
             {typeof(BlackSunEnforcer), 25}, {typeof(BlackSunVigo), 27}, {typeof(Guri), 30}, {typeof(PrinceXizor), 31},
             // Y Wing
             {typeof(SyndicateThug), 18}, {typeof(HiredGun), 20}, {typeof(DreaRenthal), 22}, {typeof(Kavil), 24},
             // YV-666
             {typeof(TrandoshanSlaver), 29}, {typeof(LattsRazzi), 33}, {typeof(MoraloEval), 34}, {typeof(Bossk), 35},
             // Z-95
             {typeof(BinayrePirate), 12}, {typeof(BlackSunEnforcerZ), 13}, {typeof(KaatoLeeachos), 15}, {typeof(NdruSuhlak), 17}
        };
    }
}
