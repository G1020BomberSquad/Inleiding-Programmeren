using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int inzet = 0;
                do
                {
                    Console.WriteLine("Geef uw inzet tussen 5 en 100 euro.");
                    string value = Console.ReadLine();
                    try
                    {
                        inzet = Convert.ToInt32(value);
                        Console.WriteLine("Converted the {0} value '{1}' to the {2} value {3}.",
                                          value.GetType().Name, value, inzet.GetType().Name, inzet);
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("{0} is outside the range of the Int32 type.", value);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("The {0} value '{1}' is not in a recognizable format.",
                                          value.GetType().Name, value);
                    }
                    if ((inzet < 5 || inzet > 100))
                    {
                        Console.WriteLine("Verkeerde waarde, probeer opnieuw");
                    }
                }
                while (inzet < 5 || inzet > 100);

                Console.WriteLine("Juiste waarde");
                int multiplier = 0;
                int totaal6 = 0;
                for (int worp = 0; worp < 4; worp++)
                {
                    Random rnd = new Random();
                    int dice1 = rnd.Next(1, 7);
                    int dice2 = rnd.Next(1, 7);
                    Console.WriteLine("U heeft " + dice1 + " en " + dice2 + " gegooid!");
                    System.Threading.Thread.Sleep(333);

                    if ((dice1 == 6) && (dice2 == 6))
                    {
                        multiplier = multiplier + 50;
                    }
                    if (dice1 == dice2)
                    {
                        multiplier = multiplier + 10;
                    }
                    if ((dice1 == 1) && (dice2 == 1))
                    {
                        multiplier = multiplier - multiplier;
                    }
                    if ((dice1 == 6) || (dice2 == 6) && (totaal6 < 4))
                    {
                        totaal6 = totaal6 + 1;

                    }
                    if (totaal6 == 4)
                    {
                        multiplier = multiplier + 2;
                    }
                }
                int uitkeren = (inzet * multiplier);
                Console.WriteLine("Er wordt " + uitkeren + " euro uitgekeerd.");
                if ((uitkeren < inzet))
                {
                    Console.WriteLine("U heeft " + (inzet) + " euro verloren.");
                }
                else
                {
                    Console.WriteLine("U heeft in totaal " + (uitkeren - inzet) + " euro winst gemaakt!");
                }
                Console.ReadKey();
            }
        }
    }
}