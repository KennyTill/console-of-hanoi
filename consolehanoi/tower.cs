using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consolehanoi
{
    class tower
    {
        //slots for the disks, 4 is bottom, 1 is top etc
        public bool slot1 = false;
        public bool slot2 = false;
        public bool slot3 = false;
        public bool slot4 = false;

        //Can't win on the starting peg/tower
        private bool startTower = false;

        public tower()
        {
            //empty constructor
        }

        
        /// <summary>
        /// place item into corresponging slot.
        /// </summary>
        /// <param name="slotNum">Number of slot to alter</param>
        public void placeItem(int slotNum)
        {
           
            switch (slotNum)
            {
                case 1:
                    slot1 = true;
                    break;
                case 2:
                    slot2 = true;
                    break;
                case 3:
                    slot3 = true;
                    break;
                case 4:
                    slot4 = true;
                    break;
                default:
                    //put a useful exception here, you broke something
                    throw new Exception();

            }
        }
        
        /// <summary>
        /// remove item from corresponding slot
        /// </summary>
        /// <param name="slotNum">Number of slot to alter</param>
        public void takeItem(int slotNum)
        {
            
            switch (slotNum)
            {
                case 1:
                    slot1 = false;
                    break;
                case 2:
                    slot2 = false;
                    break;
                case 3:
                    slot3 = false;
                    break;
                case 4:
                    slot4 = false;
                    break;
                default:
                    //put a useful exception here, you broke something
                    throw new Exception();
            }
        }

        /// <summary>
        /// Shortcut to fill tower a to start
        /// </summary>
        public void fill()
        {
            slot1 = true;
            slot2 = true;
            slot3 = true;
            slot4 = true;
            startTower = true;
        }

        public bool checkWin()
        {
            if (!startTower)
            {
                return slot1 & slot2 & slot3 & slot4;
            }
            return startTower;
        }

    }
}
