using System;

class Example12
{
    static void Main()
    {
        double radius = 0;
        do
        {
            Console.Write("Enter radius (must be > 0): ");
            string input = Console.ReadLine();
            double.TryParse(input, out radius);
        } while (radius <= 0);

        double area = Math.PI * radius * radius;
        double circumference = 2 * Math.PI * radius;

        Console.WriteLine("Area: " + area);
        Console.WriteLine("Circumference: " + circumference);
    }
}
