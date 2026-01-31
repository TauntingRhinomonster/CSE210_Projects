using System;
using System.ComponentModel.DataAnnotations;
using System.IO;

namespace Main
{

    public class Entry
    {
        public string _time = DateTime.Now.ToString();
        string[] _prompts = {
        "What did you do today?",
        "What is your emotional state?",
        "Have you gone on any dates recently? If so, who did you go with?",
        "What is your favorite dinosaur?",
        "Did you read your scriptures this morning? If so what are your takeaways?",
        "What is the longest you have gone without showering?",
        "What is your rank in Rocket League?",
        "What is your favorite color?"
    };
        private string _prompt;
        public string _userInput;
        public string _userRating;
        // This is the constructor for the general creation of an Entry object.
        public Entry()
        {
        }
        // This is the constructor which is used to recreate Entry objects when the "load" function is selected.
        public Entry(string time, string prompt, string userInput, string userRating)
        {
            _time = time;
            _prompt = prompt;
            _userInput = userInput;
            _userRating = userRating;
        }
        // This method will only ever show what the prompt is. After it is loaded in, it will be saved
        // in the Program.cs switch.
        public void DisplayPrompt()
        {
            int rand = new Random().Next(0, _prompts.Length);
            _prompt = _prompts[rand];
            Console.WriteLine($"{_prompt}");
        }
        public string DisplayEntry()
        {
            // inside each list is the date, userInput, prompt.
            string entry = $$"""
            {{_time}}
            {{_prompt}}
            {{_userInput}}
            {{_userRating}}
            
        """;
            return entry;
        }
        public string CreateFormattedString()
        {
            // inside each list is the date, userInput, prompt.
            string entry = $"{_time}~|~{_prompt}~|~{_userInput}~|~{_userRating}";
            return entry;
        }
        public static string PromptRating()
        {
            int userResponse = 0;
            while (userResponse > 10 || userResponse < 1)
            {
                Console.WriteLine("On a scale of 1-10, how would you rate your day? ");
                userResponse = int.Parse(Console.ReadLine());
                
                if(userResponse > 10 || userResponse < 1)
                {
                    Console.WriteLine("Please choose a number between 0 and 10");
                }
            }
            string userResponseString = $"General Rating of Day: {userResponse}";
            return userResponseString;
        }
    }
}