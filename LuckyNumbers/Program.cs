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
            Console.WriteLine("Thanks for playing Lucky Numbers. Please enter a number.");
            int rangeStart = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a second number that is at least 20 greater than your first number.");
            int rangeEnd = int.Parse(Console.ReadLine());

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
                    i = i - 1;
                }
            }
            Console.WriteLine(guessedNumbers[4]);
        }
    }
}
