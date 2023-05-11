using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemen_Battle_Simulator
{
    class Charmender
    {
        public string Name { get; set; }
        public string Strength { get; set; }
        public string Weakness { get; set; }

        public Charmender(string name, string strength, string weakness)
        {
            Name = name;
            Strength = strength;
            Weakness = weakness;
        }

        public string GetName()
        {
            return Name;
        }
        public void Setname(string name)
        {
            Name = name;
        }
        public void GetStrength(string strength)
        {
            Strength = strength;
        }
        public string strength()
        {
            return Strength;
        }
        public void weakness(string weakness)
        {
            Weakness = weakness;
        }
        public string ReturnWeakness()
        {
            return Weakness;
        }

    }
}
