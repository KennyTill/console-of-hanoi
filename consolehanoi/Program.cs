using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consolehanoi
{
	/// <summary>
	/// Created by Kenneth Till 6-28-14
	/// Free for open source use!
	/// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = {"1", "2", "3"};
            GameBoard game = new GameBoard();

			Console.WriteLine("Welcome to Console of Hanoi!");
			Console.WriteLine("The objective it to get all the disks from tower 1, onto tower 2 or 3.");
			Console.WriteLine("");
			Console.WriteLine("You can only move one disk at a time, and cannot place or take disks from under other disks");
			Console.WriteLine("");
			Console.WriteLine("Good luck and have fun!");
			Console.WriteLine("Press any key to continue...");
			Console.ReadKey();
			Console.Clear();


            while (!game.winCondition())
            {
                game.printStatus();

                Console.Write("Take from which tower:   ");
                string strOne = Console.ReadKey().KeyChar.ToString();

                if (inputs.Contains(strOne))
                {
                    int intOne = Convert.ToInt32(strOne) - 1 ;

                    
                    Console.WriteLine("");

                    Console.Write("Put into which tower:    ");
                    string strTwo = Console.ReadKey().KeyChar.ToString();
                    if (inputs.Contains(strTwo))
                    {
                        int intTwo = Convert.ToInt32(strTwo) - 1 ;
                        game.makeMove(intOne, intTwo);


                    }
                    else
                    {
                        Console.WriteLine("{0} is not a valid entry. Please pick 1, 2, 3", strTwo);
                    }
                }
                else
                {
                    Console.WriteLine("{0} is not a valid entry. Please pick 1, 2, 3", strOne);
                }
                Console.WriteLine("");
                Console.WriteLine("");
    
            }
            game.printStatus();
            Console.WriteLine("A WINRAR IS YOU");
            Console.ReadKey();

        }
    }
}
