using System;

class Program
{
    static int Add(int a, int b)
    {
        return a + b;
    }

    static void SayHello(string name)
    {
        Console.WriteLine("Hello, " + name + "!");
    }

    static void Main()
    {
        int result = Add(5, 7);
        Console.WriteLine("Addition result: " + result);

        SayHello("Ahmet");
    }
}
