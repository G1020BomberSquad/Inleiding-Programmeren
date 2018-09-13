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
                /*
                Console.WriteLine("hello!");
                Console.ReadKey();

                int i = 0;
                for (; i < 5; i++)
                {
                    Console.WriteLine("Harry Potter!" + i);

                }
                Console.WriteLine("TELLER = " + i);
                bool stopIngetoetst = false;
                int count = i;
                while (!stopIngetoetst) 
                {
                    Console.WriteLine("Hagrid" + count);
                    count++;

                    if (Console.ReadLine() == "stop")
                    {
                        stopIngetoetst = true;
                    }
                }

                int pincode;
                do
                {
                    Console.WriteLine("Geef pincode");
                    pincode = Convert.ToInt32(Console.ReadLine());
                } while (pincode != 1234);
                {
                    if (pincode == 1234)
                    {
                        Console.WriteLine("U broke m8.");
                    }
                    */

                // opdracht A

                /*
               int macht = 1;
               for (; macht < 11; macht++)
               {
                   Console.WriteLine((Math.Pow(2, macht)));
               }

                   Console.ReadKey();
                   Console.WriteLine();

                   int macht2 = 1;
               while (macht2 < 11)
                   {
                       Console.WriteLine((Math.Pow(2, macht2)));
                       macht2++;
                   }
                   Console.ReadKey();
                   Console.WriteLine();

                   int macht3 = 1;
               do
                   {
                       Console.WriteLine((Math.Pow(2, macht3)));
                       macht3++;
                   } while (macht3 < 11);

                   int invoer;
                   int max = 0;
               for (int i = 0; i < 5; i++)
                   {
                       Console.WriteLine("Geef een geheel getal.");
                       invoer = Convert.ToInt32(Console.ReadLine());
                       if (invoer > max)
                       {
                           max = invoer;
                       }
                   }
                   Console.WriteLine(max);
                   */

                // opdracht b
                /*
                int fibn = 0;
                int fib0 = 0;
                int fib1 = 1;
                for (int i = 0; i < 15; i++)
                {
                    fibn = (fib0 + fib1);
                    Console.WriteLine(fibn);
                    fib0 = fib1;
                    fib1 = fibn;

                }
                */

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
                    Console.WriteLine("U heeft in totaal " + (uitkeren - inzet) + " winst gemaakt!");
                }
                //  Console.ReadKey();
            }
        }
    }
}
