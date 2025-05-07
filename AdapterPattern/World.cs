using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class World
    {
        public void NewBeast(ICreature creature)
        {
            Console.WriteLine("A new beast encroaches upon the world.");
            creature.MakeSound();
        }
    }
}
