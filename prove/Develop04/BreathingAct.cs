// using System;

// public class Breathing : Activity
// {
//     public Breathing(string name, string description, int duration) : base(name, description, duration) { }

//     public override void Start()
//     {
//         base.Start();
//         Console.WriteLine("Clear your mind and focus on your breathing.");
//         Console.WriteLine("Let's begin:");

//         int interval = duration / 4;

//         for (int i = 0; i < 4; i++)
//         {
//             Console.WriteLine("Breathe in...");
//             ShowCountdown(interval);
//             Console.WriteLine("Breathe out...");
//             ShowCountdown(interval);
//         }

//         Console.WriteLine("Good job!");
//         Console.WriteLine($"You have completed {name} for {duration} seconds.");
//         Console.WriteLine("Press any key to continue.");
//         Console.ReadKey();
//     }

//     private void ShowCountdown(int seconds)
//     {
//         for (int i = seconds; i > 0; i--)
//         {
//             Console.Write($"Countdown: {i}  \r");
//             System.Threading.Thread.Sleep(1000);
//         }
//         Console.WriteLine();
//     }
// }

using System;

public class Breathing : Activity
{
    public Breathing(string name, string description, int duration) : base(name, description, duration) { }

    public override void Start()
    {
        base.Start();
        Console.WriteLine("Clear your mind and focus on your breathing.");
        Console.WriteLine("Let's begin:");

        int Duration = _duration; //to use duration value below; before changed
        int interval = _duration / 4;

        while (_duration > 0)
        {
            Console.WriteLine("Breathe in...");
            ShowCountdown(interval);
            _duration -= interval;

            if (_duration <= 0)
                break;

            Console.WriteLine("Breathe out...");
            ShowCountdown(interval);
            _duration -= interval;
        }

        Console.WriteLine("Good job!");
        Console.WriteLine($"You have completed {_name} for {Duration} seconds.");
        Console.WriteLine("Press any key to continue.");
        Console.ReadKey();
    }

    private void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"Countdown: {i}  \r");
            System.Threading.Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}
