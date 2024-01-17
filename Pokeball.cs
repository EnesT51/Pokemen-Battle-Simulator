using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemen_Battle_Simulator
{
    public class Pokeball
    {
        public Pokemon Pokemon { get; set; }

        public Pokeball(Pokemon pokemon) => this.Pokemon = pokemon;

        public string Open()
        {
            if(Pokemon != null)
            {
                return $"{Pokemon.Name} is released from his pokeball!!!";
            }
            else
            {
                return "The pokeball is empty";
            }

        }
        public string Close()
        {
            return $"{Pokemon.Name} is returnd to his pokeball";
        }
    }
}
