using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5
{
    class student
    {
        /// <summary>
        /// initalises student
        /// </summary>
        private string naam;
        private int leeftijd;
        private int maandBudget;
        private bool iq;

        /// <summary>
        /// Constructs the student
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="budget"></param>
        public student(string name, int age, int budget)
        {
            this.naam = name;
            this.leeftijd = age;
            this.maandBudget = budget;
        }

        private List<Voedsel> voedsel = new List<Voedsel>();

        public void AddVoedsel(Voedsel kosten, Voedsel bescrijving)
        {
            voedsel.Add(bescrijving);
            voedsel.Add(kosten);
        }

        private bool IkMaakWinst()
        {
            int totaal = 0;
            bool iq = true;
            foreach (int duur in voedsel)
            {
                totaal = totaal + duur;
            } 

            if (totaal > maandBudget)
            {
                iq = true;
            }
            else if (totaal < maandBudget)
            {
                iq = false;
            }
            return (iq);
        }

        /// <summary>
        /// Prints student
        /// </summary>
        public void Print()
        {
            Console.WriteLine("====================");
            Console.WriteLine("Naam: " + naam);
            Console.WriteLine("====================");
            Console.WriteLine("Leeftijd: " + leeftijd);
            Console.WriteLine("====================");
            Console.WriteLine("Maandbudget: " + maandBudget);
            Console.WriteLine("====================");
            if (iq == false)
            {
                Console.WriteLine("Stom");
            }
            else if (iq == true)
            {
                Console.WriteLine("Slim");
            }
        }
    }
}
