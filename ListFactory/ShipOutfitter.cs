using ListFactory.Ships;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListFactory.Upgrades;

namespace ListFactory
{
    public class ShipOutfitter : ListBuilder
    {
        public List<Tuple<string, string, string>> upgradeSorter { get; set; }

        public List<Tuple<string, string, string>> UpgradeShip(Dictionary<string, string> storedShips)
        {
            UpgradeLooper loop = new UpgradeLooper();
            upgradeSorter = new List<Tuple<string, string, string>>();
            var upgradeList = new List<Tuple<string, string, string>>();
            foreach (string shipBase in storedShips.Keys)
            {
                string shipbase = shipBase.ToString();
                string shipPP = shipbase;

                if (shipBase.ToString().Contains("Dengar"))
                {
                    upgradeSorter = loop.ListOfProp<Dengar>(shipBase);
                }
                else if (shipBase.ToString().Contains("IG88A"))
                {
                    upgradeSorter = loop.ListOfProp<IG88A>(shipBase);
                }
                else if (shipBase.ToString().Contains("IG88B"))
                {
                    upgradeSorter = loop.ListOfProp<IG88B>(shipBase);
                }
                else if (shipBase.ToString().Contains("IG88C"))
                {
                    upgradeSorter = loop.ListOfProp<IG88C>(shipBase);
                }
                else if (shipBase.ToString().Contains("IG88D"))
                {
                    upgradeSorter = loop.ListOfProp<IG88B>(shipBase);
                }
                else if (shipBase.ToString().Contains("Boba Fett"))
                {
                    upgradeSorter = loop.ListOfProp<BobaFett>(shipBase);
                }
                else if (shipBase.ToString().Contains("Emom Azzameen"))
                {
                    upgradeSorter = loop.ListOfProp<EmomAzzameen>(shipBase);
                }
                else if (shipBase.ToString().Contains("Kath Scarlett"))
                {
                    upgradeSorter = loop.ListOfProp<KathScarlett>(shipBase);
                }
                else if (shipBase.ToString().Contains("Mandalorian Mercenary"))
                {
                    upgradeSorter = loop.ListOfProp<MandalorianMercenary>(shipBase);
                }
                else if (shipBase.ToString().Contains("4-Lom"))
                {
                    upgradeSorter = loop.ListOfProp<FOURLOM>(shipBase);
                }
                else if (shipBase.ToString().Contains("Gand Findsman"))
                {
                    upgradeSorter = loop.ListOfProp<GandFindsman>(shipBase);
                }
                else if (shipBase.ToString().Contains("Ruthless Freelancer"))
                {
                    upgradeSorter = loop.ListOfProp<RuthlessFreelancer>(shipBase);
                }
                else if (shipBase.ToString().Contains("Zuckuss"))
                {
                    upgradeSorter = loop.ListOfProp<Zuckuss>(shipBase);
                }
                else if (shipBase.ToString().Contains("Dace Bonearm"))
                {
                    upgradeSorter = loop.ListOfProp<DaceBonearm>(shipBase);
                }
                else if (shipBase.ToString().Contains("Palob Godalhi"))
                {
                    upgradeSorter = loop.ListOfProp<PalobGodalhi>(shipBase);
                }
                else if (shipBase.ToString().Contains("Spice Runner"))
                {
                    upgradeSorter = loop.ListOfProp<SpiceRunner>(shipBase);
                }
                else if (shipBase.ToString().Contains("Torkil Mux"))
                {
                    upgradeSorter = loop.ListOfProp<TorkilMux>(shipBase);
                }
                else if (shipBase.ToString().Contains("Contracted Scout"))
                {
                    upgradeSorter = loop.ListOfProp<ContractedScout>(shipBase);
                }
                else if (shipBase.ToString().Contains("Manaroo"))
                {
                    upgradeSorter = loop.ListOfProp<Manaroo>(shipBase);
                }
                else if (shipBase.ToString().Contains("Tel Trevura"))
                {
                    upgradeSorter = loop.ListOfProp<TelTrevura>(shipBase);
                }
                else if (shipBase.ToString().Contains("Black Sun Ace"))
                {
                    upgradeSorter = loop.ListOfProp<BlackSunAce>(shipBase);
                }
                else if (shipBase.ToString().Contains("Cartel Marauder"))
                {
                    upgradeSorter = loop.ListOfProp<CartelMarauder>(shipBase);
                }
                else if (shipBase.ToString().Contains("Graz the Hunter"))
                {
                    upgradeSorter = loop.ListOfProp<GrazTheHunter>(shipBase);
                }
                else if (shipBase.ToString().Contains("Talonbane Cobra"))
                {
                    upgradeSorter = loop.ListOfProp<TalonbaneCobra>(shipBase);
                }
                else if (shipBase.ToString().Contains("Asajj Ventress"))
                {
                    upgradeSorter = loop.ListOfProp<AsajjVentress>(shipBase);
                }
                else if (shipBase.ToString().Contains("Ketsu Onyo"))
                {
                    upgradeSorter = loop.ListOfProp<KetsuOnyo>(shipBase);
                }
                else if (shipBase.ToString().Contains("Sabine Wren"))
                {
                    upgradeSorter = loop.ListOfProp<SabineWren>(shipBase);
                }
                else if (shipBase.ToString().Contains("Shadowport Hunter"))
                {
                    upgradeSorter = loop.ListOfProp<ShadowportHunter>(shipBase);
                }
                else if (shipBase.ToString().Contains("Cartel Spicer"))
                {
                    upgradeSorter = loop.ListOfProp<CartelSpicer>(shipBase);
                }
                else if (shipBase.ToString().Contains("Laetin Ashera"))
                {
                    upgradeSorter = loop.ListOfProp<LaetinAshera>(shipBase);
                }
                else if (shipBase.ToString().Contains("Serissu"))
                {
                    upgradeSorter = loop.ListOfProp<Serissu>(shipBase);
                }
                else if (shipBase.ToString().Contains("Tansarii Point Veteran"))
                {
                    upgradeSorter = loop.ListOfProp<TansariiPointVeteran>(shipBase);
                }
                else if (shipBase.ToString().Contains("Concord Dawn Ace"))
                {
                    upgradeSorter = loop.ListOfProp<ConcordDawnAce>(shipBase);
                }
                else if (shipBase.ToString().Contains("Concord Dawn Veteran"))
                {
                    upgradeSorter = loop.ListOfProp<ConcordDawnVeteran>(shipBase);
                }
                else if (shipBase.ToString().Contains("Fenn Rau"))
                {
                    upgradeSorter = loop.ListOfProp<FennRau>(shipBase);
                }
                else if (shipBase.ToString().Contains("Kad Solus"))
                {
                    upgradeSorter = loop.ListOfProp<KadSolus>(shipBase);
                }
                else if (shipBase.ToString().Contains("Old Teroch"))
                {
                    upgradeSorter = loop.ListOfProp<OldTeroch>(shipBase);
                }
                else if (shipBase.ToString().Contains("Zealous Recruit"))
                {
                    upgradeSorter = loop.ListOfProp<ZealousRecruit>(shipBase);
                }
                else if (shipBase.ToString().Contains("Unkar Plutt"))
                {
                    upgradeSorter = loop.ListOfProp<UnkarPlutt>(shipBase);
                }
                else if (shipBase.ToString().Contains("Black Sun Enforcer Z-95"))
                {
                    upgradeSorter = loop.ListOfProp<BlackSunEnforcerZ>(shipBase);
                }
                else if (shipBase.ToString().Contains("Black Sun Enforcer"))
                {
                    upgradeSorter = loop.ListOfProp<BlackSunEnforcer>(shipBase);
                }
                else if (shipBase.ToString().Contains("Black Sun Vigo"))
                {
                    upgradeSorter = loop.ListOfProp<BlackSunVigo>(shipBase);
                }
                else if (shipBase.ToString().Contains("Guri"))
                {
                    upgradeSorter = loop.ListOfProp<Guri>(shipBase);
                }
                else if (shipBase.ToString().Contains("Prince Xizor"))
                {
                    upgradeSorter = loop.ListOfProp<PrinceXizor>(shipBase);
                }
                else if (shipBase.ToString().Contains("Bossk"))
                {
                    upgradeSorter = loop.ListOfProp<Bossk>(shipBase);
                }
                else if (shipBase.ToString().Contains("Latts Razzi"))
                {
                    upgradeSorter = loop.ListOfProp<LattsRazzi>(shipBase);
                }
                else if (shipBase.ToString().Contains("Moralo Eval"))
                {
                    upgradeSorter = loop.ListOfProp<MoraloEval>(shipBase);
                }
                else if (shipBase.ToString().Contains("Trandoshan Slaver"))
                {
                    upgradeSorter = loop.ListOfProp<TrandoshanSlaver>(shipBase);
                }
                else if (shipBase.ToString().Contains("Drea Renthal"))
                {
                    upgradeSorter = loop.ListOfProp<DreaRenthal>(shipBase);
                }
                else if (shipBase.ToString().Contains("Kavil"))
                {
                    upgradeSorter = loop.ListOfProp<Kavil>(shipBase);
                }
                else if (shipBase.ToString().Contains("Syndicate Thug"))
                {
                    upgradeSorter = loop.ListOfProp<SyndicateThug>(shipBase);
                }
                else if (shipBase.ToString().Contains("Binayre Pirate"))
                {
                    upgradeSorter = loop.ListOfProp<BinayrePirate>(shipBase);
                }
                else if (shipBase.ToString().Contains("Kaato Leeachos"))
                {
                    upgradeSorter = loop.ListOfProp<KaatoLeeachos>(shipBase);
                }
                else if (shipBase.ToString().Contains("N'dru Suhlak"))
                {
                    upgradeSorter = loop.ListOfProp<NdruSuhlak>(shipBase);
                }
                else if (shipBase.ToString().Contains("Hired Gun"))
                {
                    upgradeSorter = loop.ListOfProp<HiredGun>(shipBase);
                }
                else
                {
                    throw new Exception(string.Format("Didn't find key {0}", shipBase.ToString()));
                }
                upgradeList.AddRange(upgradeSorter);
            }
            return upgradeList;
        }

        public Dictionary<string, int> RandomUpgrade(string upgradeType)
        {
            RandomizerHelper randomDictionary = new RandomizerHelper();
            string upgradeName = "";
            int[] numbers;
            int shuffle = 0;
            Dictionary<string, int> dict;
            if (upgradeType.Contains("Cannon"))
            {
                Cannon cannons = new Cannon();
                dict = cannons.CannonUpgrades;
                Random rand = new Random();
                numbers = new[] { 1, 2, 3, 4, 5, 7 };
                shuffle = numbers.OrderBy(n => Guid.NewGuid()).ToArray().First();
                foreach (var weapon in randomDictionary.RandomValues(dict, shuffle).Take(1))
                {
                    upgradeName = weapon;
                    continue;
                }
            }
            else if (upgradeType.Contains("Torpedo"))
            {
                Torpedo torp = new Torpedo();
                dict = torp.TorpedoUpgrades;
                Random rand = new Random();
                numbers = new[] { 2, 3, 4, 5, 6 };
                shuffle = numbers.OrderBy(n => Guid.NewGuid()).ToArray().First();
                foreach (var weapon in randomDictionary.RandomValues(dict, shuffle).Take(1))
                {
                    upgradeName = weapon;
                    continue;
                }
            }
            else if (upgradeType.Contains("Illicit"))
            {
                Illicit illict = new Illicit();
                dict = illict.IllicitUpgrades;
                Random rand = new Random();
                numbers = new[] { 1, 2, 3 };
                shuffle = numbers.OrderBy(n => Guid.NewGuid()).ToArray().First();
                foreach (var weapon in randomDictionary.RandomValues(dict, shuffle).Take(1))
                {
                    upgradeName = weapon;
                    continue;
                }
            }
            else if (upgradeType.Contains("ElitePilotTalent"))
            {
                ElitePilotTalent ept = new ElitePilotTalent();
                ShipBuilder shipB = new ShipBuilder();
                if (shipB.CurrentFaction == "scum")
                {
                    foreach (var talents in ept.ScumEPT)
                    {
                        ept.GenEPT.Add(talents.Key, talents.Value);
                    }
                }

                dict = ept.GenEPT;
                Random rand = new Random();
                numbers = new[] { 0, 1, 2, 3, 4 };
                shuffle = numbers.OrderBy(n => Guid.NewGuid()).ToArray().First();
                foreach (var weapon in randomDictionary.RandomValues(dict, shuffle).Take(1))
                {
                    upgradeName = weapon;
                    continue;
                }
            }
            else if (upgradeType.Contains("Crew"))
            {
                Crew crew = new Crew();
                ShipBuilder shipB = new ShipBuilder();
                if (shipB.CurrentFaction == "scum")
                {
                    foreach (var talents in crew.ScumCrew)
                    {
                        crew.GenCrew.Add(talents.Key, talents.Value);
                    }                    
                }
                
                foreach (string pilotName in shipB.Ships.Keys)
                {
                    try
                    {
                        crew.GenCrew.Remove(pilotName);
                    }
                    catch
                    {
                        Console.WriteLine(string.Format("Attempted to remove {0} from the crew list, but didn't find them as an available crew.", pilotName));
                    }
                }

                dict = crew.GenCrew;
                Random rand = new Random();
                numbers = new[] { 1, 2, 3, 4, 5 };
                shuffle = numbers.OrderBy(n => Guid.NewGuid()).ToArray().First();
                foreach (var weapon in randomDictionary.RandomValues(dict, shuffle).Take(1))
                {
                    upgradeName = weapon;
                    continue;
                }
            }
            else if (upgradeType.Contains("Missile"))
            {
                Missile missile = new Missile();

                dict = missile.MissileUpgrade;
                Random rand = new Random();
                numbers = new[] { 1, 3, 4, 5 };
                shuffle = numbers.OrderBy(n => Guid.NewGuid()).ToArray().First();
                foreach (var weapon in randomDictionary.RandomValues(dict, shuffle).Take(1))
                {
                    upgradeName = weapon;
                    continue;
                }
            }
            else if (upgradeType.Contains("SalvagedAstromech"))
            {
                SalvagedAstromech astromech = new SalvagedAstromech();

                dict = astromech.SalvagedAstromechs;
                Random rand = new Random();
                numbers = new[] { 0, 1, 2, 3 };
                shuffle = numbers.OrderBy(n => Guid.NewGuid()).ToArray().First();
                foreach (var weapon in randomDictionary.RandomValues(dict, shuffle).Take(1))
                {
                    upgradeName = weapon;
                    continue;
                }
            }
            else if (upgradeType.Contains("System"))
            {
                Systems system = new Systems();

                dict = system.SystemsUpgrade;
                Random rand = new Random();
                numbers = new[] { 0, 1, 2, 3, 4 };
                shuffle = numbers.OrderBy(n => Guid.NewGuid()).ToArray().First();
                foreach (var weapon in randomDictionary.RandomValues(dict, shuffle).Take(1))
                {
                    upgradeName = weapon;
                    continue;
                }
            }
            else if (upgradeType.Contains("Modification"))
            {
                Modification modification = new Modification();

                dict = modification.Modifications;
                Random rand = new Random();
                numbers = new[] { 0, 1, 2, 3, 4 };
                shuffle = numbers.OrderBy(n => Guid.NewGuid()).ToArray().First();
                foreach (var weapon in randomDictionary.RandomValues(dict, shuffle).Take(1))
                {
                    upgradeName = weapon;
                    continue;
                }
            }

            dict = new Dictionary<string, int>();
            dict.Add(upgradeName, shuffle);
            return dict;
        }
    }
}
