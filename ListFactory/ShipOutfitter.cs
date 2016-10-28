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
        public List<Tuple<Type, string, string>> upgradeSorter { get; set; }

        public List<Tuple<Type, string, string>> UpgradeShip(Dictionary<Type, string> storedShips)
        {
            UpgradeLooper loop = new UpgradeLooper();
            upgradeSorter = new List<Tuple<Type, string, string>>();
            var upgradeList = new List<Tuple<Type, string, string>>();
            foreach (Type shipBase in storedShips.Keys)
            {
                string shipbase = shipBase.ToString();
                string shipPP = shipbase;

                if (shipBase.ToString().Contains("Dengar"))
                {
                    upgradeSorter = loop.ListOfProp<Dengar>();
                }
                else if (shipBase.ToString().Contains("IG88A"))
                {
                    upgradeSorter = loop.ListOfProp<IG88A>();
                }
                else if (shipBase.ToString().Contains("IG88B"))
                {
                    upgradeSorter = loop.ListOfProp<IG88B>();
                }
                else if (shipBase.ToString().Contains("IG88C"))
                {
                    upgradeSorter = loop.ListOfProp<IG88C>();
                }
                else if (shipBase.ToString().Contains("IG88D"))
                {
                    upgradeSorter = loop.ListOfProp<IG88B>();
                }
                else if (shipBase.ToString().Contains("BobaFett"))
                {
                    upgradeSorter = loop.ListOfProp<BobaFett>();
                }
                else if (shipBase.ToString().Contains("EmomAzzameen"))
                {
                    upgradeSorter = loop.ListOfProp<EmomAzzameen>();
                }
                else if (shipBase.ToString().Contains("KathScarlett"))
                {
                    upgradeSorter = loop.ListOfProp<KathScarlett>();
                }
                else if (shipBase.ToString().Contains("MandalorianMercenary"))
                {
                    upgradeSorter = loop.ListOfProp<MandalorianMercenary>();
                }
                else if (shipBase.ToString().Contains("FOURLOM"))
                {
                    upgradeSorter = loop.ListOfProp<FOURLOM>();
                }
                else if (shipBase.ToString().Contains("GandFindsman"))
                {
                    upgradeSorter = loop.ListOfProp<GandFindsman>();
                }
                else if (shipBase.ToString().Contains("RuthlessFreelancer"))
                {
                    upgradeSorter = loop.ListOfProp<RuthlessFreelancer>();
                }
                else if (shipBase.ToString().Contains("Zuckuss"))
                {
                    upgradeSorter = loop.ListOfProp<Zuckuss>();
                }
                else if (shipBase.ToString().Contains("DaceBonearm"))
                {
                    upgradeSorter = loop.ListOfProp<DaceBonearm>();
                }
                else if (shipBase.ToString().Contains("PalobGodalhi"))
                {
                    upgradeSorter = loop.ListOfProp<PalobGodalhi>();
                }
                else if (shipBase.ToString().Contains("SpiceRunner"))
                {
                    upgradeSorter = loop.ListOfProp<SpiceRunner>();
                }
                else if (shipBase.ToString().Contains("TorkilMux"))
                {
                    upgradeSorter = loop.ListOfProp<TorkilMux>();
                }
                else if (shipBase.ToString().Contains("ContractedScout"))
                {
                    upgradeSorter = loop.ListOfProp<ContractedScout>();
                }
                else if (shipBase.ToString().Contains("Manaroo"))
                {
                    upgradeSorter = loop.ListOfProp<Manaroo>();
                }
                else if (shipBase.ToString().Contains("TelTrevura"))
                {
                    upgradeSorter = loop.ListOfProp<TelTrevura>();
                }
                else if (shipBase.ToString().Contains("BlackSunAce"))
                {
                    upgradeSorter = loop.ListOfProp<BlackSunAce>();
                }
                else if (shipBase.ToString().Contains("CartelMarauder"))
                {
                    upgradeSorter = loop.ListOfProp<CartelMarauder>();
                }
                else if (shipBase.ToString().Contains("GrazTheHunter"))
                {
                    upgradeSorter = loop.ListOfProp<GrazTheHunter>();
                }
                else if (shipBase.ToString().Contains("TalonbaneCobra"))
                {
                    upgradeSorter = loop.ListOfProp<TalonbaneCobra>();
                }
                else if (shipBase.ToString().Contains("AsajjVentress"))
                {
                    upgradeSorter = loop.ListOfProp<AsajjVentress>();
                }
                else if (shipBase.ToString().Contains("KetsuOnyo"))
                {
                    upgradeSorter = loop.ListOfProp<KetsuOnyo>();
                }
                else if (shipBase.ToString().Contains("SabineWren"))
                {
                    upgradeSorter = loop.ListOfProp<SabineWren>();
                }
                else if (shipBase.ToString().Contains("ShadowportHunter"))
                {
                    upgradeSorter = loop.ListOfProp<ShadowportHunter>();
                }
                else if (shipBase.ToString().Contains("CartelSpicer"))
                {
                    upgradeSorter = loop.ListOfProp<CartelSpicer>();
                }
                else if (shipBase.ToString().Contains("LaetinAshera"))
                {
                    upgradeSorter = loop.ListOfProp<LaetinAshera>();
                }
                else if (shipBase.ToString().Contains("Serissu"))
                {
                    upgradeSorter = loop.ListOfProp<Serissu>();
                }
                else if (shipBase.ToString().Contains("TansariiPointVeteran"))
                {
                    upgradeSorter = loop.ListOfProp<TansariiPointVeteran>();
                }
                else if (shipBase.ToString().Contains("ConcordDawnAce"))
                {
                    upgradeSorter = loop.ListOfProp<ConcordDawnAce>();
                }
                else if (shipBase.ToString().Contains("ConcordDawnVeteran"))
                {
                    upgradeSorter = loop.ListOfProp<ConcordDawnVeteran>();
                }
                else if (shipBase.ToString().Contains("FennRau"))
                {
                    upgradeSorter = loop.ListOfProp<FennRau>();
                }
                else if (shipBase.ToString().Contains("KadSolus"))
                {
                    upgradeSorter = loop.ListOfProp<KadSolus>();
                }
                else if (shipBase.ToString().Contains("OldTeroch"))
                {
                    upgradeSorter = loop.ListOfProp<OldTeroch>();
                }
                else if (shipBase.ToString().Contains("ZealousRecruit"))
                {
                    upgradeSorter = loop.ListOfProp<ZealousRecruit>();
                }
                else if (shipBase.ToString().Contains("UnkarPlutt"))
                {
                    upgradeSorter = loop.ListOfProp<UnkarPlutt>();
                }
                else if (shipBase.ToString().Contains("BlackSunEnforcer"))
                {
                    upgradeSorter = loop.ListOfProp<BlackSunEnforcer>();
                }
                else if (shipBase.ToString().Contains("BlackSunVigo"))
                {
                    upgradeSorter = loop.ListOfProp<BlackSunVigo>();
                }
                else if (shipBase.ToString().Contains("Guri"))
                {
                    upgradeSorter = loop.ListOfProp<Guri>();
                }
                else if (shipBase.ToString().Contains("PrinceXizor"))
                {
                    upgradeSorter = loop.ListOfProp<PrinceXizor>();
                }
                else if (shipBase.ToString().Contains("Bossk"))
                {
                    upgradeSorter = loop.ListOfProp<Bossk>();
                }
                else if (shipBase.ToString().Contains("LattsRazzi"))
                {
                    upgradeSorter = loop.ListOfProp<LattsRazzi>();
                }
                else if (shipBase.ToString().Contains("MoraloEval"))
                {
                    upgradeSorter = loop.ListOfProp<MoraloEval>();
                }
                else if (shipBase.ToString().Contains("TrandoshanSlaver"))
                {
                    upgradeSorter = loop.ListOfProp<TrandoshanSlaver>();
                }
                else if (shipBase.ToString().Contains("DreaRenthal"))
                {
                    upgradeSorter = loop.ListOfProp<DreaRenthal>();
                }
                else if (shipBase.ToString().Contains("Kavil"))
                {
                    upgradeSorter = loop.ListOfProp<Kavil>();
                }
                else if (shipBase.ToString().Contains("SyndicateThug"))
                {
                    upgradeSorter = loop.ListOfProp<SyndicateThug>();
                }
                else if (shipBase.ToString().Contains("BinayrePirate"))
                {
                    upgradeSorter = loop.ListOfProp<BinayrePirate>();
                }
                else if (shipBase.ToString().Contains("BlackSunEnforcerZ"))
                {
                    upgradeSorter = loop.ListOfProp<BlackSunEnforcerZ>();
                }
                else if (shipBase.ToString().Contains("KaatoLeeachos"))
                {
                    upgradeSorter = loop.ListOfProp<KaatoLeeachos>();
                }
                else if (shipBase.ToString().Contains("NdruSuhlak"))
                {
                    upgradeSorter = loop.ListOfProp<NdruSuhlak>();
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
            dict = new Dictionary<string, int>();
            dict.Add(upgradeName, shuffle);
            return dict;
        }
    }
}
