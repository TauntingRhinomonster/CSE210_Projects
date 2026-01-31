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

        public Entry()
        {
        }
        public Entry(string time, string prompt, string userInput)
        {
            _time = time;
            _prompt = prompt;
            _userInput = userInput;
        }

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
            
        """;
            return entry;
        }
        public string CreateFormattedString()
        {
            // inside each list is the date, userInput, prompt.
            string entry = $"{_time}~|~{_prompt}~|~{_userInput}";
            return entry;
        }
    }
}