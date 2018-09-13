using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1
{
    class Program
    {
        static void Main(string[] args)
        {
            // opdracht 1A
            string name = ("Johan");
            Console.WriteLine("Hello " + name + " !");
            Console.WriteLine("Druk op Enter");
            Console.ReadLine();

            // opdracht 1B
            Console.Clear();
            char letter3 = 'C';
            int nummer1 = 123;
            double nummer2 = 1.5;
            bool nee = false;

            
            Console.WriteLine(letter3 + " " + nummer1);
            Console.WriteLine(nummer2 + " " + nee);
            Console.ReadLine();

            Console.WriteLine(nummer1 % nummer2);
            Console.ReadLine();
            
            // opdracht 1C
            Console.Clear();

            Console.WriteLine("Geef een temperatuur in Celsius.");
            int temp = Convert.ToInt32 (Console.ReadLine());
            Console.Write("De temperatuur is " + ((temp * 1.8) + 32) + " F!");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Geef de waarde in euro.");
            int euros = Convert.ToInt32(Console.ReadLine());
            Console.Write(euros + " euro = " + (euros * 1.16) + " dollar!");
            Console.ReadLine();

            // opdracht 1D
            Console.Clear();
            
            Console.WriteLine("Ben je een man, vrouw, of iets anders?");
            string text = Console.ReadLine();
            if (text.Contains("Man"))
            {
                Console.WriteLine("Wat is uw lichaamslengte?");
                int lengte = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Uw ideale gewicht is " + ((lengte - 100) * 0.9) + " KG!");
            }
            else if (text.Contains("Vrouw"))
            {
                Console.WriteLine("Wat is uw lichaamslengte?");
                int lengte = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Wat is uw polsomtrek");
                int polsomtrek = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Uw ideale gewicht is " + ((lengte + (4 * polsomtrek) - 100) / 2) + " KG!");
            }
            else
            {
                Console.WriteLine("Please visit this link: https://www.theodysseyonline.com/there-are-only-two-genders"); 
            };
             

            Console.WriteLine("Have a nice day!");
            Console.ReadLine();

        }
    }
}
