using System;

class Program
{
    static void Main()
    {
        string greeting = "Hello";
        string name = "World";

        string message = greeting + ", " + name + "!";
        Console.WriteLine(message);

        Console.WriteLine("Length of greeting: " + greeting.Length);

        Console.WriteLine("Uppercase name: " + name.ToUpper());
    }
}
