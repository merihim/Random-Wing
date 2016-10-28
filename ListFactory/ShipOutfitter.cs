using ListFactory.Ships;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListFactory
{
    public class ShipOutfitter : ListBuilder
    {
        public List<Tuple<Type, string, string>> UpgradeShip(Dictionary<Type, string> storedShips)
        {
            List<Tuple<Type, string, string>> upgradeSorter = new List<Tuple<Type, string, string>>();
            UpgradeLooper loop = new UpgradeLooper();
            foreach (Type shipBase in storedShips.Keys)
            {
                string shipbase = shipBase.ToString();
                string shipPP = shipbase;

                if (shipBase.ToString().Contains("Dengar"))
                {
                    upgradeSorter.AddRange(loop.ListOfProp<Dengar>());
                }

                if (shipBase.ToString().Contains("IG88A"))
                {
                    upgradeSorter.AddRange(loop.ListOfProp<IG88A>());
                }
                else if (shipBase.ToString().Contains("IG88B"))
                {
                    upgradeSorter.AddRange(loop.ListOfProp<IG88B>());
                }
                else if (shipBase.ToString().Contains("IG88C"))
                {
                    upgradeSorter.AddRange(loop.ListOfProp<IG88C>());
                }
                else if (shipBase.ToString().Contains("IG88D"))
                {
                    upgradeSorter.AddRange(loop.ListOfProp<IG88B>());
                }
                else if (shipBase.ToString().Contains("BobaFett"))
                {
                    upgradeSorter.AddRange(loop.ListOfProp<BobaFett>());
                }
                else if (shipBase.ToString().Contains("EmomAzzameen"))
                {
                    upgradeSorter.AddRange(loop.ListOfProp<EmomAzzameen>());
                }
                else if (shipBase.ToString().Contains("KathScarlett"))
                {
                    upgradeSorter.AddRange(loop.ListOfProp<KathScarlett>());
                }
                else if (shipBase.ToString().Contains("MandalorianMercenary"))
                {
                    upgradeSorter.AddRange(loop.ListOfProp<MandalorianMercenary>());
                }
                else if (shipBase.ToString().Contains("FOURLOM"))
                {
                    upgradeSorter.AddRange(loop.ListOfProp<FOURLOM>());
                }
                else if (shipBase.ToString().Contains("GandFindsman"))
                {
                    upgradeSorter.AddRange(loop.ListOfProp<GandFindsman>());
                }
                else if (shipBase.ToString().Contains("RuthlessFreelancer"))
                {
                    upgradeSorter.AddRange(loop.ListOfProp<RuthlessFreelancer>());
                }
                else if (shipBase.ToString().Contains("Zuckuss"))
                {
                    upgradeSorter.AddRange(loop.ListOfProp<Zuckuss>());
                }
                else if (shipBase.ToString().Contains("DaceBonearm"))
                {
                    upgradeSorter.AddRange(loop.ListOfProp<DaceBonearm>());                
                }
                else if (shipBase.ToString().Contains("PalobGodalhi"))
                {
                    upgradeSorter.AddRange(loop.ListOfProp<PalobGodalhi>());
                }
                else if (shipBase.ToString().Contains("SpiceRunner"))
                {
                    upgradeSorter.AddRange(loop.ListOfProp<SpiceRunner>());
                }
                else if (shipBase.ToString().Contains("TorkilMux"))
                {
                    upgradeSorter.AddRange(loop.ListOfProp<TorkilMux>());
                }
                else if (shipBase.ToString().Contains("ContractedScout"))
                {
                    upgradeSorter.AddRange(loop.ListOfProp<ContractedScout>());
                }
                else if (shipBase.ToString().Contains("Manaroo"))
                {
                    upgradeSorter.AddRange(loop.ListOfProp<Manaroo>());
                }
                else if (shipBase.ToString().Contains("TelTrevura"))
                {
                    upgradeSorter.AddRange(loop.ListOfProp<TelTrevura>());
                }
                else if (shipBase.ToString().Contains("BlackSunAce"))
                {
                    upgradeSorter.AddRange(loop.ListOfProp<BlackSunAce>());
                }
                else if (shipBase.ToString().Contains("CartelMarauder"))
                {
                    upgradeSorter.AddRange(loop.ListOfProp<CartelMarauder>());
                }
                else if (shipBase.ToString().Contains("GrazTheHunter"))
                {
                    upgradeSorter.AddRange(loop.ListOfProp<GrazTheHunter>());
                }
                else if (shipBase.ToString().Contains("TalonbaneCobra"))
                {
                    upgradeSorter.AddRange(loop.ListOfProp<TalonbaneCobra>());
                }
                else if (shipBase.ToString().Contains("AsajjVentress"))
                {
                    upgradeSorter.AddRange(loop.ListOfProp<AsajjVentress>());
                }
                else if (shipBase.ToString().Contains("KetsuOnyo"))
                {
                    upgradeSorter.AddRange(loop.ListOfProp<KetsuOnyo>());
                }
                else if (shipBase.ToString().Contains("SabineWren"))
                {
                    upgradeSorter.AddRange(loop.ListOfProp<SabineWren>());
                }
                else if (shipBase.ToString().Contains("ShadowportHunter"))
                {
                    upgradeSorter.AddRange(loop.ListOfProp<ShadowportHunter>());
                }
                else if (shipBase.ToString().Contains("CartelSpicer"))
                {
                    upgradeSorter.AddRange(loop.ListOfProp<CartelSpicer>());
                }
                else if (shipBase.ToString().Contains("LaetinAshera"))
                {
                    upgradeSorter.AddRange(loop.ListOfProp<LaetinAshera>());
                }
                else if (shipBase.ToString().Contains("Serissu"))
                {
                    upgradeSorter.AddRange(loop.ListOfProp<Serissu>());
                }
                else if (shipBase.ToString().Contains("TansariiPointVeteran"))
                {
                    upgradeSorter.AddRange(loop.ListOfProp<TansariiPointVeteran>());
                }
                else if (shipBase.ToString().Contains("ConcordDawnAce"))
                {
                    upgradeSorter.AddRange(loop.ListOfProp<ConcordDawnAce>());
                }
                else if (shipBase.ToString().Contains("ConcordDawnVeteran"))
                {
                    upgradeSorter.AddRange(loop.ListOfProp<ConcordDawnVeteran>());
                }
                else if (shipBase.ToString().Contains("FennRau"))
                {
                    upgradeSorter.AddRange(loop.ListOfProp<FennRau>());
                }
                else if (shipBase.ToString().Contains("KadSolus"))
                {
                    upgradeSorter.AddRange(loop.ListOfProp<KadSolus>());
                }
                else if (shipBase.ToString().Contains("OldTeroch"))
                {
                    upgradeSorter.AddRange(loop.ListOfProp<OldTeroch>());
                }
                else if (shipBase.ToString().Contains("ZealousRecruit"))
                {
                    upgradeSorter.AddRange(loop.ListOfProp<ZealousRecruit>());
                }
                else if (shipBase.ToString().Contains("UnkarPlutt"))
                {
                    upgradeSorter.AddRange(loop.ListOfProp<UnkarPlutt>());
                }
                else if (shipBase.ToString().Contains("BlackSunEnforcer"))
                {
                    upgradeSorter.AddRange(loop.ListOfProp<BlackSunEnforcer>());
                }
                else if (shipBase.ToString().Contains("BlackSunVigo"))
                {
                    upgradeSorter.AddRange(loop.ListOfProp<BlackSunVigo>());
                }
                else if (shipBase.ToString().Contains("Guri"))
                {
                    upgradeSorter.AddRange(loop.ListOfProp<Guri>());
                }
                else if (shipBase.ToString().Contains("PrinceXizor"))
                {
                    upgradeSorter.AddRange(loop.ListOfProp<PrinceXizor>());
                }
                else if (shipBase.ToString().Contains("Bossk"))
                {
                    upgradeSorter.AddRange(loop.ListOfProp<Bossk>());
                }
                else if (shipBase.ToString().Contains("LattsRazzi"))
                {
                    upgradeSorter.AddRange(loop.ListOfProp<LattsRazzi>());
                }
                else if (shipBase.ToString().Contains("MoraloEval"))
                {
                    upgradeSorter.AddRange(loop.ListOfProp<MoraloEval>());
                }
                else if (shipBase.ToString().Contains("TrandoshanSlaver"))
                {
                    upgradeSorter.AddRange(loop.ListOfProp<TrandoshanSlaver>());
                }
                else if (shipBase.ToString().Contains("DreaRenthal"))
                {
                    upgradeSorter.AddRange(loop.ListOfProp<DreaRenthal>());
                }
                else if (shipBase.ToString().Contains("Kavil"))
                {
                    upgradeSorter.AddRange(loop.ListOfProp<Kavil>());
                }
                else if (shipBase.ToString().Contains("SyndicateThug"))
                {
                    upgradeSorter.AddRange(loop.ListOfProp<SyndicateThug>());
                }
                else if (shipBase.ToString().Contains("BinayrePirate"))
                {
                    upgradeSorter.AddRange(loop.ListOfProp<BinayrePirate>());
                }
                else if (shipBase.ToString().Contains("BlackSunEnforcerZ"))
                {
                    upgradeSorter.AddRange(loop.ListOfProp<BlackSunEnforcerZ>());
                }
                else if (shipBase.ToString().Contains("KaatoLeeachos"))
                {
                    upgradeSorter.AddRange(loop.ListOfProp<KaatoLeeachos>());
                }
                else if (shipBase.ToString().Contains("NdruSuhlak"))
                {
                    upgradeSorter.AddRange(loop.ListOfProp<NdruSuhlak>());
                }
                else
                {
                    throw new Exception(string.Format("Didn't find key {0}", shipBase.ToString()));
                }
            }

            return upgradeSorter;           
        }
    }
}
