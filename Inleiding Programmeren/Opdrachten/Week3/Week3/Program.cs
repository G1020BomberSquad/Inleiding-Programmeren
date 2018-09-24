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
            /*
            int[] getallen = new int[10];

            for (int i = 0; i < getallen.Length; i++)
            {
                getallen[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Max: " + getallen.Max());
            Console.WriteLine("Min: " + getallen.Min());

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

            string[,] chessBoard = new string[8, 8];
            */

            
            Console.WriteLine("Hoe veel getallen wilt u invoeren?");
            int invoer = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Voert u alstublieft een getal in en druk op enter. Doe dit " + invoer + " keer.");
            int[] getallen = new int[invoer];
            double totaal = 0.000;
            double gemiddelde = 0.000;

            for (int j = 0; j < getallen.Length; j++)
            {
                getallen[j] = Convert.ToInt32(Console.ReadLine());
                totaal = getallen.Sum();
            }
            gemiddelde = totaal / invoer;
            string decimalfix = string.Format("{0:N3}", gemiddelde);
            Console.WriteLine("Totaal: " + totaal);
            Console.WriteLine("Gemiddelde: " + decimalfix);



            Console.WriteLine("Hoeveel namen wilt u invoeren? Het maximum is 10.");
            int aantalNamen = Convert.ToInt32(Console.ReadLine());
            string[] mensen = new string[aantalNamen];
            List<bool> boolTellen = new List<bool>();

            int i = 0;
            string input = "";
            Console.WriteLine("Voert u alstublieft een naam in en druk op enter. Doe dit " + aantalNamen + " keer.");
                        
            do
            {
                input = Console.ReadLine();
                
                if (input == "")
                {
                    Console.WriteLine("Niks invoeren mag niet");
                }
                else if (input != "stop")
                {
                    mensen[i++] = input;
                }
            } while (input != "stop" && i<aantalNamen);

            Console.WriteLine(boolTellen.Count);








            int[,] data = new int[4, 7]
            {
                { 15, 12, 10, 8, 9, 9, 5 },
                { 6, 4, -2, -3, -5, -7, -2 },
                { 0, 1, -2, -4, -3, -8, -9 },
                { -11, -8, -5, 2, 4, 5, 1 },
            };

            for (int row = 0; row < 4; row++)
            {
                for (int column = 0; column < 7; column++)
                {
                    Console.Write(data[row, column] + "\t");
                }
                Console.WriteLine();
            }
            int week = 0;
            double sum = 0;
            for (int row = 0; row < 4; row++)
            {
                for (int column = 0; column < 7; column++)
                {
                    sum = sum + data[row, column];                     
                }
                  week++;
                  Console.WriteLine("Gemiddelde van week " + (week) + ": " + (sum / 7));
                  sum = sum - sum;
            }
            Console.ReadKey();
        }
    }
}
