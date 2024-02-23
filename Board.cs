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

            Random rnd = new Random();
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {

                    randomNum = rnd.Next(1, 4);
                    if (randomNum == 1)
                    {
                        occType = "G";
                        grid[i, j].occupant = occType;
                    }
                    else if (randomNum == 2)
                    {
                        occType = "O";
                        grid[i, j].occupant = occType;
                    }
                    else if (randomNum == 3)
                    {
                        occType = "-";
                        grid[i, j].occupant = occType;
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
                    Console.Write($" {grid[j,i].occupant} ");
                }
                Console.WriteLine();
            }
        }
        public void IsValidMove(char direction, Player player)
        {
            Position p = player.Position;
            int newPos=0;
            switch (direction)
            {
                case 'u':
                    newPos = p.y+1;
                    if (newPos <=5 && this.grid[p.x, newPos].occupant != "O")
                    {
                        grid[p.x, p.y].occupant = "-";
                        player.Move('u');
                        grid[p.x, p.y].occupant = player.Name;

                    }
                    break;


                case 'd':
                    newPos = p.y-1;
                    if (newPos >=0 && this.grid[p.x, newPos].occupant != "O")
                    {
                        grid[p.x, p.y].occupant = "-";
                        player.Move('d');
                        grid[p.x, p.y].occupant = player.Name;
                    }
                    break;


                case 'l':
                    newPos = p.x-1;
                    if (newPos >=0 && this.grid[newPos, p.y].occupant != "O")
                    {
                        grid[p.x, p.y].occupant = "-";
                        player.Move('l');
                        grid[p.x, p.y].occupant = player.Name;
                    }
                    break;

                case 'r':
                    newPos = p.x+1;
                    if (newPos <5 && this.grid[newPos, p.y].occupant != "O")
                    {
                         grid[p.x, p.y].occupant = "-";
                        player.Move('r');
                        grid[p.y, p.x].occupant = player.Name;
                    }
                    break;


                default:
                    Console.Clear();
                    Console.WriteLine("\nInvalid Selection");
                    break;

            }

        }
        public void CollectGem(Player P)
        {

            if (grid[P.Position.x, P.Position.y].occupant == "g")
            {
                P.GemCount++;
            }
        }
    }
}
