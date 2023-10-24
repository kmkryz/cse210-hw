using System;
using System.Threading;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;


    public Activity(string name, string description, int duration)
    {
        this._name = name;
        this._description = description;
        this._duration = duration;

    }

    public virtual void Start()
    {
        Console.WriteLine($"Activity: {_name}");
        Console.WriteLine(_description);
        Console.WriteLine($"Duration: {_duration} seconds");
        Console.WriteLine("Prepare to begin...");
        ShowSpinner(_duration);

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
