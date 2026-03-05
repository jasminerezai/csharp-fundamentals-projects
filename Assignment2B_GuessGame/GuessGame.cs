using System;
/// <summary>
/// A number guessing game where the player selects a difficulty level.
/// </summary>
public class GuessGame
{
    private Random random = new Random();
    /// <summary>
    /// Starts the game loop
    /// </summary>
    public void Run()
    {
        bool playAgain = true;

        while (playAgain)
        {
            int maxNumber = ChooseDifficulty();
            int secretNumber = random.Next(1, maxNumber + 1);

            Console.WriteLine($"\nI have chosen a number between 1 and {maxNumber}.");

            bool guessedCorrectly = false;

            while (!guessedCorrectly)
            {
                int guess = ReadGuess();

                if (guess < secretNumber)
                {
                    Console.WriteLine("Too low!");
                }
                else if (guess > secretNumber)
                {
                    Console.WriteLine("Too high!");
                }
                else
                {
                    Console.WriteLine("Correct! You guessed the number!");
                    guessedCorrectly = true;
                }
            }

            playAgain = AskToContinue();
        }
    }
    /// <summary>
    /// Lets the player choose difficulty level
    /// </summary>
    private int ChooseDifficulty()
    {
        Console.WriteLine("\nChoose difficulty:");
        Console.WriteLine("1 - Easy (1–10)");
        Console.WriteLine("2 - Medium (1–50)");
        Console.WriteLine("3 - Hard (1–100)");

        int choice;

        do
        {
            Console.Write("Your choice: ");
        }
        while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 3);

        if (choice == 1)
            return 10;
        else if (choice == 2)
            return 50;
        else
            return 100;
    }
    /// <summary>
    /// Reads a valid guess from the player.
    /// </summary>
    private int ReadGuess()
    {
        int guess;

        do
        {
            Console.Write("Enter your guess: ");
        }
        while (!int.TryParse(Console.ReadLine(), out guess));

        return guess;
    }
    /// <summary>
    /// Asks if the player wants to play again.
    /// </summary>
    private bool AskToContinue()
    {
        Console.Write("\nPlay again? (y/n): ");
        string input = Console.ReadLine()?.ToLower();

        return input == "y";
    }
}