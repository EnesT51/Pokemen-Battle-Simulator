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

            trainer.AddPokemonToBelt();
            trainer2.AddPokemonToBelt();
            
            Arena arena = new Arena();
            arena.battle(trainer, trainer2);
            
            Console.WriteLine($"Do you want to start over?: Y/Any Key for Stop");
            string RepeatTheLoop = Console.ReadLine().ToUpper();
            Answer = RepeatTheLoop == "Y" ? true : false;

        }
        while(Answer);   
    }
}


