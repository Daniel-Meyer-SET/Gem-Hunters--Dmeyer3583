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
        private int totalTurns;
       public int TotalTurns { get { return totalTurns; } set { totalTurns = value; } }

        public Game() {
            
            player1 = new Player();
            player2 = new Player();
            player1.Name = "p1";
            this.player2.Name = "p2";

            player1.Position.X = 0;
            player1.Position.Y = 0;
            
            player2.Position.X = 5;
            player2.Position.Y = 5;

            currentTurn = player1;

            board = new Board();
            totalTurns = 30;
        }



        public void Start() {

            

            board.Display();
            
            
            
            do
            {
                
                char selection = Console.ReadKey().KeyChar;
                if (selection == 'u' || selection == 'd' || selection == 'l' || selection == 'r')
                {
                    board.IsValidMove(selection, currentTurn);
                    Console.Clear();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\nInvalid Selection");
                }
                switchTurn();
                Console.WriteLine(currentTurn.Name);
                Console.WriteLine(" Game Turns Remaining:" + TotalTurns);
                Console.WriteLine(player1.Name + " Gem count:" + player1.GemCount);
                Console.WriteLine(player2.Name + " Gem count:" + player2.GemCount);
                board.Display();


               


            } while (IsGameOver() == false);
            AnnounceWinner(player1, player2);






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

        public bool IsGameOver() {
            bool gameOver = false;
            
            if (TotalTurns == 0) {
                
                gameOver = true;
            }
            TotalTurns--;
            return gameOver;
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
