using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consolehanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            GameBoard game = new GameBoard();
            game.printStatus();
            Console.Write("Take from which tower?");
            string inputOne = Console.ReadKey().ToString();
            
            Console.WriteLine("");
            Console.Write("Put into which tower?");
            string inputTwo = Console.ReadKey().ToString();


        }
    }
}
