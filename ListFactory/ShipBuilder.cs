using ListFactory.Ships;
using ListFactory.UniqueLayers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ListFactory
{
    public class ShipBuilder : ListBuilder
    {
        public int PointsBudget { get; set; }
        public int SpentSoFar { get; set; }
        public int ShipBudget { get; set; }
        public int SpentOnShips { get; set; }
        public int SpentOnUpgrades { get; set; }
        public int UpgradeBudget { get; set; }
        public double HowMuchDoWeSpendOnShips { get; set; }

        public string CurrentFaction { get; set; }

        int[] arrayOfNumbers {get; set; }
        public List<int> numbers { get; set; }
        public int[] Scum = new[] { 12, 13, 14, 15, 16, 17, 18, 19, 20, 22, 23, 24, 25, 26, 27, 28, 29, 20, 31, 33, 34, 35, 36, 37, 38, 39 };
        public int[] Rebels = new[] { 12, 13, 14, 15, 16, 17, 18, 19, 20, 22, 23, 24, 25, 26, 27, 28, 29, 20, 31, 33, 34, 35, 36, 37, 38, 39 };
        public int[] Imperials = new[] { 12, 13, 14, 15, 16, 17, 18, 19, 20, 22, 23, 24, 25, 26, 27, 28 ,29, 20, 31, 33, 34, 35, 36, 37, 38, 39 };

        public Dictionary<string, string> Ships { get; set; }
        public List<Tuple<string, string, string>> ShipUpgrades { get; set; }
        public Dictionary<string, string> UpgradeRandomizer { get; set; }
        public Dictionary<string, string> FinalList { get; set; }

        public void ChooseFaction()
        {
            Console.Write("Please choose a faction Scum/Rebels/Imperials: ");
            string choice = Console.ReadLine();

            switch (choice.ToLower())
            {
                case "imperials":
                    CurrentFaction = "Imperial";
                    arrayOfNumbers = Imperials;
                    Console.WriteLine("You chose the valiant Imperials");
                    break;
                case "i":
                    arrayOfNumbers = Imperials;
                    CurrentFaction = "Imperial";
                    Console.WriteLine("You chose the valiant Imperials");
                    break;
                case "rebels":
                    arrayOfNumbers = Rebels;
                    CurrentFaction = "Rebels";
                    Console.WriteLine("You chose the dastardly Rebels");
                    break;
                case "rebel":
                    arrayOfNumbers = Rebels;
                    CurrentFaction = "Rebels";
                    Console.WriteLine("You chose the dastardly Rebels");
                    break;
                case "r":
                    arrayOfNumbers = Rebels;
                    CurrentFaction = "Rebels";
                    Console.WriteLine("You chose the dastardly Rebels");
                    break;
                case "scum":
                    arrayOfNumbers = Scum;
                    CurrentFaction = "Scum";
                    Console.WriteLine("You chose the handsome Bounty Hunters");
                    break;
                case "best faction":
                    arrayOfNumbers = Scum;
                    CurrentFaction = "Scum";
                    Console.WriteLine("You chose the handsome Bounty Hunters");
                    break;
                case "scub":
                    arrayOfNumbers = Scum;
                    CurrentFaction = "Scum";
                    Console.WriteLine("You chose the handsome Bounty Hunters");
                    break;
                case "the only faction that matters":
                    arrayOfNumbers = Scum;
                    CurrentFaction = "Scum";
                    Console.WriteLine("You chose the handsome Bounty Hunters");
                    break;
                case "duh":
                    arrayOfNumbers = Scum;
                    CurrentFaction = "Scum";
                    Console.WriteLine("You chose the handsome Bounty Hunters");
                    break;
                case "s":
                    arrayOfNumbers = Scum;
                    CurrentFaction = "Scum";
                    Console.WriteLine("You chose the handsome Bounty Hunters");
                    break;
                default:
                    Console.WriteLine("That wasn't a valid input... Try again...  This time try typing 'Best Faction'");
                    Console.WriteLine("");
                    ChooseFaction();
                    break;
            }
            Console.WriteLine("");
        }

        public void SetPoints()
        {
            Console.WriteLine("How many points for this project?");
            try
            {
                PointsBudget = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("That was not a valid point number");
                Console.WriteLine("");
            }

            Console.WriteLine("How many points do we spend on ships?  Type 'RANDOM' or 'R' if you want a random value to be input.");
            Console.WriteLine("WARNING: Due to the truly random nature of this program, you may end up with more or less ship points (to a max of the lowest cost ship).");
            string shipCost = Console.ReadLine();
            Console.WriteLine("");
            {
                if (shipCost.ToLower() == "random" | shipCost.ToLower() == "r")
                {
                    Random r = new Random();
                    shipCost = r.Next(60, 100).ToString();

                    try
                    {
                        HowMuchDoWeSpendOnShips = (PointsBudget / Convert.ToInt32(shipCost));
                        ShipBudget = (Convert.ToInt32(shipCost));
                    }
                    catch
                    {
                        Console.WriteLine("Your input for a shipcost was not valid.  Please use whole numbers or RANDOM.");
                        SetPoints();
                    }

                }
                else
                {
                    try
                    {
                        HowMuchDoWeSpendOnShips = (PointsBudget / Convert.ToInt32(shipCost));
                        ShipBudget = (Convert.ToInt32(shipCost));
                    }
                    catch
                    {
                        Console.WriteLine("Your input for a shipcost was not valid.  Please use whole numbers or RANDOM.");
                        SetPoints();
                    }
                }

            }
            Console.WriteLine(string.Format("Sounds good!  You've given us {0} points to work with.  We're going to spend {1} on ships and {2} on upgrades", PointsBudget, shipCost, PointsBudget - Convert.ToInt32(shipCost)));
            Console.WriteLine("");
        }

        /// <summary>
        /// Generates a number of ships that is within a range
        /// </summary>
        public void GenerateShips()
        {
            RandomizerHelper randomDictionary = new RandomizerHelper();
            DictionaryStorage listOfShips = new DictionaryStorage();
            UniqueList uniqueList = new UniqueList();
            Dictionary<string, int> dict = new Dictionary<string, int>();
            Ships = new Dictionary<string, string>();

            numbers = arrayOfNumbers.ToList();

            if (CurrentFaction == "Scum")
            {
                dict = listOfShips.ScumShips;

            }

            int shipAudit = 0;
            int pointsSpent = 0;
            Random r = new Random();
            if (pointsSpent < ShipBudget)
            {
                ShipCost = numbers.OrderBy(n => Guid.NewGuid()).ToArray().First();
                pointsSpent = pointsSpent + ShipCost;
            }
            
            foreach (var fetchedShipName in randomDictionary.RandomValues(dict, ShipCost).Take(1))
            {
                Ship1Name = fetchedShipName;
                Ships.Add("Ship 1: " + fetchedShipName, Ship1Name);
                if (uniqueList.UniqueVar.Contains(fetchedShipName))
                {
                    dict.Remove(fetchedShipName);
                    
                    if (!dict.Values.Contains(ShipCost))
                    {
                        numbers.Remove(ShipCost);
                    }
                }
                
            }

            if (pointsSpent < ShipBudget)
            {
                Ship2Cost = numbers.OrderBy(n => Guid.NewGuid()).ToArray().First();
                pointsSpent = pointsSpent + Ship2Cost;
            }


            foreach (var fetchedShipName in randomDictionary.RandomValues(dict, Ship2Cost).Take(1))
            {
                Ship2Name = fetchedShipName.ToString();
                Ships.Add("Ship 2: " + fetchedShipName, Ship2Name);
                if (uniqueList.UniqueVar.Contains(fetchedShipName))
                {
                    dict.Remove(fetchedShipName);
                    if (uniqueList.UniqueVar.Contains(fetchedShipName))
                    {
                        dict.Remove(fetchedShipName);

                        if (!dict.Values.Contains(ShipCost))
                        {
                            numbers.Remove(ShipCost);
                        }
                    }
                }
            }

            if (pointsSpent < ShipBudget)
            {
                if (pointsSpent < ShipBudget - 5)
                {
                    shipAudit = numbers.OrderBy(n => Guid.NewGuid()).ToArray().First();
                    while (shipAudit + pointsSpent > ShipBudget + 5)
                    {
                        shipAudit = numbers.OrderBy(n => Guid.NewGuid()).ToArray().First();
                    }

                    Ship3Cost = shipAudit;
                    pointsSpent = pointsSpent + Ship3Cost;
                }
            }

            if (Ship3Cost > 0)
            {
                foreach (var fetchedShipName in randomDictionary.RandomValues(dict, Ship3Cost).Take(1))
                {
                    Ship3Name = fetchedShipName.ToString();
                    Ships.Add("Ship 3: " + fetchedShipName, Ship3Name);
                    if (uniqueList.UniqueVar.Contains(fetchedShipName))
                    {
                        dict.Remove(fetchedShipName);

                        if (!dict.Values.Contains(ShipCost))
                        {
                            numbers.Remove(ShipCost);
                        }
                    }
                }
            }
            
            if (pointsSpent < ShipBudget)
            {
                if (pointsSpent < ShipBudget - 12)
                {
                    shipAudit = numbers.OrderBy(n => Guid.NewGuid()).ToArray().First();
                    while (shipAudit + pointsSpent > ShipBudget + 5)
                    {
                        shipAudit = numbers.OrderBy(n => Guid.NewGuid()).ToArray().First();
                    }

                    Ship4Cost = shipAudit;
                    pointsSpent = pointsSpent + Ship4Cost;
                }
            }

            if (Ship4Cost > 0)
            {
                foreach (var fetchedShipName in randomDictionary.RandomValues(dict, Ship4Cost).Take(1))
                {
                    Ship4Name = fetchedShipName.ToString();
                    Ships.Add("Ship 4: " + fetchedShipName, Ship4Name);
                    if (uniqueList.UniqueVar.Contains(fetchedShipName))
                    {
                        dict.Remove(fetchedShipName);

                        if (!dict.Values.Contains(ShipCost))
                        {
                            numbers.Remove(ShipCost);
                        }
                    }
                }
            }

            if (pointsSpent < ShipBudget)
            {
                if (pointsSpent < ShipBudget - 12)
                {
                    shipAudit = numbers.OrderBy(n => Guid.NewGuid()).ToArray().First();
                    while (shipAudit + pointsSpent > ShipBudget + 5)
                    {
                        shipAudit = numbers.OrderBy(n => Guid.NewGuid()).ToArray().First();
                    }

                    Ship5Cost = shipAudit;
                    pointsSpent = pointsSpent + Ship5Cost;
                }
            }

            if (Ship5Cost > 0)
            {
                foreach (var fetchedShipName in randomDictionary.RandomValues(dict, Ship5Cost).Take(1))
                {
                    Ship5Name = fetchedShipName.ToString();
                    Ships.Add("Ship 5: " + fetchedShipName, Ship4Name);
                    if (uniqueList.UniqueVar.Contains(fetchedShipName))
                    {
                        dict.Remove(fetchedShipName);

                        if (!dict.Values.Contains(ShipCost))
                        {
                            numbers.Remove(ShipCost);
                        }
                    }
                }
            }

            Console.WriteLine("");
            Console.Write(string.Format("We finished building your ships.  We will be spending {0} on Ship 1, {1} on ship 2", ShipCost.ToString(), Ship2Cost.ToString()));

            if (Ship3Cost > 0)
            {
                Console.Write(string.Format(", {0} on ship 3", Ship3Cost.ToString()));
            }

            if (Ship4Cost > 0)
            {
                Console.Write(string.Format(", {0} on ship 4", Ship4Cost.ToString()));
            }

            if (Ship5Cost > 0)
            {
                Console.Write(string.Format(", {0} on ship 5", Ship5Cost.ToString()));
            }

            Console.Write(".");
            Console.WriteLine("");

            SpentSoFar = SpentSoFar + pointsSpent;
            SpentOnShips = pointsSpent;
        }

        public void GatherShipsForUpgrades()
        {
            Console.WriteLine("We've finished building your ships, now we're going to outfit them with upgrades.");
            ShipOutfitter shipOutfitter = new ShipOutfitter();
            ShipUpgrades = shipOutfitter.UpgradeShip(Ships);
            Random rand = new Random();

            UpgradeRandomizer = new Dictionary<string, string>();
            int i = 10;
            foreach (var UpgradeLine in ShipUpgrades)
            {
                ++i;
                UpgradeRandomizer.Add(UpgradeLine.Item1.ToString() + i, UpgradeLine.Item2);
            }

            Console.WriteLine("The Ships are gathering in the hangar - waiting to be upgraded");
            Console.WriteLine("");

            UpgradeRandomizer =
            UpgradeRandomizer.OrderBy(x => rand.Next())
                .ToDictionary(item => item.Key, item => item.Value);
            Dictionary<string, int> costDict;

            FinalList = new Dictionary<string, string>();
            foreach (var ShuffledDictionary in UpgradeRandomizer)
            {
                if (SpentSoFar < PointsBudget)
                {
                    costDict = shipOutfitter.RandomUpgrade(ShuffledDictionary.Value);

                    if (costDict.Values.First() + SpentSoFar < PointsBudget)
                    {
                        SpentSoFar = costDict.Values.First() + SpentSoFar;
                        SpentOnUpgrades = SpentOnUpgrades + costDict.Values.First();
                        FinalList.Add(ShuffledDictionary.Key.ToString(), ShuffledDictionary.Value + ":  " + costDict.Keys.First());
                    }
                }
            }
        }

        public void TellMeAboutThatList()
        {
            var sortedList = FinalList.Keys.ToList();
            sortedList.Sort();

            foreach (var key in sortedList)
            {
                string PilotName = key.Replace("ListFactory.Ships.", "");
                PilotName = PilotName.Substring(0, PilotName.Length - 2);
                Console.WriteLine("{0}, {1}", PilotName, FinalList[key]);
            }

        }

        public void CheckBudget()
        {
            Console.WriteLine("In total we have spent:");
            Console.WriteLine(string.Format("We have spent a total of {0} on ships.", SpentOnShips));
            Console.WriteLine(string.Format("We have spent a total of {0} on upgrades.", SpentOnUpgrades));
            Console.WriteLine(string.Format("We have a total of {0} left in the budget for this build.", PointsBudget - SpentSoFar));
        }
    }
}
