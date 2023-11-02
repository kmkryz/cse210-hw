
using System;
using System.Threading;

public class Breathing : Activity
{
    public Breathing(string name, string description, int duration) : base(name, description, duration) { }



    public override void Run()
    {
        base.Run();
        int Duration = _duration; //to use duration value below; before changed
        int interval = _duration / 4;

        while (_duration > 0)
        {
            Console.WriteLine("Breathe in...");
            // ShowCountdown(interval);
            ShowBreathingAnimation(interval, true);
            _duration -= interval;

            if (_duration <= 0)
                break;

            Console.WriteLine("Breathe out...");
            // ShowCountdown(interval);
            ShowBreathingAnimation(interval, false);
            _duration -= interval;
        }
        
        EndMessage(Duration);


    }


    private void ShowBreathingAnimation(int seconds, bool inhale)
    {
        int intervals = 250; // Duration of each animation frame (milliseconds)
        int frames = seconds * 1000 / intervals;

        for (int frame = 0; frame < frames; frame++)
        {
            int width = inhale ? 10 + frame : 10 + frames - frame;
            string animationText = new string(' ', width) + "<>";
            Console.Write(animationText + "\r");
            System.Threading.Thread.Sleep(intervals);
        }

        Console.WriteLine("");
    }





}
