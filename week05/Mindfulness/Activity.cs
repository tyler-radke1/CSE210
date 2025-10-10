using System;
using System.Linq;
using System.Threading;

public abstract class Activity
{
    protected int _duration; // total duration in seconds
    protected string _name;
    protected string _description;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    // Abstract Exercise method for subclasses to implement
    public abstract void Exercise();

    // Shared starting message
    protected void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity!");
        Console.WriteLine(_description);
        Console.Write("Enter the duration of the activity in seconds: ");
        _duration = int.Parse(Console.ReadLine() ?? "30");
        Console.WriteLine("Get ready...");
        ShowCountdown(3); // short preparation countdown
    }

    // Shared ending message
    protected void EndActivity()
    {
        Console.WriteLine("\nWell done!");
        Console.WriteLine($"You completed the {_name} Activity for {_duration} seconds.");
        ShowCountdown(3);
    }

    // Countdown or animation helper
    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    // Spinner animation
    protected void ShowSpinner(int durationSeconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        for (int i = 0; i < durationSeconds * 4; i++)
        {
            Console.Write(spinner[i % 4]);
            Thread.Sleep(250);
            Console.Write("\b");
        }
    }
}
