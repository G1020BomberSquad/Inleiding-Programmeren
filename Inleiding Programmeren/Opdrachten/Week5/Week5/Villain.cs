using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5
{
    class Villain
    {
        private string name;
        private List<Minion> minions = new List<Minion>();

        public Villain(string name)
        {
            this.name = name;
        }

        public void AddMinion(Minion minion)
        {
            minions.Add(minion);
        }

        public void Show()
        {
            Console.WriteLine("Villain: " + name);
            foreach (Minion m in minions)
            {
                Console.WriteLine(m.ToString());
            }
            Console.WriteLine();
        }
    }
}
