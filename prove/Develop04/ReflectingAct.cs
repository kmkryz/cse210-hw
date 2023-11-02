
using System;
using System.Threading;

public class Reflecting : Activity
{
    
    private string[] _prompts = new string[]
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
        "Recall a moment when you made a positive impact on someone's life.",
        "Consider a time when you felt a deep sense of gratitude.",
        "Reflect on a moment when you faced your fears and took a leap of faith."
    };

    private string[] _reflectionQuestions = new string[]
    {
            "What did you learn about yourself during this experience?",
            "In what ways has this experience changed your perspective on life?",
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How can you apply the lessons from this experience to your future endeavors?",
            "How did you get started?",
            "What do you believe is the key takeaway from this experience?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
    };

    public Reflecting(string name, string description, int duration) : base(name, description, duration){}

    public override void Run()
{
    base.Run();
    Random random = new Random();
    DateTime startTime = DateTime.Now;

    while (true)
    {
        if (DateTime.Now - startTime >= TimeSpan.FromSeconds(_duration))
            break;

        string randomPrompt = _prompts[random.Next(_prompts.Length)];
        Console.WriteLine($"---{randomPrompt}---");
        Console.WriteLine("");
        Console.Write("Please press enter when you are ready to begin.");
        Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("");


        for (int i = 0; i < _reflectionQuestions.Length; i++)
        {
            if (DateTime.Now - startTime >= TimeSpan.FromSeconds(_duration))
                break;

            Console.WriteLine($"> {_reflectionQuestions[i]}");
            ShowReflectSpinner(8); // Pause with spinner for 8 seconds
        }
        
        EndMessage(_duration);

    }
}


//Reflect spinner seperate to end on a more accurate time
private void ShowReflectSpinner(int seconds)
{
    string[] spinnerFrames = { "|", "/", "-", "\\" };
    int frameIndex = 0;
    for (int i = seconds * 2; i > 0; i--) // Each frame is displayed for 500 milliseconds
    {
        Console.Write($"{spinnerFrames[frameIndex]} \r");
        frameIndex = (frameIndex + 1) % spinnerFrames.Length;
        System.Threading.Thread.Sleep(500); // 500 milliseconds per frame
    }
    Console.Write(new string(' ', 15) + "\r"); // Clear the spinner
    Console.WriteLine("");
}


}
