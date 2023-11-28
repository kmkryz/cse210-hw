using System;

class Program
{
    static void Main(string[] args)
    {



        Running runningActivity = new Running("03 Nov 2022", 30, 3.0);
        Cycling cyclingActivity = new Cycling("03 Nov 2022", 30, 15.0);
        Swimming swimmingActivity = new Swimming("03 Nov 2022", 30, 10);

        Activity[] activities = { runningActivity, cyclingActivity, swimmingActivity };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}