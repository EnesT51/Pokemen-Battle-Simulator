using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemen_Battle_Simulator
{
    public abstract class Pokemon
    {
        public string Name { get; set; }
        public string Strength { get; set; }
        public string Weakness { get; set; }

        public Pokemon(string name, string strength, string weakness) => (Name, Strength, Weakness) = (name, strength, weakness);

        public abstract void BattleCry();
    }
}
