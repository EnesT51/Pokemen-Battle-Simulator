using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Pokemen_Battle_Simulator
{
    public class Charmender
    {
        private string _Name;
        private string _Strength;
        private string _Weakness;

        public string Name { get { return _Name; } set { _Name = value; } }
        public string Strength { get { return _Strength; } set { _Strength = value; } }
        public string Weakness { get { return _Weakness; } set { _Weakness = value; } }

        public Charmender(string name, string strength, string weakness)
        {
            Name = name;
            Strength = strength;
            Weakness = weakness;
        }

        public Charmender(string strength, string weakness)
        {
            Strength = strength;
            Weakness = weakness;
        }
        public void BattleCry()
        {
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine($"{Name} does his Battle Cry!!!");
            }
            
        }
    }
}
