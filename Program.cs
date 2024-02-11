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
            string gameMode = "0";

            Console.WriteLine("" + playerOne + "'S AND " + playerTwo + "'S");
            Console.WriteLine("    aka    \nTIC TAC TOE\n");

            PrintGrid(grid);

            gameMode = SelectMode();
            


            Console.ReadLine();

        }

        static void MainScreen()
        {

        }

        static void InitializeGrid(char[,] grid)
        {
            for (int i = 0; i < 3; i++)
            {
                if (grid[i, 0] != ' ' || grid[i, 1] != ' ' || grid[i, 2] != ' ')
                {
                    grid[i, 0] = ' ';
                    grid[i, 1] = ' ';
                    grid[i, 2] = ' ';
                }
            }
        }

        static void PrintGrid(char[,] grid)
        {
            Console.WriteLine("   A   B   C");
            for (int i = 0; i < 3; i++)
            {
                if (i == 0)
                {
                    Console.Write("1 ");
                }
                else if (i == 1)
                {
                    Console.Write("2 ");
                }
                else if (i == 2)
                {
                    Console.Write("2 ");
                }

                for (int j = 0; j < 3; j++)
                {
                    Console.Write(" " + grid[i, j] + " ");

                    if (j < 2)
                    {
                        Console.Write("|");
                    }
                    if (j == 2 && i != 2)
                    {
                        Console.Write("\n  ---+---+---\n");
                    }
                }
            }
            Console.ReadLine();
        }

        static string SelectMode()
        {
            Console.WriteLine("ONE or TWO PLAYERS?\n(Please enter 1 or 2)");
            string choice = Console.ReadLine();

            while (choice != "1" && choice != "2")
            {
                Console.WriteLine("" +choice+ " is not a valid entry.\nPlease enter 1 or 2.");
                choice = Console.ReadLine();
            }
            
            return choice;
        }

        static void DecideWinner()
        {

        }

        static void CpuMove()
        {

        }
    }
}
