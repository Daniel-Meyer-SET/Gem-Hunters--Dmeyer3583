using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gem_Hunters__Dmeyer3583
{
    internal class Game
    {
        Board board;
        Player player1;
        Player player2;
        Player currentTurn;
        int TotalTurns;

        public Game(){
            player1.Name = "Player1";
            player1.Position.x = 0;
            player1.Position.y = 5;

            player2.Name = "Player2";
            player2.Position.x = 5;
            player2.Position.y = 0; 
        }

        public void Start() {
            currentTurn = player1;
            
        }

        public void switchTurn() {
            if (currentTurn == player1) {
                currentTurn = player2;
            }
            else if (currentTurn == player2)
            {
                currentTurn = player1;
            }
            
        }

        public void IsGameOver() { 
                }
        public void AnnounceWinner(Player p1, Player p2) {

            if (p1.GemCount > p2.GemCount)
            {
                Console.WriteLine("Player 1 wins!");

            }
            else if (p2.GemCount > p1.GemCount) {
                Console.WriteLine("Player 2 wins!");
            } else if (p1.GemCount == p2.GemCount) { 
            Console.WriteLine("Tie!");
            }
        }
    }
}
