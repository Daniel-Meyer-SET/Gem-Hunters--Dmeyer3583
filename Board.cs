using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gem_Hunters__Dmeyer3583
{
    internal class Board
    {
        Cell[,] grid = new Cell[6,6];


        public Board(){

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    grid[i,j] = new Cell();
                    
                }
            }
                    string occType;
            int randomNum=0;
           
            Random rnd = new Random();
            for (int i = 0; i < 6; i++) {
                for (int j = 0; j < 6; j++)
                {

                    randomNum = rnd.Next(1, 3);
                    if (randomNum == 1) {
                        occType = "G";
                        grid[i,j].occupant = occType;
                    } else if (randomNum == 2) {
                        occType = "O";
                        grid[i,j].occupant = occType;
                    }
                    else if (randomNum == 3)
                    {
                        occType = "-";
                        grid[i,j].occupant = occType;
                    }
                    

                    
                }
            }
            grid[0, 0].occupant = "p1";
            grid[5, 5].occupant = "p2";
        }

        public void Display()
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write($" { grid[i,j].occupant} ");
                }
                Console.WriteLine();
            }
        }
        public void IsValidMove(char direction, Player player) {
            Position p = player.Position;

            switch (direction)
            {
                case 'u':

                    if (p.y++ < 6  || this.grid[p.x,p.y++].occupant !="O" ) { 
                    
                    }
                    break;


                case 'd':

                    if (p.y-- > 0 || this.grid[p.x, p.y--].occupant != "O")
                    {

                    }
                    break;


                case 'l':

                    if (p.x-- > 0 || this.grid[p.x--, p.y].occupant != "O")
                    {

                    }
                    break;

                case 'r':

                    if (p.x++ < 6 || this.grid[p.x++, p.y].occupant != "O")
                    {

                    }
                    break;


                default:
                    Console.Clear();
                    Console.WriteLine("\nInvalid Selection");
                    break;

            }
        public void CollectGem(Player P) {

            if (grid[P.Position.x,P.Position.y].occupant == "g") { 
            P.GemCount++;
            }
        }
    }
}
