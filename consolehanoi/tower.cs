using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consolehanoi
{
    class tower
    {
        public bool[] slots;    


        //Can't win on the starting peg/tower
        private bool startTower = false;

        public tower()
        {
            slots = new bool[4];
        }

        

        /// <summary>
        /// Get the top most item
        /// </summary>
        /// <returns> Slot of top item, 0 if empty</returns>
        public int getFromTopSlot()
        {
            int trueIndex = Array.IndexOf(slots, true, 0, 3);
            slots[trueIndex] = false;
            return trueIndex;
        }
        
        
        /// <summary>
        /// Peek at the top most item
        /// </summary>
        public int peekTopSlot()
        {
            return Array.IndexOf(slots, true, 0, 3);
        }


        /// <summary>
        /// place item into corresponging slot.
        /// </summary>
        /// <param name="slotNum">Number of slot to alter</param>
        public void placeItem(int slotNum)
        {
            slots[slotNum] = true;
        }
        
        /// <summary>
        /// remove item from corresponding slot
        /// </summary>
        /// <param name="slotNum">Number of slot to alter</param>
        public void takeItem(int slotNum)
        {
            slots[slotNum] = false;
            
        }

        /// <summary>
        /// Shortcut to fill tower a to start
        /// </summary>
        public void fill()
        {

            //move this out to game board
            slots[0] = true;
            slots[1] = true;
            slots[2] = true;
            slots[3] = true;
            startTower = true;
        }

        public bool checkWin()
        {
            if (!startTower)
            {
                return slots[0] & slots[1] & slots[2] & slots[3];
            }
            return startTower;
        }

    }
}
