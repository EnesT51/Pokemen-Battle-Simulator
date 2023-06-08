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
            string Trainername1 = Console.ReadLine();
            Trainer Trainer1 = new Trainer(Trainername1);
            Trainer1.TrainerName = Trainername1;
            Console.WriteLine($"First Trainer name is: {Trainer1.TrainerName}");

            Console.Write("Give a name for the second trainer: ");
            string Trainername2 = Console.ReadLine();
            Trainer Trainer2 = new Trainer(Trainername2);
            Trainer2.TrainerName = Trainername2;
            Console.WriteLine($"Second Trainer name is: {Trainer2.TrainerName}");

            Trainer1.AddPokemonToBelt();
            Trainer2.AddPokemonToBelt();
            
            Arena arena = new Arena();
            arena.BattleArena(Trainer1, Trainer2);
            
            Console.WriteLine($"Do you want to start over?: Y/Any Key for Stop");
            string RepeatTheLoop = Console.ReadLine().ToUpper();
            Answer = RepeatTheLoop == "Y" ? true : false;
        }
        while(Answer);   
    }
}


