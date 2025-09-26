using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Fractions Project.");

        Fraction f1 = new Fraction();
        // Console.WriteLine($"{f1.GetTop()}/{f1.GetBottom()}");
        Console.WriteLine($"{f1.GetFractionString()}");
        Console.WriteLine($"{f1.GetDecimalValue()}");

        Fraction f2 = new Fraction(5);
        // Console.WriteLine($"{f2.GetTop()}/{f2.GetBottom()}");
        Console.WriteLine($"{f2.GetFractionString()}");
        Console.WriteLine($"{f2.GetDecimalValue()}");

        Fraction f3 = new Fraction(6, 7);
        // Console.WriteLine($"{f3.GetTop()}/{f3.GetBottom()}");
        Console.WriteLine($"{f3.GetFractionString()}");
        Console.WriteLine($"{f3.GetDecimalValue()}");
    }
}