using System;

class Program
{
    static void Main(string[] args)
    {



        Running runningActivity = new Running("03 Nov 2022", 30, 3.0);
        Cycling cyclingActivity = new Cycling("15 Dec 2023", 40, 15.0);
        Swimming swimmingActivity = new Swimming("20 Jan 2021", 60, 10);

        Activity[] activities = { runningActivity, cyclingActivity, swimmingActivity };

        foreach (Activity activity in activities)
        {
            Console.WriteLine();
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}