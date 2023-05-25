﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Pokemen_Battle_Simulator
{
    public class Charmender : Pokemon
    {
        public string Name { get; set; }
        public string Strength { get; set; }
        public string Weakness { get; set; }

        public Charmender(string name, string strength, string weakness) : base(name, strength, weakness)
        {
            Name = name;
            Strength = strength;
            Weakness = weakness;
        }
        public override void BattleCry()
        {
            Console.WriteLine($"{Name} does his Battle Cry!!!");
        }
    }
}
