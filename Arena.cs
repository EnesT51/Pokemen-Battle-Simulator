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
        public static int Rounds { get; set; }

        public Battle btl = new();
        
        public void battle(Trainer Player1, Trainer Player2)
        {
            ResetValues();
            List<Pokeball> Trainer1Belt = Player1.GetBelt();
            List<Pokeball> Trainer2Belt = Player2.GetBelt();
            Random random = new Random();
            Random random1 = new Random();
            Console.WriteLine();

            do
            {
                Rounds++;
                Console.WriteLine("[--------------------[Round:{0}]--------------------]", Rounds);
                Console.WriteLine();
                int rnd1 = random.Next(0, Trainer1Belt.Count);
                int rnd2 = random1.Next(0, Trainer2Belt.Count);

                Pokemon pokemon1 = Player1.ThrowPokeBall(Trainer1Belt[rnd1]);
                Pokemon pokemon2 = Player2.ThrowPokeBall(Trainer2Belt[rnd2]);
                Console.WriteLine();

                pokemon1.BattleCry();
                pokemon2.BattleCry();
                Console.WriteLine();

                Player1.ReturnPokeBall(Trainer1Belt[rnd1]);
                Player2.ReturnPokeBall(Trainer2Belt[rnd2]);
                Console.WriteLine();

                Console.WriteLine(Battle.BattleOutCome(pokemon1, pokemon2, Trainer1Belt, Trainer2Belt));
                //Console.WriteLine("---------------------------------------");

            }
            while (Trainer1Belt.Count > 0 && Trainer2Belt.Count > 0);
            BattleResults();
        }
        private static void ResetValues()
        {
            Battle.Trainer1 = 0;
            Battle.Trainer2 = 0;
            Rounds = 0;
        }
        private static void BattleResults()
        {
            Console.WriteLine("[P1 score: {0}] [P2 score: {1}]", Battle.Trainer1, Battle.Trainer2);
            string OutCome = Battle.Trainer1 > Battle.Trainer2 ? "Winner is Trainer 1" : "Winner is Trainer 2";
            if(Battle.Trainer1 == Battle.Trainer2)
            {
                Console.WriteLine("\nThe game is finished, there is no winner. It is a Draw");
            }
            else { Console.WriteLine($"\n{OutCome}"); }
            
        }
    }
}
