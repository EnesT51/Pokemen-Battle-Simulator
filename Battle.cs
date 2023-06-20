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
        public int Trainer1Score;
        public int Trainer2Score;

        public string BattleOutCome(Pokemon Player1, Pokemon Player2, List<Pokeball> T1, List<Pokeball> T2)
        {
            if(Player1.Strength == Player2.Weakness)
            {
                Trainer1Score++;
                RemovePokemon(Player1, T1);
                return $"The winner is {Player1.Name} Trainer 1 wins the round, {Player2.Name} returned to his pokeball";
            }
            else if(Player2.Strength == Player1.Weakness)
            {
                Trainer2Score++;
                RemovePokemon(Player2, T2);
                return $"The winner is {Player2.Name} Trainer 2 wins the round, {Player1.Name} returned to his pokeball";
            }
            else
            {
                RemovePokemonWhenItIsDraw(Player1, Player2, T1, T2);
                return "it is a Draw";
            }
        }
        private static void RemovePokemon(Pokemon pokemon, List<Pokeball> Belt)
        {
            foreach(Pokeball ball in Belt)
            {
                if(ball.Pokemon.Name == pokemon.Name)
                {
                    Belt.Remove(ball);
                    break;
                }
            }
        }
        private static void RemovePokemonWhenItIsDraw(Pokemon Player1, Pokemon Player2, List<Pokeball> T1, List<Pokeball> T2)
        {
            foreach((Pokeball ball, Pokeball ball2) in T1.Zip(T2, (e1, e2) => (e1, e2)))
            {
                if(ball.Pokemon.Name == Player1.Name && ball2.Pokemon.Name == Player2.Name)
                {
                    T1.Remove(ball);
                    T2.Remove(ball2);
                    break;
                }
            }

            /*foreach (Pokeball ball in T1)
            {
                if(Player1.Name == ball.Pokemon.Name)
                {
                    T1.Remove(ball);
                    break;
                    
                }
            }
            foreach (Pokeball ball2 in T2)
            {
                if(Player2.Name == ball2.Pokemon.Name)
                {
                    T2.Remove(ball2);
                    break;
                }
            }*/
        }
    }
}
