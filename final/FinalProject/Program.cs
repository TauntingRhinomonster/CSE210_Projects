using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello FinalProject World!");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine($"Welcome to the \u001b[1mULTIMATE CALCULUS SOLVER PROGRAM\u001b[0m!!\nThis program is designed to handle \u001b[4mderivatives\u001b[0m and \u001b[4mintegrals\u001b[0m from polynomials. It is still currently under construction to be able to handle even more than just simple derivatives and integrals, and will become capable of handling the 'messiest' of equations.\n\nTo start us off, we need to write an equation. You will type how many terms you want to create, and then the program will allow you to type the coefficient/constant, variable, and the exponent. Also, each exponent can have a coefficient/constant, variable, and exponent as well. Each exponent will allow for the creation of another exponent, thus creating a 'ladder' so to speak.\n");
        int number = GetNumberInput("How many terms are in your equation?");
        int repeat = 0;
        Equation equation = new Equation();
        while (repeat < number)
        {
            Term term = CreateTerm();
            equation.AddTerm(term);
            repeat++;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Added term {repeat} of {number}.");
            Console.ResetColor();
        }
        Console.WriteLine($"Your equation is: {equation.Display()}");

        Derivative derivative = new Derivative(equation);
        Console.WriteLine($"The derivative is: {derivative.Display()}");

        Integral integral = new Integral(equation);
        Console.WriteLine($"The integral is: {integral.Display()}");
    }


    // Simple Methods
    public static int GetNumberInput(string phrase)
    {
        int number;
        while (true)
        {
            Console.Write(phrase);
            Console.Write("  Choice: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out number))
            {
                break;
            }
            else
            {
                Console.WriteLine("Please input a number.");
            }
        }
        return number;
    }

    public static int GetNumberInputInRange(int a, int b, string phrase)
    {
        int choice;
        while (true)
        {
            Console.WriteLine(phrase);
            string input = Console.ReadLine();
            if (int.TryParse(input, out int number))
            {
                if (number >= a && number <= b)
                {
                    choice = number;
                    break;
                }
                else
                {
                    Console.WriteLine($"Please choose a number between {a} and {b}.");
                }
            }
            else
            {
                Console.WriteLine("Please input a number.");
            }
        }
        return choice;
    }

    // Methods to get the work ROLLING!
    public static Term CreateTerm()
    {
        Term term = null;
        Constant constant = CreateConstant();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Constant created!");
        Console.ResetColor();
        Console.Write("Does this term have a variable (y/n)?: ");
        string answer = Console.ReadLine();
        if (answer == "y")
        {
            Variable variable = CreateVariable();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Variable created!");
            Console.ResetColor();

            Console.Write("Does this term have an exponent (y/n)?: ");
            string secondAnswer = Console.ReadLine();
            if (secondAnswer == "y")
            {
                Exponent exponent = CreateExponent();
                term = new Term(constant, variable, exponent);
            }
            else
            {
                term = new Term(constant, variable);
            }
        }
        else
        {
            Console.WriteLine("No variable then.");
            term = new Term(constant);
        }
        // I need other logic here to determine if there 
        return term;
    }

    public static Constant CreateConstant()
    {
        int choice = GetNumberInputInRange(1, 2, "\nWould you like to submit a fraction or a decimal value?\n1) Decimal\n2) Fraction\n");
        // Exit the while loop and apply the choice they made. If the choice is 1) make a decimal. if the choice is 2) make a fraction
        if (choice == 1)
        {
            // Make sure that the user doesn't make a bad choice.
            double result; // Declare outside so it's available after the loop

            while (true)
            {
                Console.Write("Enter a decimal number: ");
                string input = Console.ReadLine();

                // 2. Try to parse the input
                if (double.TryParse(input, out result))
                {
                    // 3. If successful, break out of the loop
                    break;
                }
                else
                {
                    // 4. If it fails, show an error and the loop restarts
                    Console.WriteLine("Invalid input. Please enter a valid number (e.g., 12.5 or -5).");
                }
            }

            // Once the code reaches here, 'result' is guaranteed to be a valid double
            Number dec = new Number(result);
            Console.WriteLine($"The number you created is: {dec.GetNumber()}");
            return dec;
        }
        else
        {
            // Fraction
            // This while loop will only end when the numerator and denominator have been set.
            int numerator; // Declare outside so it's available after the loop

            while (true)
            {
                Console.Write("What is the Numerator?: ");
                string input = Console.ReadLine();

                // 2. Try to parse the input
                if (int.TryParse(input, out numerator))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number (e.g., 12.5 or -5).");
                }
            }

            int denominator;

            while (true)
            {
                Console.Write("What is the Denominator?: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out denominator))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number (e.g., 12.5 or -5).");
                }
            }

            // Use the numerator and denominator we created for the Fraction object we are creating.
            Fraction fraction = new Fraction(numerator, denominator);
            Console.WriteLine($"The number you created is: {fraction.GetNumber()}");
            return fraction;
        }
    }

    public static Variable CreateVariable()
    {
        while (true)
        {
            Console.Write("Please enter a letter: ");
            string response = Console.ReadLine();

            if (char.TryParse(response, out char letter) && char.IsLetter(letter))
            {
                return new Variable(letter);
            }

            Console.WriteLine("Invalid. Please type exactly one letter.");
        }
    }

    public static Exponent CreateExponent()
    {
        int choice = GetNumberInputInRange(1, 3, "Select an option...\n1) Equation\n2) Single Term\n3) Number (Pick this one. The others are what I plan post semester.)");

        switch (choice)
        {

            case 1:
                Console.WriteLine("This feature is under construction.");
                break;
            case 2:
                Console.WriteLine("This feature is under construction.");
                break;
            case 3:
                double val = GetNumberInput("Please type a number: ");
                Number num = new Number(val);
                return new Exponent(num);
        }

        return null;
    }
}