using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemen_Battle_Simulator
{
    public abstract class Pokemon
    {
        public enum Attributes
        {
            Fire,
            Water,
            Grass
        }
        public string Name { get; set; }
        public Attributes Strength { get; set; }
        public Attributes Weakness { get; set; }

        public Pokemon(string name) => (Name) = (name);

        public abstract string BattleCry();
    }
}
