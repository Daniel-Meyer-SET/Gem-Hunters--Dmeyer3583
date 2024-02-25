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




        public void Start() {

            player1 = new Player("p1");
            player2 = new Player("p2");
            board = new Board();
            Console.WriteLine("Player 1");
            board.Display();
            currentTurn = player1;
            TotalTurns = 30;

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

                Console.WriteLine(" Game Turns Remaining:" + TotalTurns);
                Console.WriteLine(player1.Name + " Gem count:" + player1.GemCount);
                Console.WriteLine(player2.Name + " Gem count:" + player2.GemCount);
                board.Display();


                switchTurn();


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
