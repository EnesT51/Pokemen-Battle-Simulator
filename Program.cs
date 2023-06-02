using System;
using System.Xml.Linq;

namespace Pokemen_Battle_Simulator;

class Program
{
    static void Main(string[] args)
    {
        bool Answer;
        do 
        {
            Console.Write("Give a name for the first trainer: ");
            string Trainername = Console.ReadLine();
            Trainer trainer = new Trainer(Trainername);
            trainer.TrainerName = Trainername;
            Console.WriteLine($"First Trainer name is: {trainer.TrainerName}");

            Console.Write("Give a name for the second trainer: ");
            string Trainername2 = Console.ReadLine();
            Trainer trainer2 = new Trainer(Trainername2);
            trainer.TrainerName = Trainername2;
            Console.WriteLine($"Second Trainer name is: {trainer2.TrainerName}");
            string[] c = { "first", "second", "third", "fourth", "fifth", "sixth" };

            foreach (string count in c)
            {
                Console.WriteLine("Which type pokemen do you want? ");
                string type = Console.ReadLine();
                Console.Write($"Give a name for you {count} Pokemon: ");
                string name = Console.ReadLine();
                if (type == "fire")
                {
                    trainer.AddPokemonToBelt(new Pokeball(new Charmender(name)));
                    trainer2.AddPokemonToBelt(new Pokeball(new Charmender(name)));
                    Console.WriteLine($"{name} Added to the pokeball");
                }
                else if (type == "water")
                {
                    trainer.AddPokemonToBelt(new Pokeball(new Bulbasaur(name)));
                    trainer2.AddPokemonToBelt(new Pokeball(new Bulbasaur(name)));
                    Console.WriteLine($"{name} Added to the pokeball");
                }
                else if (type == "grass")
                {
                    trainer.AddPokemonToBelt(new Pokeball(new Squirtle(name)));
                    trainer2.AddPokemonToBelt(new Pokeball(new Squirtle(name)));
                }
            }
            Console.WriteLine();
            List<Pokeball> Trainer1Belt = trainer.GetBelt();
            List<Pokeball> Trainer2Belt = trainer2.GetBelt();

            for (int i = 0; i < 6; i++)
            {   
                Pokemon charmender1 = trainer.ThrowPokeBall(Trainer1Belt[i]);
                charmender1.BattleCry();
                trainer.ReturnPokeBall(Trainer1Belt[i]);
                Console.WriteLine();
                Pokemon charmender2 = trainer2.ThrowPokeBall(Trainer2Belt[i]);
                charmender2.BattleCry();
                trainer2.ReturnPokeBall(Trainer2Belt[i]);
                Console.WriteLine();
            }
            Console.WriteLine($"Do you want to start over?: Y/Any Key for Stop");
            string RepeatTheLoop = Console.ReadLine().ToUpper();
            Answer = RepeatTheLoop == "Y" ? true : false;

        }
        while(Answer);   
    }
}


