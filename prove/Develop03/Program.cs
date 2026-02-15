using System;

class Program
{
    // Variables
    // List of References and Lists containing Word Lists will be going here.
    private static List<Reference> _refList = new List<Reference>();
    private static Reference _nephiRef = new(1, "Nephi", 3, 7);
    private static Reference _almaRef = new("Alma", 32, 26, 27);
    private static Reference _etherRef = new("Ether", 12, 27);
    // List of Words List
    private static List<string> _listOfStrings = new List<string>();
    private static string _nephiTxt = "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.";
    private static string _almaTxt = "Now, as I said concerning faith—that it was not a perfect knowledge—even so it is with my words. Ye cannot know of their surety at first, unto perfection, any more than faith is a perfect knowledge. But behold, if ye will awake and arouse your faculties, even to an experiment upon my words, and exercise a particle of faith, yea, even if ye can no more than desire to believe, let this desire work in you, even until ye believe in a manner that ye can give place for a portion of my words.";
    private static string _etherTxt = "And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them.";
    static void Main(string[] args)
    {
        CreateRefList();
        CreateTxtList();
        int index = Random.Shared.Next(0, _refList.Count);
        Scripture scripture = new Scripture(_refList[index], _listOfStrings[index]);

        // Looping till the user quits
        while (true)
        {
            Console.Clear();
            scripture.ReprintScripture();

            // Check if done
            if (scripture.IsCompletelyHidden())
            {
                break; // End the program
            }

            Console.WriteLine("\nPress Enter to continue or type 'quit' to finish:");
            string input = Console.ReadLine();

            if (input == "quit")
            {
                break;
            }

            // Hide 3 random words for the next round
            scripture.HideRandomWords(3);
        }
    }
    // Methods
    public static void CreateRefList()
    {
        _refList.Add(_nephiRef);
        _refList.Add(_almaRef);
        _refList.Add(_etherRef);
    }
    public static void CreateTxtList()
    {
        _listOfStrings.Add(_nephiTxt);
        _listOfStrings.Add(_almaTxt);
        _listOfStrings.Add(_etherTxt);
    }
}