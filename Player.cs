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
       public  int GemCount;

        public void Move(Position p) {

            switch (Console.ReadKey().KeyChar)
            {
                case 'u':
                    
                    p.y++;
                     break;


                case 'd':
                    p.y--;
                    break;


                case 'l':
                    p.x--;
                     break;

                case 'r':
                    p.x++;
                    break;


                default:
                    Console.Clear();
                    Console.WriteLine("\nInvalid Selection");
                    break;


            }

        }
    }
}
