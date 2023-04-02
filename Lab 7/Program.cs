// Grading ID: R2226
// CIS 199 - 02
// Lab 7
// 4/10/2022
// This application prompts the user to enter a positive integer for the application to produce the number of stars based off that number.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int star;
            bool starParse;
            Console.Write("Enter a star amount: ");
            starParse = int.TryParse(Console.ReadLine(), out star);
            while(!starParse)
            {
                Console.WriteLine("Sorry that was an incorrect integer please try again");
                Console.Write("Enter a star amount: ");
                starParse = int.TryParse(Console.ReadLine(), out star);
            }
            ShowSquareOfStar(star);
        }
        private static void ShowSquareOfStar(int numStars)
        {
            int i, j;
            for(i = 1; i <= numStars; i++)
            {
                for(j = 1; j <= numStars; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
