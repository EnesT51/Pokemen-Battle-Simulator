using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Pokemen_Battle_Simulator
{
    public class Trainer 
    {
        private List<Pokeball> belt;

        public string TrainerName { get; set; }
        public Trainer(string trainername)
        {
            TrainerName = trainername;
            this.belt = new List<Pokeball>();
        }

        // Instead of pokemon returns pokeball, move open to battle
        public Pokemon ThrowPokeBall(Pokeball pokeball)
        {
            Pokemon pokemon = pokeball.Open();
            return pokemon;
        }
        public Pokemon ReturnPokeBall(Pokeball pokeball)
        {
            Pokemon pokemon = pokeball.Close();
            return pokemon;
        }

        public void AddPokemonToBelt()
        {
            belt.Add(new Pokeball(new Charmender()));
            belt.Add(new Pokeball(new Charmender()));
            belt.Add(new Pokeball(new Bulbasaur()));
            belt.Add(new Pokeball(new Bulbasaur()));
            belt.Add(new Pokeball(new Squirtle()));
            belt.Add(new Pokeball(new Squirtle()));
        }
        public List<Pokeball> GetBelt()
        {
            return belt;
        }
    }
}
