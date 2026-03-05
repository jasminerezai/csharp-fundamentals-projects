using System;


// Displays temperature conversion tables between Celsius and Fahrenheit.
public class TemperatureConverter
{
    
    // Starts the temperature converter menu.
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


    // Displays the menu options.
    private void ShowMenu()
    {
        Console.WriteLine("\nTemperature Converter");
        Console.WriteLine("0 - Exit");
        Console.WriteLine("1 - Fahrenheit to Celsius");
        Console.WriteLine("2 - Celsius to Fahrenheit");
    }

 
    // Reads a valid menu choice from the user.
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

    
    // Displays Fahrenheit to Celsius table.
    private void ShowFahrenheitToCelsius()
    {
        Console.WriteLine("\nFahrenheit   Celsius");

        for (int f = 0; f <= 212; f += 10)
        {
            double c = 5.0 / 9.0 * (f - 32);
            Console.WriteLine($"{f,-12} {c:F2}");
        }
    }

    
    // Displays Celsius to Fahrenheit table.
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