using System;

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
                Console.Write($"First trainer, give a name for you {count} Charmender: ");
                string name = Console.ReadLine();
                trainer.AddPokemenToBelt(name);
                Console.Write($"Second trainer, give a name for you {count} Charmender: ");
                string name2 = Console.ReadLine();
                trainer2.AddPokemenToBelt(name2);
            }
            Console.WriteLine();
            List<Pokeball> Trainer1Belt = trainer.GetBelt();
            List<Pokeball> Trainer2Belt = trainer2.GetBelt();
            for (int i = 0; i < 6; i++)
            {   
                Charmender charmender1 = trainer.ThrowPokeBall(Trainer1Belt[i]);
                charmender1.BattleCry();
                trainer.ReturnPokeBall(Trainer1Belt[i]);
                Charmender charmender2 = trainer2.ThrowPokeBall(Trainer2Belt[i]);
                charmender2.BattleCry();
                trainer2.ReturnPokeBall(Trainer2Belt[i]);
            }
            Console.WriteLine($"Do you want to give a new name: Y/Any Key for Stop");
            string RepeatTheLoop = Console.ReadLine().ToUpper();
            Answer = RepeatTheLoop == "Y" ? true : false;

        }
        while(Answer);   
    }
}


