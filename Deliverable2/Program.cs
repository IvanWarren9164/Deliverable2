using System;
using System.Security.Cryptography;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess which will have more: heads or tails? \n");
            string headsOrTailsGuess = Console.ReadLine();
            Console.WriteLine("\n");

            Console.WriteLine("How many times shall we flip a coin? \n");
            int numberOfFlips = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            int randomNum;
            int counter = 0;
            int correctCount = 0;
            Random randm = new Random();

            while (counter < numberOfFlips)
            {
                randomNum = randm.Next(1, 3);

                if (randomNum == 1)
                {
                    Console.WriteLine("heads ");
                    if(headsOrTailsGuess == "heads")
                    {
                        correctCount++;
                    }
                }
                else
                {
                    Console.WriteLine("tails ");
                    if (headsOrTailsGuess == "tails")
                    {
                        correctCount++;
                    }
                }
                counter++;
            }

            Console.WriteLine("\n");

            if (headsOrTailsGuess == "heads")
            {
                Console.WriteLine("Your guess, " + headsOrTailsGuess + ", came up " + correctCount + " times(s). \n");
                decimal percent = (Convert.ToDecimal(correctCount) / Convert.ToDecimal(numberOfFlips)) * 100;
                Console.WriteLine("That's " + Math.Round(percent, 2) + "%.");
                
            }
            else if(headsOrTailsGuess == "tails")
            {
                Console.WriteLine("Your guess, " + headsOrTailsGuess + ", came up " + correctCount + " times(s). \n");
                decimal percent = (Convert.ToDecimal(correctCount) / Convert.ToDecimal(numberOfFlips)) * 100;
                Console.WriteLine("That's " + Math.Round(percent, 2) + "%.");
            }

        }

    }
}
