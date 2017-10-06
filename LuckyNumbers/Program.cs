using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Set up
            Console.WriteLine("Thanks for playing Lucky Numbers. Please enter a number.");
            int rangeStart = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a second number that is at least 20 greater than your first number");
            int rangeEnd = int.Parse(Console.ReadLine());

            //Part 1
            int[] guessedNumbers = new int[6];
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Now, please guess a number within the range you have created");
                int guessedNumber = int.Parse(Console.ReadLine());
                if (guessedNumber >= rangeStart && guessedNumber <= rangeEnd)
                {
                    guessedNumbers[i] = guessedNumber;
                }
                else
                {
                    Console.WriteLine("Please enter a valid number");
                    i = i - 1; //To avoid the iteration from continuing until we have a valid number
                }
            }

            //Part 2
            int[] luckyNumbers = new int[6];
            Random luckyNumber = new Random();
            for (int i = 0; i <= 5; i++)
            {
                luckyNumbers[i] = luckyNumber.Next(rangeStart, rangeEnd + 1);
                Console.WriteLine("Lucky Number: " + luckyNumbers[i]);
            }
        }
    }
}
