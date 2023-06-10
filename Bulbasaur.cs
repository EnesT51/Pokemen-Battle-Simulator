using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemen_Battle_Simulator
{
    public class Bulbasaur : Pokemon
    {
        public Bulbasaur(string name = "bulbasaur") : base(name)
        {
            this.Name = name;
            this.Strength = Attributes.Grass;
            this.Weakness = Attributes.Fire;
        }
        public override void BattleCry()
        {
            Console.WriteLine($"{Name} does his Battle Cry {Name} !!!!!!");
        }
    }
}
