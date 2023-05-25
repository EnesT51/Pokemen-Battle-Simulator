using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemen_Battle_Simulator
{
    public class Pokeball
    {
        private readonly Charmender charmender;
        public Pokeball(Charmender charmender) 
        {
            this.charmender = charmender;
        }
        public Charmender Open()
        {
            if(charmender != null)
            {
                Console.WriteLine($"{charmender.Name} is released!!!");
            }
            else
            {
                Console.WriteLine("The pokeball is empty");
            }
            return charmender;
        }
        public Charmender Close()
        {
            Console.WriteLine($"{charmender.Name} is returnd to his pokeball");
            return charmender;
        }
    }
}
