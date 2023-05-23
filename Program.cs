using System;

namespace Pokemen_Battle_Simulator;

class Program
{
    static void Main(string[] args)
    {
        bool Answer;
        do 
        {
            Charmender charmender = new Charmender("fire", "water");
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
                charmender.Name = name;
                trainer.AddPokemenToBelt(charmender.Name);
            }
            //foreach (string count in c)
            //{
            //    Console.Write($"Second trainer, give a name for you {count} Charmender: ");
            //    string name2 = Console.ReadLine();
            //    trainer2.AddPokemenToBelt(name2);
            //}

            foreach (Pokeball n in trainer.GetBelt())
            {
                Charmender charmender1 = trainer.ThrowPokeBall(n);
                charmender1.BattleCry();
                trainer.ReturnPokeBall(n);
            }

            Console.WriteLine($"Do you want to give a new name: Y/Any Key for Stop");
            string RepeatTheLoop = Console.ReadLine().ToUpper();

            Answer = RepeatTheLoop == "Y" ? true : false;
        }
        while(Answer);   
    }
}


