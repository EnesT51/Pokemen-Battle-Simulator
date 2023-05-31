using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemen_Battle_Simulator
{
    public class Pokeball
    {
        public Pokemon pokemon { get; set; }

        public Pokeball(Pokemon pokemon) => this.pokemon = pokemon;

        public Pokemon Open()
        {
            if(pokemon != null)
            {
                Console.WriteLine($"{pokemon.Name} is released!!!");
            }
            else
            {
                Console.WriteLine("The pokeball is empty");
            }
            return pokemon;
        }
        public Pokemon Close()
        {
            Console.WriteLine($"{pokemon.Name} is returnd to his pokeball");
            return pokemon;
        }
    }
}
