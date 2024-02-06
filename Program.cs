using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XsAndOs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string playerOne = "X";
            string playerTwo = "O";
            char[,] grid = new char[3, 3];

            for (int i = 0; i < 3; i++)
            {
                if (grid[i, 0] != ' ' || grid[i, 1] != ' ' || grid[i, 2] != ' ')
                {
                    grid[i, 0] = ' ';
                    grid[i, 1] = ' ';
                    grid[i, 2] = ' ';
                }
            }

            Console.WriteLine("" + playerOne + "'S AND " + playerTwo + "'S");
            Console.WriteLine("    aka    \nTIC TAC TOE\n");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(" " +grid[i, j]+ " ");

                    if (j < 2)
                    {
                        Console.Write("|");
                    }
                    if (j == 2 && i != 2)
                    {
                        Console.Write("\n---+---+---\n");
                    }
                }
            }
            Console.ReadLine(); 
        }
    }
}
