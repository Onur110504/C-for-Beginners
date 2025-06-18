using System;

class EvenOddCheck
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        string? input = Console.ReadLine();

        if (!string.IsNullOrEmpty(input) && int.TryParse(input, out int number))
        {
            if (number % 2 == 0)
                Console.WriteLine("Even number");
            else
                Console.WriteLine("Odd number");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
}
