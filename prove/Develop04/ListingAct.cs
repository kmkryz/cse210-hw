using System;
using System.Threading;

public class Listing : Activity
{
    private string[] _prompts = new string[]
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes"
    };

    public Listing(string name, string description, int duration) : base(name, description, duration) { }

    public override void Start()
    {
        base.Start();
        Console.WriteLine("Let's begin:");

        Random random = new Random();
        string randomPrompt = _prompts[random.Next(_prompts.Length)];

        Console.WriteLine(randomPrompt);

        Console.WriteLine("Get ready to list items...");
        ShowCountdown(5); // Countdown for 5 seconds to prepare

        Console.WriteLine("Start listing items:");

        DateTime startTime = DateTime.Now;
        int itemCounter = 0;

        while (true)
        {
            if (DateTime.Now - startTime >= TimeSpan.FromSeconds(_duration))
                break;

            string input = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(input))
            {
                itemCounter++;
                
            }
        }

        Console.WriteLine($"You listed {itemCounter} items.");
        Console.WriteLine("Good job!");
        Console.WriteLine($"You have completed {_name} for {_duration} seconds.");
        Console.WriteLine("Press any key to continue.");
        Console.ReadKey();
    }

    private void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"Get ready... Countdown: {i}  \r");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}