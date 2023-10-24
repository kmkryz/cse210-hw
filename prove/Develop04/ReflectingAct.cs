

using System;
using System.Threading;

public class Reflecting : Activity
{
    private string[] _reflectionQuestions;
    private string[] _prompts = new string[]
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    public Reflecting(string name, string description, int duration) : base(name, description, duration)
    {
        _reflectionQuestions = new string[]
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

    public override void Start()
    {
        base.Start();
        Console.WriteLine("Let's begin:");
        Random random = new Random();

        int totalSeconds = 0;
        while (totalSeconds < _duration)
        {
            string randomPrompt = _prompts[random.Next(_prompts.Length)];
            Console.WriteLine(randomPrompt);

            for (int i = 0; i < _reflectionQuestions.Length && totalSeconds < _duration; i++)
            {
                Console.WriteLine(_reflectionQuestions[i]);
                ShowSpinner(8); // Pause with spinner for 10 seconds
                totalSeconds += 8;
            }
        }

        Console.WriteLine("Good job!");
        Console.WriteLine($"You have completed {_name} for {_duration} seconds.");
        Console.WriteLine("Press any key to continue.");
        Console.ReadKey();
    }
}
