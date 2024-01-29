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
            char spaceOne = 'X';
            char spaceTwo = ' ';
            char spaceThree = ' ';
            char spaceFour = ' ';
            char spaceFive = ' ';
            char spaceSix = ' ';
            char spaceSeven = ' ';
            char spaceEight = ' ';
            char spaceNine = ' ';

            Console.WriteLine("" + playerOne + "'S AND " + playerTwo + "'S");
            Console.WriteLine("    aka    \nTIC TAC TOE");
            Console.WriteLine("");
            Console.WriteLine(" "+spaceOne+" | "+spaceTwo+" | "+spaceThree+" ");
            Console.WriteLine("---+---+---");
            Console.WriteLine(" "+spaceFour+" | "+spaceFive+" | "+spaceSix+" ");
            Console.WriteLine("---+---+---");
            Console.WriteLine(" "+spaceSeven+" | "+spaceEight+" | "+spaceNine+" ");

            Console.ReadLine(); 
        }
    }
}
