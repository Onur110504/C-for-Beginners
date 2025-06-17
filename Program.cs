using System;

class Program
{
    static void Main()
    {
        int a = 55;
        int b = 5;

        int sum = a + b;
        int diff = a - b;
        int product = a * b;
        double division = (double)a / b;

        bool isEqual = (a == b);
        bool isGreater = (a > b);
        bool isLessOrEqual = (a <= b);

        Console.WriteLine("Sum: " + sum);
        Console.WriteLine("Difference: " + diff);
        Console.WriteLine("Product: " + product);
        Console.WriteLine("Division: " + division);
        Console.WriteLine("Is Equal? " + isEqual);
        Console.WriteLine("Is Greater? " + isGreater);
        Console.WriteLine("Is Less or Equal? " + isLessOrEqual);
    }
}
