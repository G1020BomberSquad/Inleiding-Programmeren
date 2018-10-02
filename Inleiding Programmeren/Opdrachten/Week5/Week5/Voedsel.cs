using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5
{
    class Voedsel
    {
        private string beschrijving;
        private int kosten;

        public Voedsel(string description, int costs)
        {
            this.beschrijving = description;
            this.kosten = costs;
        }

        public string GetBeschrijving()
        {
            Console.WriteLine("Voer een beschrijving in");
            beschrijving = Console.ReadLine();
            return beschrijving;
        }

        public int GetKosten()
        {
            Console.WriteLine("Voer de kosten in");
            kosten = Convert.ToInt32(Console.ReadLine());
            return (kosten);
        }
    }
}
