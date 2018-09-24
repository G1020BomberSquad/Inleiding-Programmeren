using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week4
{
    class Program
    {
        //static Dictionary<string, int> music = new Dictionary<string, int>();

        //static void Main(string[] args)
        //{
        //    CreateMusic();

        //    Console.WriteLine("Please give a year");
        //    int year = Convert.ToInt32(Console.ReadLine());

        //    DisplayMusic(year);
        //    DisplayMusic(year + 1);

        //    Console.WriteLine("=================================");

        //    DisplayMusic(2000, 2021);

        //    Console.WriteLine("Gemiddelde productiejaar is: " + AverageYear());

        //    Console.ReadKey();
        //}

        ///// <summary>
        ///// fills the dictionary with music
        ///// </summary>
        //public static void CreateMusic()
        //{
        //    music.Add("Test, Test4", 2018);
        //    music.Add("Test2, Test4", 2010);
        //    music.Add("Test3, Test4", 2005);
        //    music.Add("Test4, Test4", 2020);
        //}

        ///// <summary>
        ///// Shows music from a specific year
        ///// </summary>
        ///// <param name="jaar">The year we show music from</param>
        //public static void DisplayMusic(int jaar)
        //{
        //    foreach (KeyValuePair<string, int> song in music)
        //    {
        //        if (song.Value == jaar)
        //        {
        //            Console.WriteLine(song.Key);
        //        }
        //    }
        //}

        ///// <summary>
        ///// Calculates the average productionyear
        ///// </summary>
        ///// <returns>Average production year</returns>
        //public static double AverageYear()
        //{
        //    int sum = 0, aantal = 0;
        //    foreach (KeyValuePair<string, int> song in music)
        //    {
        //        sum += song.Value;
        //    }
        //    double average = sum / (double)aantal;

        //    return average;
        //}

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="startJaar"></param>
        ///// <param name="eindJaar"></param>
        //public static void DisplayMusic(int startJaar, int eindJaar)
        //{
        //    foreach (KeyValuePair<string, int> song in music)
        //    {
        //        if (song.Value >= startJaar && song.Value <= eindJaar)
        //        {
        //            Console.WriteLine(song.Key);
        //        }
        //    }
        //}



        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("Geef je invoer: ");
            string input = Console.ReadLine();

            #region code opdracht A
            if (input.Length % 2 == 0)
            {
                p.MiddelsteLetterEvenOne(input);
                p.MiddelsteLetterEvenTwo(input);
            }

            else
            {
                p.MiddelsteLetterOneven(input);
            }
            Console.ReadLine();
            #endregion

            #region code opdracht B
            Console.WriteLine("Geef je invoer (eerst een string, dan druk je op enter, en dan voer je een getal in: ");
            string input2 = Console.ReadLine();
            int cijfer = Convert.ToInt32(Console.ReadLine());
            p.LetterOpIndex(input2, cijfer);
            Console.ReadLine();
            #endregion

            #region code Opdracht C

            Console.WriteLine("Geef invoer");
            string input3 = Console.ReadLine();

            p.AantalWoorden("Dit zijn 4 woorden");


            #endregion

            Console.ReadKey();

            
        }
        /// <summary>
        /// Calculates the letter in the middle (on the left) if the string.Length is even
        /// </summary>
        /// <param name="tekst"></param>
        /// <returns></returns>
        public string MiddelsteLetterEvenOne(string tekst)
        {
            int aantalLettersE = tekst.Length;
            int gemiddeldeE = (aantalLettersE / 2) - 1;
            string middelsteE = Convert.ToString(tekst[gemiddeldeE]);
            Console.WriteLine("De middelste letter (links) is: " + middelsteE);

            return (middelsteE);
        }

        /// <summary>
        /// Calculates the letter in the middle (on the right) if the string.Length is even
        /// </summary>
        /// <param name="tekst"></param>
        /// <returns></returns>
        public string MiddelsteLetterEvenTwo(string tekst)
        {
            int aantalLettersE = tekst.Length;
            int gemiddeldeE = (aantalLettersE / 2);
            string middelsteE = Convert.ToString(tekst[gemiddeldeE]);
            Console.WriteLine("De middelste letter (rechts) is: " + middelsteE);
           
            return (middelsteE);
        }

        /// <summary>
        /// Calculates the letter in the middle if the string.Length is uneven
        /// </summary>
        /// <param name="tekst"></param>
        /// <returns>de middelste letter</returns>
        public string MiddelsteLetterOneven(string tekst)
        {
            int aantalLettersO = tekst.Length;
            int gemiddeldeO = (aantalLettersO / 2);
            string middelsteO = Convert.ToString(tekst[gemiddeldeO]);
            Console.WriteLine("De middelste letter is: " + middelsteO);

            return (middelsteO);
        }

        /// <summary>
        /// Grab the letter from the string that the user specified
        /// </summary>
        /// <param name="tekst"></param>
        /// <param name="index"></param>
        /// <returns>the letter that the user specified</returns>
        public char LetterOpIndex(string tekst, int index)
        {
            if (index < 0)
            {
                index = 0;
            }
            else if (index > tekst.Length)
            {
                index = tekst.Length;
            }
            int steLetter = index;
            if (steLetter == 0)
            {
                steLetter++;
            }
            char Letter = tekst[steLetter - 1];
            Console.WriteLine("Letter nummer " + steLetter + " is: " + Letter);

            return (Letter);
        }

        public void AantalWoorden(string tekst)
        {
            string invoer;
            invoer = tekst;
            int woordCount = 0;
            int index = 0;

            // nu nog kijken hoeveel woorden er zijn
            // https://stackoverflow.com/questions/8784517/counting-number-of-words-in-c-sharp
            Console.WriteLine("De string '" + invoer + "' bevat " + woordCount + " woorden.");
        }
    }
}