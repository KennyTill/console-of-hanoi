using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consolehanoi
{
    class tower
    {
        public disk[] slots = Enumerable.Range(0,4).Select(i => new disk()).ToArray();    


        //Can't win on the starting peg/tower
        private bool startTower = false;

		public tower()
		{
		}

        /// <summary>
        /// Peek at the top most item
        /// </summary>
        public int peekTopSlot()
        {
            int topSlot = -1;
            for (int i = 3; i >= 0; i--)
            {
                if (slots[i].active == true)
                {
                    topSlot = i;
                }
            }
            return topSlot;
        }


        /// <summary>
        /// place item into corresponging slot.
        /// </summary>
        /// <param name="slotNum">Number of slot to alter</param>
        public void placeItem(int slotNum)
        {
            slots[slotNum].active = true;
        }
        
        /// <summary>
        /// remove item from corresponding slot
        /// </summary>
        /// <param name="slotNum">Number of slot to alter</param>
        public void takeItem(int slotNum)
        {
            slots[slotNum].active = false;
            
        }

        /// <summary>
        /// Check if tower contains any elements
        /// </summary>
        /// <returns>Boolean, is empty or not</returns>
        public bool isempty()
        {
            var stackList = from slot in slots
                            where slot.active == true
                            select slot;
            return stackList.Count() == 0;
        }

        /// <summary>
        /// Shortcut to fill tower a to start
        /// </summary>
        public void fill()
        {
            slots[0].active = true;
            slots[1].active = true;
            slots[2].active = true;
            slots[3].active = true;
            startTower = true;
        }

        public bool checkWin()
        {
            if (!startTower)
            {
				return slots[0].active & slots[1].active & slots[2].active & slots[3].active;
            }
            return startTower;
        }

    }
}
