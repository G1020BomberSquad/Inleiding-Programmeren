using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Villain joker = new Villain("Joker");
            //Minion harley = new Minion("Harley Quinn");
            //Minion grundy = new Minion("Solomon");
            //joker.AddMinion(grundy);
            //joker.AddMinion(harley);

            //joker.Show();

            //Villain crocoLoco = new Villain("Killer Croc");
            //crocoLoco.AddMinion(harley);
            //crocoLoco.Show();

            student bert = new student("Bert", 18, 2000);
            bert.Print();




            Console.ReadLine();
        }
    }
}
