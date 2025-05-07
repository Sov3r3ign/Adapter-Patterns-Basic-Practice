using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class BeastAdapter : ICreature
    {
        private AncientBeasts ancientBeasts;
        public BeastAdapter(AncientBeasts ab)
        {
            ancientBeasts = ab;
        }
        public void MakeSound()
        {
            ancientBeasts.ViolentRoar();
        }
    }
}
