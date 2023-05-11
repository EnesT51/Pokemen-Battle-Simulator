using System;
using System.Security.Cryptography.X509Certificates;

namespace BattleSimulator;

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

class Charmender
{
    public string Name { get; set; }
    public string Strength { get; set; }
    public string Weakness { get; set; }

    public Charmender(string name, string strength, string weakness)
    {
        Name = name;
        Strength = strength;
        Weakness = weakness;
    }

    public string GetName()
    {
        return Name;
    }
    public void Setname(string name)
    {
        Name = name;
    }
    public void GetStrength(string strength)
    {
        Strength = strength;
    }
    public string strength()
    {
        return Strength;
    }
    public void weakness(string weakness)
    {
        Weakness = weakness;
    }
    public string ReturnWeakness()
    {
        return Weakness;
    }

}
