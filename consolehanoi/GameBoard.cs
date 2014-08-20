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
		tower[] towers = Enumerable.Range(0, 3).Select(i => new tower()).ToArray();
        
        public GameBoard()
        {
            //set up the game
            towers[0].fill();
        }

        public void printStatus()
        {
		
			//lets make a loop to display from top to bottom
			for (int i = 0; i <= 4; i++;
			{
				Console.Write(" ");
				towers[0].slots[i].writeDisk(); 
				Console.Write(" | ");
				towers[1].slots[i].writeDisk();
				Console.Write(" | ");
				towers[2].slots[i].writeDisk();
			}
			
			Console.WriteLine("   1   |   2   |   3");
            
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
