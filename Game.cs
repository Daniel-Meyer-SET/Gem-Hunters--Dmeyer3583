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

        
        

        public void Start() {

            player1 = new Player("p1");
            player2 = new Player("p2");
            board = new Board();
            Console.WriteLine("Player 1");
            currentTurn = player1;
            while (IsGameOver() == false) {
                char selection = Console.ReadKey().KeyChar;
                if (selection == 'u' || selection == 'd' || selection == 'l' || selection == 'r')
                {
                    board.IsValidMove(selection, currentTurn);
                }
                else {
                    Console.Clear();
                    Console.WriteLine("\nInvalid Selection");
                }
                
               

                board.Display();
                switchTurn();
                    
            
            }
           
            

            if (IsGameOver() == true) {
                AnnounceWinner(player1, player2);
            }
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
            TotalTurns--;
            if (TotalTurns == 0) {
                
                gameOver = true;
            }
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
