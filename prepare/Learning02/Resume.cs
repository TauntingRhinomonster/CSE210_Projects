public class Resume
    {
        // Responsibilities
        public string _name;
        public List<Job> _jobs = new();
        // Behaviors
        public Resume()
        {
        }
        public void DisplayJobsList()
        {
            Console.WriteLine();
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine("Jobs:");
            foreach (Job job in _jobs)
            {
                Job.DisplayInfo(job);
            }
        }
    }