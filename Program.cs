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
            string? Trainername1 = Console.ReadLine();
            Trainer Trainer1 = new Trainer(Trainername1!);
            Trainer1.TrainerName = Trainername1!;
            Console.WriteLine($"First Trainer name is: {Trainer1.TrainerName}");
            Console.Write("Give a name for the second trainer: ");
            string? Trainername2 = Console.ReadLine();
            Trainer Trainer2 = new Trainer(Trainername2!);
            Trainer2.TrainerName = Trainername2!;
            Console.WriteLine($"Second Trainer name is: {Trainer2.TrainerName}");
            try
            {
                Trainer1.AddPokemonToBelt();
                Trainer2.AddPokemonToBelt();

                Arena.BattleArena(Trainer1, Trainer2);
                Arena.BattleResults(Trainer1, Trainer2);
            }
            catch{ Console.WriteLine("The reason it didn't work could be due to either entering too many Pokémon in the belt, having no Pokémon in the belt, or having an unequal number of Pokémon in the belt. Please try again."); }
            
            Console.WriteLine($"Do you want to start over?: Y/Any Key for Stop");
            string? RepeatTheLoop = Console.ReadLine()?.ToUpper();
            Answer = RepeatTheLoop == "Y" ? true : false;
        }
        while(Answer);   
    }
}


