using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemen_Battle_Simulator
{
    public sealed class Pokeball
    {
        public readonly Pokemon Pokemon;

        public Pokeball(Pokemon pokemon) => this.Pokemon = pokemon;

        public Pokemon Open()
        {
            Pokemon poke = Pokemon;
            if(poke != null)
            {
                Console.WriteLine($"{poke.Name} is released from his pokeball!!!");
            }
            else
            {
                Console.WriteLine("The pokeball is empty");
            }
            return poke!;
        }
        public Pokemon Close()
        {
            Pokemon poke = Pokemon;
            Console.WriteLine($"{poke.Name} is returnd to his pokeball");
            return poke;
        }
    }
}
