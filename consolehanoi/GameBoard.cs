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
        tower towA = new tower();
        tower towB = new tower();
        tower towC = new tower();
        
        
        public GameBoard()
        {
            //set up the game
            towA.fill();
        }

        public void printStatus()
        {
            Console.WriteLine(towA.slot1.ToString() + " | " + towB.slot1.ToString() + " | " + towC.slot1.ToString());
            Console.WriteLine(towA.slot2.ToString() + " | " + towB.slot2.ToString() + " | " + towC.slot2.ToString());
            Console.WriteLine(towA.slot3.ToString() + " | " + towB.slot3.ToString() + " | " + towC.slot3.ToString());
            Console.WriteLine(towA.slot4.ToString() + " | " + towB.slot4.ToString() + " | " + towC.slot4.ToString());

        }


    }
}
