public class Job
    {
        // Responsibilities company, job title, start year, and end year.
        public string _company;
        public string _jobTitle;
        public int _startYear;
        public int _endYear;
        // Behaviors
        public Job()
        {
        }
        public static void DisplayInfo(Job name)
        {
            Console.WriteLine($"{name._jobTitle} ({name._company}) {name._startYear}-{name._endYear}");
        }
    }