using System;

/// <summary>
/// Displays temperature conversion tables between Celsius and Fahrenheit.
/// </summary>
public class TemperatureConverter
{
    /// <summary>
    /// Starts the temperature converter menu.
    /// </summary>
    public void Run()
    {
        int choice;

        do
        {
            ShowMenu();
            choice = ReadMenuChoice();

            switch (choice)
            {
                case 1:
                    ShowFahrenheitToCelsius();
                    break;

                case 2:
                    ShowCelsiusToFahrenheit();
                    break;

                case 0:
                    Console.WriteLine("Exiting program...");
                    break;
            }

        } while (choice != 0);
    }

    /// <summary>
    /// Displays the menu options.
    /// </summary>
    private void ShowMenu()
    {
        Console.WriteLine("\nTemperature Converter");
        Console.WriteLine("0 - Exit");
        Console.WriteLine("1 - Fahrenheit to Celsius");
        Console.WriteLine("2 - Celsius to Fahrenheit");
    }

    /// <summary>
    /// Reads a valid menu choice from the user.
    /// </summary>
    private int ReadMenuChoice()
    {
        int choice;

        do
        {
            Console.Write("Enter choice: ");
        }
        while (!int.TryParse(Console.ReadLine(), out choice) || choice < 0 || choice > 2);

        return choice;
    }

    /// <summary>
    /// Displays Fahrenheit to Celsius table.
    /// </summary>
    private void ShowFahrenheitToCelsius()
    {
        Console.WriteLine("\nFahrenheit   Celsius");

        for (int f = 0; f <= 212; f += 10)
        {
            double c = 5.0 / 9.0 * (f - 32);
            Console.WriteLine($"{f,-12} {c:F2}");
        }
    }

    /// <summary>
    /// Displays Celsius to Fahrenheit table.
    /// </summary>
    private void ShowCelsiusToFahrenheit()
    {
        Console.WriteLine("\nCelsius      Fahrenheit");

        for (int c = 0; c <= 100; c += 5)
        {
            double f = 9.0 / 5.0 * c + 32;
            Console.WriteLine($"{c,-12} {f:F2}");
        }
    }
}