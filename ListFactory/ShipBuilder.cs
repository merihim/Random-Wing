using ListFactory.Ships;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
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

        public Dictionary<Type, string> Ships { get; set;}

        public void SetPoints()
        {
            Console.WriteLine("How many points for this project?");
            try
            {
                PointsBudget = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Was not a valid point number");
            }

           Console.WriteLine("How many points do we spend on ships?  Type 'RANDOM' or 'R' if you want a random value to be input.");
           Console.WriteLine("WARNING: Due to the truly random nature of this program, you may end up with more or less ship points (to a max of the lowest cost ship).");
           string shipCost = Console.ReadLine();
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
                ShipCost = r.Next(12, 39);
                pointsSpent = pointsSpent + ShipCost;
            }

            if (pointsSpent < ShipBudget)
            {
                Ship2Cost = r.Next(12, 39);
                pointsSpent = pointsSpent + Ship2Cost;
            }

            if (pointsSpent < ShipBudget)
            {
                if (pointsSpent < ShipBudget - 5)
                {
                    shipAudit = r.Next(12, 39);
                    while (shipAudit + pointsSpent > ShipBudget + 5)
                    {
                        shipAudit = r.Next(12, 39);
                    }

                    Ship3Cost = shipAudit;
                    pointsSpent = pointsSpent + Ship3Cost;
                }
            }

            if (pointsSpent < ShipBudget)
            {
                if (pointsSpent < ShipBudget - 12)
                {
                    shipAudit = r.Next(12, 39);
                    while (shipAudit + pointsSpent > ShipBudget + 5)
                    {
                        shipAudit = r.Next(12, 39);
                    }

                    Ship4Cost = shipAudit;
                    pointsSpent = pointsSpent + Ship4Cost;
                }
            }

            if (pointsSpent < ShipBudget)
            {
                if (pointsSpent < ShipBudget - 12)
                {
                    shipAudit = r.Next(12, 39);
                    while (shipAudit + pointsSpent > ShipBudget + 5)
                    {
                        shipAudit = r.Next(12, 39);
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
            
            foreach (string ship in Ships.Values)
            {
                Console.WriteLine(ship);
            }
        }

        public void UpgradeShips()
        {
            foreach (Type shipBase in Ships.Keys)
            {
                UpgradeLooper loop = new UpgradeLooper();

                object T = Activator.CreateInstance(shipBase);
                loop.ListOfProp<T>();
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
