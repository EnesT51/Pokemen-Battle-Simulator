using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemen_Battle_Simulator
{
    public abstract class Squirtle : Pokemon
    {
        public Squirtle(string name, string strength, string weakness) : base(name, strength, weakness)
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
