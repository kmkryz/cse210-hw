using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Reflecting");
            Console.WriteLine("3. Listing");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            int duration;
            Activity activity = null;

            if (choice != 4)
            {
                Console.WriteLine("");
                Console.Write("How long, in seconds, would you like your session to last? ");
                duration = int.Parse(Console.ReadLine());
            }
            else
            {
                duration = 0; // Set a default value for exit option
            }

            switch (choice)
            {
                case 1:
                    activity = new Breathing("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing", duration);
                    break;
                case 2:
                    activity = new Reflecting("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life", duration);
                    break;
                case 3:
                    activity = new Listing("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area", duration);
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            if (activity != null)
            {
                Console.Clear();
                activity.Run();
            }
        }
    }
}
