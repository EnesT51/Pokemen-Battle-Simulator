using System;
using System.Collections.Generic;
using System.Linq;
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

            for(int i = 0; i < 6; i ++)
            {
                
                Rounds++;
                Console.WriteLine($"Round {Rounds}");
                Console.WriteLine();
                int rnd1 = random.Next(Trainer1Belt.Count);
                int rnd2 = random1.Next(Trainer2Belt.Count);

                // becomes pokeball
                Pokemon pokemon1 = Player1.ThrowPokeBall(Trainer1Belt[rnd1]);
                Pokemon pokemon2 = Player2.ThrowPokeBall(Trainer2Belt[rnd2]);

                // pokeball.open to get the pokemons

                Console.WriteLine();

                pokemon1.BattleCry();
                pokemon2.BattleCry();
                    
                Console.WriteLine();
                Console.WriteLine(btl.BattleOutCome(pokemon1, pokemon2, Player1, Player2));
                Console.WriteLine();

                // use the pokeball variable above
                Player1.ReturnPokeBall(Trainer1Belt[rnd1]);
                Player2.ReturnPokeBall(Trainer2Belt[rnd2]);
                
                Console.WriteLine();
                Console.WriteLine("[P1 score: {0}][P2 score: {1}]", Battle.Trainer1, Battle.Trainer2);
                Console.WriteLine();
            }
        }
        private static void ResetValues()
        {
            Battle.Trainer1 = 0;
            Battle.Trainer2 = 0;
            Rounds = 0;
        }
    }
}
