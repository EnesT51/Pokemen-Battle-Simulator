using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public Pokemon ThrowPokeBall(Pokeball pokeball)
        {
            Pokemon charmender = pokeball.Open();
            return charmender;
        }
        public Pokemon ReturnPokeBall(Pokeball pokeball)
        {
            Pokemon charmender = pokeball.Close();
            return charmender;
        }

        public void AddPokemonToBelt(Pokeball pokeball)
        {
            belt.Add(pokeball);
            
        }
        public List<Pokeball> GetBelt()
        {
            return belt;
        }
    }
}
