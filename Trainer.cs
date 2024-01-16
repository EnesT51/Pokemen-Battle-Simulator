using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Pokemen_Battle_Simulator
{
    public class Trainer 
    {
        private readonly List<Pokeball> belt;

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
            int maxlength = 6;
            Console.WriteLine("How many pokemons do you want? Be aware Trainer 1 needs equal pokemons as Trainer 2");
            string? ask = Console.ReadLine();
            int length = int.Parse(ask!);
            List<object> pokemons = new List<object> {
                new Charmender(), new Bulbasaur(), new Squirtle(),
            };
            try
            {
                if (length <= maxlength)
                {
                    for (int i = 0; i < length; i++)
                    {
                        Random r = new Random();
                        int shuffle = r.Next(0, pokemons.Count);
                        Pokemon pokemon = (Pokemon)pokemons[shuffle];
                        if (belt.Count <= 6)
                        {
                            belt.Add(new Pokeball(pokemon));
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        public List<Pokeball> GetBelt()
        {
            return belt;
        }
    }
}
