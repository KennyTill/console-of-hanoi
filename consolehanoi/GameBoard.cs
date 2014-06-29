using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consolehanoi
{
    /// <summary>
    /// Holds the game! 
    /// </summary>
    class GameBoard
    {
        tower[] towers = new tower[3];
       
        
        public GameBoard()
        {
            //set up the game
            towers[0] = new tower();
            towers[1] = new tower();
            towers[2] = new tower();
            towers[0].fill();

        }

        public void printStatus()
        {
            Console.WriteLine(towers[0].slots[0].ToString() + " | " + towers[1].slots[0].ToString() + " | " + towers[2].slots[0].ToString());
            Console.WriteLine(towers[0].slots[1].ToString() + " | " + towers[1].slots[1].ToString() + " | " + towers[2].slots[1].ToString());
            Console.WriteLine(towers[0].slots[2].ToString() + " | " + towers[1].slots[2].ToString() + " | " + towers[2].slots[2].ToString());
            Console.WriteLine(towers[0].slots[3].ToString() + " | " + towers[1].slots[3].ToString() + " | " + towers[2].slots[3].ToString());
        }


        //set up move logic
        public void makeMove(int takeFromTow, int putInTow)
        {
            if (takeFromTow != putInTow)
            {
                if (!towers[takeFromTow].isempty())
                {
                    int putSlot = towers[putInTow].peekTopSlot();
                    int takeSlot = towers[takeFromTow].peekTopSlot();

                    if ((putSlot > takeSlot) || towers[putInTow].isempty())
                    {
                        towers[takeFromTow].takeItem(takeSlot);
                        towers[putInTow].placeItem(takeSlot);
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Illegal move, can not place a piece under a smaller piece");
                    }
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Cannot take from empty tower");
                }
            }
        }

        public bool winCondition()
        {
            return towers[1].checkWin() || towers[2].checkWin();
        }


    }
}
