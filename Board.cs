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
            grid[0,5].occupant = "p1";
            grid[5,0].occupant = "p2";
            Random rnd = new Random();
            for (int i = 1; i < 6; i++) {
                for (int j = 0; j < 5; j++)
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
        }

        public void CollectGem(Player P) {

            if (grid[P.Position.x,P.Position.y].occupant == "g") { 
            P.GemCount++;
            }
        }
    }
}
