using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListFactory
{
    public class ListBuilder
    {
        public int ShipCost { get; set; }

        public int Ship2Cost { get; set; }

        public int Ship3Cost { get; set; }

        public int Ship4Cost { get; set; }

        public int Ship5Cost { get; set; }

        public string Ship1Name { get; set; }

        public string Ship2Name { get; set; }

        public string Ship3Name { get; set; }

        public string Ship4Name { get; set; }

        public string Ship5Name { get; set; }
    }

    public class RandomizerHelper
    {
        public IEnumerable<TKey> RandomValues<TKey, TValue>(IDictionary<TKey, TValue> dict, int value)
        {
            var pruned = dict.Where(entry => Convert.ToInt64(entry.Value) ==
                Convert.ToInt64(value)).ToDictionary(entry => entry.Key,
                entry => entry.Value);

            Random rand = new Random();
            List<TKey> values = Enumerable.ToList(pruned.Keys);
            int size = pruned.Count;
            while (true)
            {
                int debugValue = value;
                yield return values[rand.Next(size)];
            }
        }

        public IEnumerable<TKey> RandomValues<TKey, TValue>(IDictionary<TKey, TValue> dict)
        {
            Random rand = new Random();
            List<TKey> values = Enumerable.ToList(dict.Keys);
            int size = dict.Count;
            while (true)
            {
                yield return values[rand.Next(size)];
            }
        }
    }
}