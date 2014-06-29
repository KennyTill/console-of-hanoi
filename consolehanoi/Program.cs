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
            string[] inputs = {"1", "2", "3"};
            GameBoard game = new GameBoard();
           
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

        }
    }
}
