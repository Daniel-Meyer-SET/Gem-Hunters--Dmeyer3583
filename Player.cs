using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gem_Hunters__Dmeyer3583
{
    internal class Player
    {   
        string name=" ";
        int gemCount;
    
        public string Name
        {
            get { return name ; }
            set { name = value; } 
        }
        public int GemCount { 
        get { return gemCount ; } 
        set { gemCount = value ; }
        }
        public Position Position = new Position(0,0);
        

       
        // switch case to move player
        public void Move(char direction) {

            switch (direction)
            {
                case 'u':
                    
                   this.Position.Y--;
                   
                    
                     break;


                case 'd':
                    this.Position.Y++;
                    break;


                case 'l':
                    this.Position.X--;
                     break;

                case 'r':
                    this.Position.X++;
                    break;


                default:
                    Console.Clear();
                    Console.WriteLine("\nInvalid Selection");
                    break;


            }

        }
    }
}
