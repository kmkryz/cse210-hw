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
        Console.WriteLine("");
        Console.WriteLine($"Welcome to the {_name} activity!");
        Console.WriteLine("");
        Console.WriteLine(_description);
        Console.WriteLine("");
        Console.WriteLine($"Duration: {_duration} seconds");
        Console.WriteLine("");
        Console.WriteLine("Let's begin...");
        ShowSpinner(_duration);

    }

    public virtual void EndMessage(int duration)
    {
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("Well done! You did great!");
        Console.WriteLine($"You have completed {_name} for {duration} seconds");
        ShowSpinner(15);
        Console.WriteLine("");
        Console.WriteLine("Press any key to continue.");
        Console.ReadKey();
    }



    protected void ShowSpinner(int seconds)
{
    string[] spinnerFrames = { "|", "/", "-", "\\" };
    int frameIndex = 0;
    for (int i = seconds * 2; i > 0; i--) // Each frame is displayed for 200 milliseconds
    {
        Console.Write($"{spinnerFrames[frameIndex]} \r");
        frameIndex = (frameIndex + 1) % spinnerFrames.Length;
        System.Threading.Thread.Sleep(200); // 200 milliseconds per frame
    }
    Console.Write(new string(' ', 15) + "\r"); // Clear the spinner
    Console.WriteLine();
}



}
