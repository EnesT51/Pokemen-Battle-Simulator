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

        private readonly Battle btl = new();
        
        public void BattleArena(Trainer T1, Trainer T2)
        {
            ResetValues();
            List<Pokeball> Trainer1Belt = T1.GetBelt();
            List<Pokeball> Trainer2Belt = T2.GetBelt();
            Random random = new();
            Console.WriteLine();
            do
            {
                Rounds++;
                Console.WriteLine("[--------------------[Battle] [Round:{0}]--------------------]", Rounds);
                Console.WriteLine();
                int rnd1 = random.Next(0, Trainer1Belt.Count);
                int rnd2 = random.Next(0, Trainer2Belt.Count);

                Pokemon pokemon1 = T1.ThrowPokeBall(Trainer1Belt[rnd1]);
                Pokemon pokemon2 = T2.ThrowPokeBall(Trainer2Belt[rnd2]);
                Console.WriteLine();

                pokemon1.BattleCry();
                pokemon2.BattleCry();
                Console.WriteLine();
                
                T1.ReturnPokeBall(Trainer1Belt[rnd1]);
                T2.ReturnPokeBall(Trainer2Belt[rnd2]);
                Console.WriteLine();

                Console.WriteLine(btl.BattleOutCome(pokemon1, pokemon2, Trainer1Belt, Trainer2Belt));
            }
            while (Trainer1Belt.Count > 0 && Trainer2Belt.Count > 0);
            
        }
        private void ResetValues()
        {
            btl.Trainer1 = 0;
            btl.Trainer2 = 0;
            Rounds = 0;
        }
        public void BattleResults(Trainer T1, Trainer T2)
        {
            Console.WriteLine("[P1 score: {0}] [P2 score: {1}]", btl.Trainer1, btl.Trainer2);
            string OutCome = btl.Trainer1 > btl.Trainer2 ? $"Winner is {T1.TrainerName}" : $"Winner is {T2.TrainerName}";
            if(btl.Trainer1 == btl.Trainer2)
            {
                Console.WriteLine("\nThe game is finished, there is no winner. It is a Draw");
            }
            else { Console.WriteLine($"\n{OutCome}"); }
            
        }
    }
}
