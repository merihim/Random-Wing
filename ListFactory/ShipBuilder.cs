using ListFactory.Ships;
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

        int[] numbers {get; set; }
        public int[] Scum = new[] { 12, 13, 14, 15, 16, 17, 18, 19, 20, 22, 23, 24, 25, 26, 27, 28, 29, 20, 31, 33, 34, 35, 36, 37, 38, 39 };
        public int[] Rebels = new[] { 12, 13, 14, 15, 16, 17, 18, 19, 20, 22, 23, 24, 25, 26, 27, 28, 29, 20, 31, 33, 34, 35, 36, 37, 38, 39 };
        public int[] Imperials = new[] { 12, 13, 14, 15, 16, 17, 18, 19, 20, 22, 23, 24, 25, 26, 27, 28 ,29, 20, 31, 33, 34, 35, 36, 37, 38, 39 };

        public Dictionary<Type, string> Ships { get; set; }
        public List<Tuple<Type, string, string>> ShipUpgrades { get; set; }
        public Dictionary<string, string> UpgradeRandomizer { get; set; }
        public Dictionary<string, string> FinalList { get; set; }

        public void ChooseFaction()
        {
            Console.Write("Please choose a faction Scum/Rebels/Imperials: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "Imperials":
                    CurrentFaction = "Imperial";
                    numbers = Imperials;
                    Console.WriteLine("You chose the valiant Imperials");
                    break;
                case "I":
                    numbers = Imperials;
                    CurrentFaction = "Imperial";
                    Console.WriteLine("You chose the valiant Imperials");
                    break;
                case "i":
                    numbers = Imperials;
                    CurrentFaction = "Imperial";
                    Console.WriteLine("You chose the valiant Imperials");
                    break;
                case "imperials":
                    numbers = Imperials;
                    CurrentFaction = "Imperial";
                    Console.WriteLine("You chose the valiant Imperials");
                    break;
                case "Rebels":
                    numbers = Rebels;
                    CurrentFaction = "Rebels";
                    Console.WriteLine("You chose the valiant Imperials");
                    break;
                case "Rebel":
                    numbers = Rebels;
                    CurrentFaction = "Rebels";
                    Console.WriteLine("You chose the dastardly Rebels");
                    break;
                case "rebels":
                    numbers = Rebels;
                    CurrentFaction = "Rebels";
                    Console.WriteLine("You chose the dastardly Rebels");
                    break;
                case "rebel":
                    numbers = Rebels;
                    CurrentFaction = "Rebels";
                    Console.WriteLine("You chose the dastardly Rebels");
                    break;
                case "R":
                    numbers = Rebels;
                    CurrentFaction = "Rebels";
                    Console.WriteLine("You chose the dastardly Rebels");
                    break;
                case "r":
                    numbers = Rebels;
                    CurrentFaction = "Rebels";
                    Console.WriteLine("You chose the dastardly Rebels");
                    break;
                case "Scum":
                    numbers = Scum;
                    CurrentFaction = "Scum";
                    Console.WriteLine("You chose the handsome Bounty Hunters");
                    break;
                case "Best Faction":
                    numbers = Scum;
                    CurrentFaction = "Scum";
                    Console.WriteLine("You chose the handsome Bounty Hunters");
                    break;
                case "Scub":
                    numbers = Scum;
                    CurrentFaction = "Scum";
                    Console.WriteLine("You chose the handsome Bounty Hunters");
                    break;
                case "the only faction that matters":
                    numbers = Scum;
                    CurrentFaction = "Scum";
                    Console.WriteLine("You chose the handsome Bounty Hunters");
                    break;
                case "duh":
                    numbers = Scum;
                    CurrentFaction = "Scum";
                    Console.WriteLine("You chose the handsome Bounty Hunters");
                    break;
                case "S":
                    numbers = Scum;
                    CurrentFaction = "Scum";
                    Console.WriteLine("You chose the handsome Bounty Hunters");
                    break;
                case "s":
                    numbers = Scum;
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
        public void GenerateShipValues()
        {
            int shipAudit = 0;
            int pointsSpent = 0;
            Random r = new Random();
            if (pointsSpent < ShipBudget)
            {
                ShipCost = numbers.OrderBy(n => Guid.NewGuid()).ToArray().First();
                pointsSpent = pointsSpent + ShipCost;
            }

            if (pointsSpent < ShipBudget)
            {
                Ship2Cost = numbers.OrderBy(n => Guid.NewGuid()).ToArray().First();
                pointsSpent = pointsSpent + Ship2Cost;
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

        public void FindShipOfValue()
        {
            RandomizerHelper randomDictionary = new RandomizerHelper();
            DictionaryStorage listOfShips = new DictionaryStorage();
            Dictionary<Type, int> dict = listOfShips.ScumShips;
            Ships = new Dictionary<Type, string>();
            foreach (var something in randomDictionary.RandomValues(dict, ShipCost).Take(1))
            {
                Ship1Name = something.ToString();
                Ships.Add(something, Ship1Name);
            }

            dict = listOfShips.ScumShips;
            foreach (var something in randomDictionary.RandomValues(dict, Ship2Cost).Take(1))
            {
                Ship2Name = something.ToString();
                Ships.Add(something, Ship2Name);
            }

            dict = listOfShips.ScumShips;
            if (Ship3Cost > 0)
            {
                foreach (var something in randomDictionary.RandomValues(dict, Ship3Cost).Take(1))
                {
                    Ship3Name = something.ToString();
                    Ships.Add(something, Ship3Name);
                }
            }

            dict = listOfShips.ScumShips;
            if (Ship4Cost > 0)
            {
                foreach (var something in randomDictionary.RandomValues(dict, Ship4Cost).Take(1))
                {
                    Ship4Name = something.ToString();
                    Ships.Add(something, Ship4Name);
                }
            }

            dict = listOfShips.ScumShips;
            if (Ship5Cost > 0)
            {
                foreach (var something in randomDictionary.RandomValues(dict, Ship5Cost).Take(1))
                {
                    Ship5Name = something.ToString();
                    Ships.Add(something, Ship4Name);
                }
            }
        }

        public void GatherShipsForUpgrades()
        {
            Console.WriteLine("We've finished building your ships, now we're going to outfit them with upgrades.");
            ShipOutfitter shipOutfitter = new ShipOutfitter();
            ShipUpgrades = shipOutfitter.UpgradeShip(Ships);
            Random rand = new Random();

            UpgradeRandomizer = new Dictionary<string, string>();
            int i = 0;
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
                PilotName = Regex.Replace(PilotName, "[0-9]", "");
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
