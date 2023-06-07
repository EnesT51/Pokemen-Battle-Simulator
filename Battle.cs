using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Pokemen_Battle_Simulator
{
    public class Battle
    {
        public static int Trainer1;
        public static int Trainer2;

        public string BattleOutCome(Pokemon Player1, Pokemon Player2, Trainer T1, Trainer T2)
        {
            if(Player1.Strength == Player2.Weakness)
            {
                Trainer1++;
                T1.RemovePokemon(Player1, T1);
                return $"The winner is {Player1.Name} Trainer 1 wins, {Player2.Name} returned to his pokeball";
            }
            else if(Player2.Strength == Player1.Weakness)
            {
                Trainer2++;
                T2.RemovePokemon(Player2, T2);
                return $"The winner is {Player2.Name} Trainer 2 wins, {Player1.Name} returned to his pokeball";
            }
            else
            {
                return "it is a Draw";
            }
        }
    }
}
