using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)

    {
        Journal journal = new Journal();

        List<string> _prompts = new List<string>{
            "What was your favorite part of the day?",
            "What was something new you learned today?",
            "Who changed your mind about something today?",
            "How did I see the hand of the Lord in my life today?",
            "Do you regret any part of the day today?",
            "What made you smile today?"
        };


        while (true){
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("Please enter your choice: ");

            string choice = Console.ReadLine();

            switch (choice){

                case "1":
                    //add entry to journal
                    Random random = new Random();
                    string randomPrompt = _prompts[random.Next(_prompts.Count)];

                    Console.WriteLine($"Prompt: {randomPrompt}");
                    Console.Write("Your Response: ");
                    string _userResponse = Console.ReadLine();
                    Console.Write("What is your overall mood today? ");
                    string _userMood = Console.ReadLine();

                    Entry entry = new Entry();
                    entry._date = DateTime.Now;
                    entry._prompt = randomPrompt;
                    entry._response = _userResponse;
                    //TO EXCEED REQUIREMENTS I ADDED ANOTHER ENTRY TO THE USER
                    //JOURNAL ENTRY, THEIR OVERALL MOOD FOR THE DAY
                    entry._mood = _userMood;

                    journal.AddEntry(entry);

                    entry.DisplayEntry();

                    // Save journal to a CSV file
                    string filePath = "journal.csv";
                    journal.SaveToCsv(filePath);
                    Console.WriteLine($"Journal saved to {filePath}");

                    break;

                case "2":
                    // Displays the journal
                    journal.DisplayJournal();

                    break;
                
                case "3":
                    //load entries from csv file
                    Console.Write("Enter the filename to load the journal from: ");
                    string fileName = Console.ReadLine().Trim();
                    if (!string.IsNullOrWhiteSpace(fileName))
                    {
                        journal.LoadJournal(fileName);
                    }
                    break;

                case "4":
                    //save entries to user file
                    journal.SaveJournal();
                    break;
                
                case "5":
                    //quit program

                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid answer. Try again.");
                    break;

            }
        }























    }
}