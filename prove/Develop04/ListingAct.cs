using System;
using System.Threading;

public class Listing : Activity
{
    private string[] _listPrompts = new string[]
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
        "What are some things that made your day better today?",
        "What are some things you could improve upon?"
    };

    public Listing(string name, string description, int duration) : base(name, description, duration) { }

    public override void Run()
    {
        base.Run();
        Console.WriteLine("");

        Random random = new Random();
        string randomPrompt = _listPrompts[random.Next(_listPrompts.Length)];

        Console.WriteLine($"---{randomPrompt}---");
        Console.WriteLine("");

        Console.WriteLine("Get ready to list items...");
        ShowCountdown(5); // Countdown for 5 seconds to prepare

        Console.WriteLine("");
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
        Console.WriteLine("");
        Console.WriteLine($"You listed {itemCounter} item(s).");

        
        EndMessage(_duration);
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
