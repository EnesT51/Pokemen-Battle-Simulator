using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Pokemen_Battle_Simulator
{
    public class Charmender : Pokemon
    {
        public Charmender(string name = "charmander") : base(name)
        {
            this.Name = name;
            this.Strength = Attributes.Fire;
            this.Weakness = Attributes.Water;
        }
        public override string BattleCry()
        {
            return $"{Name} does his Battle Cry {Name} !!!!!!";
        }
    }
}
