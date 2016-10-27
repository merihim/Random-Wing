using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListFactory;


namespace Random_Wing
{
    class ListRandomizer
    {
        static void Main(string[] args)
        {
            ShipBuilder shipBuilder = new ShipBuilder();

            shipBuilder.SetPoints();
            shipBuilder.GenerateShipValues();
            shipBuilder.CheckBudget();
            shipBuilder.FindShipOfValue();
            Console.ReadLine();
        }
    }
}
