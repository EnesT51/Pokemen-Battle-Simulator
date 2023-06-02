using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemen_Battle_Simulator
{
    public class Squirtle : Pokemon
    {
        public Squirtle(string name, string strength = "water", string weakness = "leaf") : base(name, strength, weakness)
        {
            this.Name = name;
            this.Strength = strength;
            this.Weakness = weakness;
        }

        public override void BattleCry()
        {
            Console.WriteLine($"{Name} does his Battle Cry!!!");
        }
    }
}
