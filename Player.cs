using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gem_Hunters__Dmeyer3583
{
    internal class Player
    {
      public  string Name;
        public Position Position;
        public Player(string name) {

            this.Name = name;
            if (name == "p1") {
                this.Position = new Position(0,0);
            }
            else
            {
                this.Position = new Position(5, 5);
            }
           
        }

       public  int GemCount;

        public void Move(char direction) {

            switch (direction)
            {
                case 'u':
                    
                   this.Position.y++;
                   
                    
                     break;


                case 'd':
                    this.Position.y--;
                    break;


                case 'l':
                    this.Position.x--;
                     break;

                case 'r':
                    this.Position.x++;
                    break;


                default:
                    Console.Clear();
                    Console.WriteLine("\nInvalid Selection");
                    break;


            }

        }
    }
}
