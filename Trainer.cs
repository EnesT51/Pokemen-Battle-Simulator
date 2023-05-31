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

        public void AddPokemenToBelt(string Name, string type)
        {
            if(type == "fire")
            {
                belt.Add(new Pokeball(new Charmender(Name, type, "water")));
            }
            else if (type == "water")
            {
                belt.Add(new Pokeball(new Squirtle(Name, type, "leaf")));
            }
            else
            {
                belt.Add(new Pokeball(new Bulbasaur(Name, type, "fire")));
            }
            Console.WriteLine($"{Name} Added to the pokeball");
        }
        public List<Pokeball> GetBelt()
        {
            return belt;
        }
    }
}
