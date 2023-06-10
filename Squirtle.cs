using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemen_Battle_Simulator
{
    public class Squirtle : Pokemon
    {
        public Squirtle(string name = "squirtle") : base(name)
        {
            this.Name = name;
            this.Strength = Attributes.Water;
            this.Weakness = Attributes.Grass;
        }

        public override void BattleCry()
        {
            Console.WriteLine($"{Name} does his Battle Cry {Name}!!!!!!");
        }
    }
}
