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
        public Charmender ThrowPokeBall(Pokeball pokeball)
        {
            Charmender charmender = pokeball.Open();
            return charmender;
        }
        public Charmender ReturnPokeBall(Pokeball pokeball)
        {
            Charmender charmender = pokeball.Close();
            return charmender;
        }

        public void AddPokemenToBelt(string Name)
        {
            belt.Add(new Pokeball(new Charmender(Name,"Fire", "water")));
            Console.WriteLine($"{Name} Added to the pokeball");
        }
        public List<Pokeball> GetBelt()
        {
            return belt;
        }
    }
}
