using System;


// Contains exercises that work with strings and switch statements.

public class StringFunctions
{
    public void Run()
    {
        bool again;

        do
        {
            StringLength();
            PredictMyDay();
            again = RunAgain();

        } while (again);
    }

    
    // Asks the user for text and prints its length and uppercase version.
    public void StringLength()
    {
        Console.Write("\nEnter some text: ");
        string text = Console.ReadLine();

        int length = text.Length;

        Console.WriteLine($"Length: {length}");
        Console.WriteLine($"Uppercase: {text.ToUpper()}");
    }

  
    // Predicts how the user's day will be based on a number 1–7.
    public void PredictMyDay()
    {
        Console.Write("\nEnter a number (1-7) for the day of the week: ");

        int day;
        if (!int.TryParse(Console.ReadLine(), out day))
        {
            Console.WriteLine("Invalid input.");
            return;
        }

        switch (day)
        {
            case 1:
                Console.WriteLine("Keep calm on Mondays! You can fall apart!");
                break;

            case 2:
            case 3:
                Console.WriteLine("Tuesdays and Wednesdays break your heart!");
                break;

            case 4:
                Console.WriteLine("Thursday is your lucky day, don't wait for Friday!");
                break;

            case 5:
                Console.WriteLine("Friday, you are in love!");
                break;

            case 6:
                Console.WriteLine("Saturday, do nothing and do plenty of it!");
                break;

            case 7:
                Console.WriteLine("And Sunday always comes too soon!");
                break;

            default:
                Console.WriteLine("No day? A good day but it doesn't exist!");
                break;
        }
    }
    
    // Asks the user if they want to run the program again.
    public bool RunAgain()
    {
        Console.Write("\nRun again? (y/n): ");
        string answer = Console.ReadLine()?.ToLower();

        return answer == "y";
    }
}