using System;
/// <summary>
/// Generates work schedules for weekends and night shifts.
/// </summary>
public class Scheduler
{
    /// <summary>
    /// Starts the scheduler menu.
    /// </summary>
    public void Run()
    {
        int choice;

        do
        {
            ShowMenu();
            choice = ReadChoice();

            switch (choice)
            {
                case 1:
                    Console.WriteLine("\nWeekend work weeks:");
                    PrintSchedule(2, 52, 2);
                    break;

                case 2:
                    Console.WriteLine("\nNight shift weeks:");
                    PrintSchedule(1, 52, 4);
                    break;

                case 0:
                    Console.WriteLine("Exiting scheduler...");
                    break;
            }

        } while (choice != 0);
    }
    /// <summary>
    /// Displays the menu.
    /// </summary>
    private void ShowMenu()
    {
        Console.WriteLine("\nScheduler Menu");
        Console.WriteLine("1 - Show weekend schedule");
        Console.WriteLine("2 - Show night shift schedule");
        Console.WriteLine("0 - Exit");
    }
    /// <summary>
    /// Reads menu choice.
    /// </summary>
    private int ReadChoice()
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
    /// Prints schedule using start week and interval.
    /// </summary>
    private void PrintSchedule(int startWeek, int endWeek, int interval)
    {
        for (int week = startWeek; week <= endWeek; week += interval)
        {
            Console.Write(week + " ");
        }

        Console.WriteLine();
    }
}