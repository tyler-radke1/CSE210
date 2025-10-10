using System.Collections.Generic;

public class Listing : Activity
{
    private string[] _prompts =
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public Listing() : base(
        "Listing",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    { }

    public override void Exercise()
    {
        StartActivity();

        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Length)];
        Console.WriteLine(prompt);
        Console.WriteLine("You have 5 seconds to think...");
        ShowCountdown(5);

        List<string> items = new List<string>();
        int elapsed = 0;
        DateTime start = DateTime.Now;

        while ((DateTime.Now - start).TotalSeconds < _duration)
        {
            Console.Write("Enter item: ");
            string? item = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(item))
                items.Add(item);
        }

        Console.WriteLine($"\nYou listed {items.Count} items!");
        EndActivity();
    }
}
