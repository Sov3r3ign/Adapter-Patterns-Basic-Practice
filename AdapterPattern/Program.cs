﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            World wd = new World();
            ICreature roar = new BeastAdapter(new AncientBeasts());
            roar.MakeSound();
            Console.WriteLine();
            wd.NewBeast(roar);

            Console.ReadLine();
        }
    }
}
