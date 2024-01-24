using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Pokemen_Battle_Simulator
{
    public class Arena
    {
        private static int Rounds { get; set; }

        private static readonly Battle btl = new();

        public static void BattleArena(Trainer T1, Trainer T2)
        {
            ResetValues();
            List<Pokeball> Trainer1Belt = T1.GetBelt();
            List<Pokeball> Trainer2Belt = T2.GetBelt();
            Random random = new();
            Console.WriteLine();
            if (Trainer1Belt.Count == Trainer2Belt.Count)
            {
                do
                {
                    Rounds++;
                    Console.WriteLine("[--------------------[Battle] [Round:{0}]--------------------]", Rounds);
                    Console.WriteLine();
                    int rnd1 = random.Next(0, Trainer1Belt.Count);
                    int rnd2 = random.Next(0, Trainer2Belt.Count);

                    Pokemon pokemon1 = Trainer.ThrowPokeBall(Trainer1Belt[rnd1]);
                    Pokemon pokemon2 = Trainer.ThrowPokeBall(Trainer2Belt[rnd2]);
                    Console.WriteLine();

                    Console.WriteLine(pokemon1.BattleCry());
                    Console.WriteLine(pokemon2.BattleCry());
                    Console.WriteLine();

                    Trainer.ReturnPokeBall(Trainer1Belt[rnd1]);
                    Trainer.ReturnPokeBall(Trainer2Belt[rnd2]);
                    Console.WriteLine();

                    Console.WriteLine(btl.BattleOutCome(pokemon1, pokemon2, Trainer1Belt, Trainer2Belt));
                }
                while (Trainer1Belt.Count > 0 && Trainer2Belt.Count > 0);
            }
            else
            {
                Console.WriteLine("The amount of pokemons are not equal. Please give same amount of pokemons to bought of the Trainers.");
            }
            
        }
        private static void ResetValues()
        {
            btl.Trainer1Score = 0;
            btl.Trainer2Score = 0;
            Rounds = 0;
        }
        public static string BattleResults(Trainer T1, Trainer T2)
        {
            Console.WriteLine("[{2} score: {0}] [{3} score: {1}]", btl.Trainer1Score, btl.Trainer2Score, T1.TrainerName, T2.TrainerName);
            string OutCome = btl.Trainer1Score > btl.Trainer2Score ? $"Winner is {T1.TrainerName}" : $"Winner is {T2.TrainerName}";
            if (btl.Trainer1Score == btl.Trainer2Score && Rounds == 0)
            {
                return "\nThe game is finished, there is no winner.";
            }
            else if (btl.Trainer1Score == btl.Trainer2Score)
            {
                return "\nThe game is finished, there is no winner. It is a Draw";
            }
            else { return $"\n{OutCome}"; }
            
        }
    }
}
