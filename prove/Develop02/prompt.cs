
using System;
using System.Collections.Generic;

public class Prompt {

        //list of random prompts to be chosen from
        public static List<string> _prompts = new List<string>{
            "What was your favorite part of the day?",
            "What was something new you learned today?",
            "Who changed your mind about something today?",
            "How did I see the hand of the Lord in my life today?",
            "Do you regret any part of the day today?",
            "What made you smile today?",
            "Describe a recent memorable dream you had.",
            "Write about a challenge you've overcome and what you learned from it.",
            "Reflect on a difficult decision you've had to make and how it has shaped your life.",
            "Write about a lesson you've learned from a mistake or failure.",
            "Describe a skill or talent you'd like to develop.",
            "Reflect on your strengths and weaknesses."
        };



        public static string GetPrompt() {

        Random _random = new Random();

        return _prompts[_random.Next(_prompts.Count)];

        }




        };






