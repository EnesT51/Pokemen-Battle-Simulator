using System;

namespace Pokemen_Battle_Simulator;

class Program
{
    public static void Main(string[] args)
    {
        bool Answer = true;
        while (Answer)
        {
            Console.WriteLine("Give a name for your Charmander");
            string name = Console.ReadLine();
            Charmender Charmender = new Charmender(name, "Fire", "Water");

            Console.WriteLine($"The weakness of {Charmender.GetName()} is: {Charmender.ReturnWeakness()}, and strenth is: {Charmender.strength()}.");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{Charmender.GetName()} does his Battle Cry!!!");
            }
            Console.WriteLine($"Do you want to give a new name to {Charmender.GetName()} Y/N ?");
            string RepeatTheLoop = Console.ReadLine().ToUpper();
            Answer = RepeatTheLoop == "Y" ? true : false;
        }
    }
}


