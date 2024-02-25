using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gem_Hunters__Dmeyer3583
{
    internal class Board
    {
        Cell[,] grid = new Cell[6, 6];


        public Board()
        {

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    grid[i, j] = new Cell();

                }
            }
            string occType;
            int randomNum = 0;
            // generate board occupants with random numbers
            Random rnd = new Random();
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {

                    randomNum = rnd.Next(1, 4);
                    if (randomNum == 1)
                    {
                        occType = "G";
                        grid[i, j].Occupant = occType;
                    }
                    else if (randomNum == 2)
                    {
                        occType = "O";
                        grid[i, j].Occupant = occType;
                    }
                    else if (randomNum == 3)
                    {
                        occType = "-";
                        grid[i, j].Occupant = occType;
                    }



                }
            }
            // set player positions 
            grid[0, 0].Occupant = "p1";
            grid[5, 5].Occupant = "p2";
        }

        public void Display()
        {
            
           
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {  // display in a grid format
                    Console.Write($" {grid[j,i].Occupant} ");
                }
                Console.WriteLine();
            }
        }
        public void IsValidMove(char direction, Player player)
        {
            Position pos = player.Position;
            int newPos=0;
            // check adjacent cells for obstacles or other players
            switch (direction)
            {
                case 'd':
                    newPos = pos.Y+1;
                    
                    if (newPos <=5 && (this.grid[pos.X, newPos].Occupant == "-" || this.grid[pos.X, newPos].Occupant == "G"))
                    {
                        grid[pos.X, pos.Y].Occupant = "-";
                        

                        if (this.grid[pos.X, newPos].Occupant == "G")
                        {
                            CollectGem(player);
                        }
                        player.Move('d');
                        grid[pos.X, pos.Y].Occupant = player.Name;

                    }
                    break;


                case 'u':
                    newPos = pos.Y-1;
                    if (newPos >=0 && (this.grid[pos.X, newPos].Occupant == "-"|| this.grid[pos.X, newPos].Occupant == "G"))
                    {
                        grid[pos.X, pos.Y].Occupant = "-";
                       
                        if (this.grid[pos.X, newPos].Occupant == "G")
                        {
                            CollectGem(player);
                        }
                        player.Move('u');
                        grid[pos.X, pos.Y].Occupant = player.Name;
                    }
                  
                    break;


                case 'l':
                    newPos = pos.X-1;
                    if (newPos >=0 && (this.grid[newPos, pos.Y].Occupant == "-" || this.grid[newPos, pos.Y].Occupant == "G"))
                    {
                        grid[pos.X, pos.Y].Occupant = "-";
                       
                        if (this.grid[newPos, pos.Y].Occupant == "G")
                        {
                            CollectGem(player);
                        }
                        player.Move('l');
                        grid[pos.X, pos.Y].Occupant = player.Name;
                    }
                   
                    break;

                case 'r':
                    newPos = pos.X+1;
                    if (newPos <=5 && (this.grid[newPos, pos.Y].Occupant == "-"|| this.grid[newPos, pos.Y].Occupant == "G" ))
                    {
                         grid[pos.X, pos.Y].Occupant = "-";
                       
                        
                        if (this.grid[newPos, pos.Y].Occupant == "G")
                        {
                            CollectGem(player);
                        }
                         player.Move('r');
                        grid[pos.X, pos.Y].Occupant = player.Name;
                    }
                   
                    break;


                default:
                    Console.Clear();
                    Console.WriteLine("\nInvalid Selection");
                    break;

            }

        }
        // increase gem count
        public void CollectGem(Player P)
        {


                P.GemCount++;
            
        }
    }
}
