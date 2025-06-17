using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        if (age < 18)
        {
            Console.WriteLine("You are under age");
        }
        else
        {
            Console.WriteLine("Enter the site");
        }
    }
}
