using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number > 0)
        {
            int square = number * number;
            Console.WriteLine("Square: " + square);
        }
        else
        {
            Console.WriteLine("Number is not positive.");
        }
    }
}
