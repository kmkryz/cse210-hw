using System;
using System.Threading;

public class Activity
{
    protected string name;
    protected string description;
    protected int duration;
    protected string[] reflectionQuestions;

    public Activity(string name, string description, int duration)
    {
        this.name = name;
        this.description = description;
        this.duration = duration;

    }

    public virtual void Start()
    {
        Console.WriteLine($"Activity: {name}");
        Console.WriteLine(description);
        Console.WriteLine($"Duration: {duration} seconds");
        Console.WriteLine("Prepare to begin...");
        ShowSpinner(duration);

    }

    protected void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write($"Working... |/-\\ "[i % 8] + "\r");
            Thread.Sleep(200);
        }
    }
}
