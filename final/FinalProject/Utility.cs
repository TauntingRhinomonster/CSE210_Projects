class Utility
{
    public static string ToSuperscript(double number)
    {
        // Convert the number to a string to process each digit
        string n = number.ToString();
        string result = "";

        foreach (char c in n)
        {
            result += c switch
            {
                '0' => "\u2070",
                '1' => "\u00B9",
                '2' => "\u00B2",
                '3' => "\u00B3",
                '4' => "\u2074",
                '5' => "\u2075",
                '6' => "\u2076",
                '7' => "\u2077",
                '8' => "\u2078",
                '9' => "\u2079",
                '-' => "\u207B",
                '.' => "\u22C5", // Use a dot operator for decimals
                _ => ""
            };
        }
        return result;
    }
}