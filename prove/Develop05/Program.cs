
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace GoalTrackingApp
{
    class Program
    {
        static List<Goal> goals = new List<Goal>();
        static string goalsFileName = "goals.txt";
        static bool welcomeMessageDisplayed = LoadWelcomeMessageFlag();

        

        static void Main(string[] args)
        {
            //allows user to have goal data loaded automatically when program opens
            LoadGoals();

            while (true)
            {
                Console.Clear();
                Console.WriteLine($"You have {CalculateTotalPoints()} points");
                Console.WriteLine();
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Create New Goal");
                Console.WriteLine("2. List Goals");
                Console.WriteLine("3. Save Goals");
                Console.WriteLine("4. Record Event");
                Console.WriteLine("5. Quit");
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        CreateNewGoal();
                        break;
                    case 2:
                        ListGoals();
                        break;
                    case 3:
                        SaveGoals();
                        break;
                    case 4:
                        RecordEvent();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }





        static void CreateNewGoal()
        {
            Console.WriteLine("Choose the goal type:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.Write("Enter your choice: ");
            int goalChoice = int.Parse(Console.ReadLine());

            if (goalChoice < 1 || goalChoice > 3)
            {
                Console.WriteLine("Invalid choice. Goal not created.");
                return;
            }

            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();

            Console.Write("What is a short description of the goal? ");
            string description = Console.ReadLine();

            Console.Write("Enter points: ");
            int points = int.Parse(Console.ReadLine());

            if (goalChoice == 1)
            {
                goals.Add(new SimpleGoal(name, points, false, description));
            }
            else if (goalChoice == 2)
            {
                EternalGoal eternalGoal = new EternalGoal(name, points, false, description, 0);
                goals.Add(eternalGoal);
            }
            else if (goalChoice == 3)
            {
                Console.Write("How many times does this goal need to be accomplished to earn a bonus? ");
                int target = int.Parse(Console.ReadLine());

                Console.Write("How many points will you receive as your bonus? ");
                int bonusPoints = int.Parse(Console.ReadLine());

                goals.Add(new ChecklistGoal(name, points, false, description, target, bonusPoints, 0, false));

            }

            Console.WriteLine("Goal created successfully.");
        }





        static void ListGoals()
        {
            if (goals.Count == 0)
            {
                Console.WriteLine("No goals have been created yet.");
            }
            else
            {
                Console.WriteLine("List of Goals:");
                for (int i = 0; i < goals.Count; i++)
                {
                    Goal goal = goals[i];
                    string completionStatus = goal._completed ? "[X]" : "[ ]";
                    string bonusInfo = "";

                    if (goal is ChecklistGoal checklistGoal)
                    {
                        bonusInfo = $" (Completed {checklistGoal._completedCount}/{checklistGoal._target})";
                    }

                    Console.WriteLine($"{completionStatus} {i + 1}. {goal}{bonusInfo}");
                }
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        



        static void SaveGoals()
        {
            Console.Write("Saving goals... ");
            
            System.Threading.Thread.Sleep(2000);
            Console.CursorLeft = 0;

            Console.WriteLine("Goals saved successfully.");
            GoalMaintenance.SaveGoals(goals, goalsFileName);
        }



        static void LoadGoals()
        {
            Console.Write("Loading goals... ");
            
            System.Threading.Thread.Sleep(2000);
            Console.CursorLeft = 0;

            List<Goal> loadedGoals = GoalMaintenance.LoadGoals(goalsFileName);
            if (loadedGoals.Count > 0)
            {
                goals = loadedGoals;

            }
        }




        static void RecordEvent()
        {
            ListGoals();
            Console.Write("Enter the goal number to record an event: ");
            int goalIndex = int.Parse(Console.ReadLine()) - 1;

            if (goalIndex >= 0 && goalIndex < goals.Count)
            {
                Goal goal = goals[goalIndex];
                goal.RecordEvent();
                Console.WriteLine("Event recorded successfully.");
            }
            else
            {
                Console.WriteLine("Invalid goal number. Event not recorded.");
            }
        }







        static int CalculateTotalPoints()
        {
            int totalPoints = 0;

            foreach (Goal goal in goals)
            {
                if (goal is ChecklistGoal checklistGoal)
                {
                    totalPoints += checklistGoal.CalculateChecklistGoalPoints();
                }
                else if (goal is EternalGoal eternalGoal)
                {
                    // Add points for each event recorded
                    totalPoints += eternalGoal._earnedPoints;
                }
                else if (goal._completed)
                {
                    // Add points for other completed goals
                    totalPoints += goal._points;

                }

            }

            HandleGamification(totalPoints);

            return totalPoints;

        }






        
        static void HandleGamification(int totalPoints)
        {
            //welcome message flag - to be displayed single time
            if (totalPoints >= 1000 && !welcomeMessageDisplayed)
                {
                    
                    Console.WriteLine("Welcome to inside program comrad. You've reached over 1000 points. This means that for every additional 1000 points earned, you will receive a new ranking.");
                    Console.WriteLine("Congratulations. Now, let's see what you're really made of.");
                    Console.WriteLine("");

                    // Set the flag to indicate the welcome message has been displayed
                    welcomeMessageDisplayed = true;
                    // Save the flag to a file
                    SaveWelcomeMessageFlag();
                }
            

            // Check if the totalPoints is a multiple of 1000 or exceeds it
            if (totalPoints % 1000 == 0 || totalPoints > 1000)
            {
                // Display a custom message based on the increment
                
                int increment = (totalPoints / 1000); // Calculate the increment
                if (increment > 0)
                {

        
                if (increment == 1)
                {
                    
                    Console.WriteLine("Your Badge: Private");
                    Console.WriteLine("Level 1");
                }
                else if (increment == 2)
                {
                    Console.WriteLine("Your Badge: Corporal ");
                    Console.WriteLine("Level 2");
                }
                else if (increment == 3)
                {
                    Console.WriteLine("Your Badge: Sergeant");
                    Console.WriteLine("Level 3");
                }
                else if (increment == 4)
                {
                    Console.WriteLine("Your Badge: Lieutenant");
                    Console.WriteLine("Level 4");
                }
                else if (increment == 5)
                {
                    Console.WriteLine("Your Badge: Captain");
                    Console.WriteLine("Level 5");
                }
                else if (increment == 6)
                {
                    Console.WriteLine("Your Badge: Major");
                    Console.WriteLine("Level 6");
                }
                else if (increment == 7)
                {
                    Console.WriteLine("Your Badge: Colonel");
                    Console.WriteLine("Level 7");
                }
                else if (increment == 8)
                {
                    Console.WriteLine("Your Badge: Major General");
                    Console.WriteLine("Level 8");
                }
                else if (increment == 9)
                {
                    Console.WriteLine("Your Badge: General ");
                    Console.WriteLine("Level 9");
                }
                else if (increment == 10)
                {
                    Console.WriteLine("Congratulations, you are officially ranked as 'Genral of the Army'");
                    Console.WriteLine("You have surpassed all badges known to mankind, there is absolutely nothing you cannot accomplish.");
                }
            }
            }
        }
        


        static void SaveWelcomeMessageFlag()
        {
            File.WriteAllText("welcomeMessageFlag.txt", "true");
        }

        static bool LoadWelcomeMessageFlag()
        {
            if (File.Exists("welcomeMessageFlag.txt"))
            {
                return File.ReadAllText("welcomeMessageFlag.txt") == "true";
            }
            return false;
        }


}
}



