﻿using System;
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
            if(Pokemon != null)
            {
                Console.WriteLine($"{Pokemon.Name} is released from his pokeball!!!");
            }
            else
            {
                Console.WriteLine("The pokeball is empty");
            }
            return Pokemon;
        }
        public Pokemon Close()
        {
            Console.WriteLine($"{Pokemon.Name} is returnd to his pokeball");
            return Pokemon;
        }
    }
}
