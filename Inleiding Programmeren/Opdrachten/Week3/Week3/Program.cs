using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] getallen = new int[10];

            //for (int i = 0; i < getallen.Length; i++)
            //{
            //    getallen[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //Console.WriteLine("Max: " + getallen.Max());
            //Console.WriteLine("Min: " + getallen.Min());

            List<double> doubles = new List<double>();
            doubles.Add(42.0); // index 0
            doubles.Add(4.0); // index 1
            doubles.Add(3.14); // index 2
            doubles.RemoveAt(1); // index 1 gaat weg en index 2 (3.14) gaat naar de plek van index 1.
            doubles.Insert(0, 2.13); // 2,13 wordt nu op index 0 gezet en alles schuift 1 op.
            doubles.Add(Math.PI);

            for (int i = 0; i < doubles.Count; i++) // de ene manier > moeilijker
            {
                Console.WriteLine(doubles[i]);
            }

            Console.ReadLine();

            foreach (double cijfers in doubles) // de andere manier > makkelijker // foreach is handig bij lijsten
            {
                Console.WriteLine(cijfers);
            }

            Dictionary<string, bool> isStillAlive = new Dictionary<string, bool>();

            isStillAlive.Add("Pieter", true);
            isStillAlive.Add("Ruurd", false);

            foreach (KeyValuePair<string, bool> person in isStillAlive)
            {
                if (true)
                {
                    Console.WriteLine(person.Key);
                }
            }

            Dictionary<string, int> loot = new Dictionary<string, int>();

            loot.Add("goudstaven", 100);
            loot.Add("kanonkogels", 4);


            foreach (KeyValuePair<string, int> paar in loot)
            {
                if (true)
                {
                    Console.WriteLine(paar.Key + ": " + string);
                }
            }


            Console.ReadKey();
        }
    }
}
