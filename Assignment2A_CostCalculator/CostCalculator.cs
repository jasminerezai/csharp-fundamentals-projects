using System;

/// <summary>
/// Calculates total purchase cost with discount based on quantity.
/// Includes input validation and repeat functionality.
/// </summary>
public class CostCalculator
{
    /// <summary>
    /// Starts the cost calculation process.
    /// </summary>
    public void Run()
    {
        bool continueProgram = true;

        while (continueProgram)
        {
            double unitPrice = ReadPositiveDouble("Enter the original price per unit: ");
            int quantity = ReadPositiveInt("Enter the quantity of the product: ");

            double discount = GetDiscount(quantity);
            double originalTotal = unitPrice * quantity;
            double finalTotal = originalTotal * (1 - discount);

            Console.WriteLine("\n--- RESULT ---");
            Console.WriteLine($"Original Total Cost: {originalTotal:F2}");
            Console.WriteLine($"Discount Applied: {discount * 100}%");
            Console.WriteLine($"Final Total Cost: {finalTotal:F2}");

            continueProgram = AskToContinue();
        }
    }

    /// <summary>
    /// Reads a positive double value from the user.
    /// </summary>
    private double ReadPositiveDouble(string message)
    {
        double value;
        do
        {
            Console.Write(message);
        } while (!double.TryParse(Console.ReadLine(), out value) || value <= 0);

        return value;
    }

    /// <summary>
    /// Reads a positive integer value from the user.
    /// </summary>
    private int ReadPositiveInt(string message)
    {
        int value;
        do
        {
            Console.Write(message);
        } while (!int.TryParse(Console.ReadLine(), out value) || value <= 0);

        return value;
    }

    /// <summary>
    /// Determines discount percentage based on quantity.
    /// </summary>
    private double GetDiscount(int quantity)
    {
        if (quantity >= 100)
            return 0.50;
        else if (quantity >= 50)
            return 0.40;
        else if (quantity >= 20)
            return 0.30;
        else if (quantity >= 10)
            return 0.20;
        else
            return 0.0;
    }

    /// <summary>
    /// Asks the user if they want to continue.
    /// </summary>
    private bool AskToContinue()
    {
        Console.Write("\nContinue? (y/n): ");
        string input = Console.ReadLine()?.ToLower();

        return input == "y";
    }
}