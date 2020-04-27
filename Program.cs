using System;

namespace Lab_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grand Circus Game Room! Want to roll the dice? y/n");
            var playGame = Console.ReadLine().ToLower();
            if (playGame == "y")
            {
                string playAgain;
                do
                {
                    Console.WriteLine("Great! Let's play! How many sides should each die have? ");
                 
                    int sides;
                    bool success = int.TryParse(Console.ReadLine(), out sides);

                    if (!success)
                    {
                        Console.WriteLine("Sorry! You did not enter a number.");
                    }
                    else if (sides < 2)
                    {
                        Console.WriteLine("Sorry! Dice need at least two sides.");
                    }
                    else
                    {
                        Console.WriteLine($"Great choice! Your dice each have {sides} sides. Let's roll!");

                        Random firstDie = new Random();
                        int firstRoll = firstDie.Next(1, (sides + 1));
                        Random secondDie = new Random();
                        int secondRoll = secondDie.Next(1, (sides + 1));

                        Console.WriteLine($"You rolled a {firstRoll} and a {secondRoll}!");
                    }

                    Console.WriteLine("Would you like to play again? y/n");
                    playAgain = Console.ReadLine().ToLower();

                } while (playAgain == "y");

                Console.WriteLine("Thanks for playing dice roll!");

            }
            else Console.Write("Goodbye!");
        }
    }
}

   
