using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consolehanoi
{
    class disk
    {

        private bool _active;
        private ConsoleColor color;
        
		public disk()
		{
			_active = false;
			color = ConsoleColor.Red;
		}

		public bool active
        {
            get { return _active; }
			set
			{
				_active = value; 
					color = ConsoleColor.Red;
                    if (_active)
                    {
                        color = ConsoleColor.Green;
                    }	
			}
        }
		public void writeDisk()
		{
			Console.ForegroundColor = color;
			Console.Write("-----");
			Console.ForegroundColor = ConsoleColor.White;
		}
    }
}
