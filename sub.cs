using System;

class Program
{
    static void Main(string[] args)
    {
        // Declare variables to store the numbers
        int a, b, c;

        // Prompt the user to enter the first number
        Console.Write("Enter the first number: ");
        // Read the input and convert it to an integer
        a = Convert.ToInt32(Console.ReadLine());

        // Prompt the user to enter the second number
        Console.Write("Enter the second number: ");
        // Read the input and convert it to an integer
        b = Convert.ToInt32(Console.ReadLine());

        // Subtract the second number from the first number
        c = a - b;

        // Display the result
        Console.WriteLine("The difference of {0} and {1} is: {2}", a, b, c);

        // Wait for the user to press any key before exiting
        Console.ReadKey();
    }
}
