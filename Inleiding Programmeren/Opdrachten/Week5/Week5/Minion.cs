using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5
{
    class Minion
    {
        private string name;

        public Minion(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return "Minions: " + name;
        }

    }
}
