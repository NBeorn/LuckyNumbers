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
            string playAgain;
            do
            {
                //Set up - User creates the range
                Console.WriteLine("Thanks for playing Lucky Numbers. Please enter a number.");
                int rangeStart = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter a second number that is at least 20 greater than your first number");
                int rangeEnd = int.Parse(Console.ReadLine());
                Console.WriteLine("\nYour range is " + rangeStart + " to " + rangeEnd + "\n");

                //Part 1 - User chooses their numbers
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

                //Part 2 - System generates winning numbers
                Console.WriteLine("\nThe winning numbers are:\n");

                int[] luckyNumbers = new int[6];
                Random luckyNumber = new Random();
                for (int i = 0; i <= 5; i++)
                {
                    luckyNumbers[i] = luckyNumber.Next(rangeStart, rangeEnd + 1);
                    Console.WriteLine("Lucky Number: " + luckyNumbers[i]);
                }

                //Part 3 - System determines how many matches the User had, and prints both that and their winnings based on the Jackpot
                Console.WriteLine("\nThe total Jackpot is: $1,000,000");
                int matchingNumbers = 0;

                foreach (int number in luckyNumbers)
                {
                    foreach (int number2 in guessedNumbers)
                    {
                        if (number == number2)
                        {
                            matchingNumbers++;
                        }
                    }
                }

                //Final Output
                double jackpot = (matchingNumbers / 6d) * 1000000d;

                Console.WriteLine("\nYou guessed " + matchingNumbers + " numbers correctly");

                Console.WriteLine("\nYour winnings are: $" + Math.Round(jackpot, 2) + "!");

                //Part 4 - Play again?
                Console.WriteLine("\nWould you like to play again?");
                playAgain = Console.ReadLine();
            }
            while (playAgain.ToLower() == "yes");
            Console.WriteLine("\nThanks for playing!");
        }
    }
}
