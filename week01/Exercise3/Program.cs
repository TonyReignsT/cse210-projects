using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Exercise3 Project.");

        int magicNumber;
        int guess;

        Console.Write("What is your magic number? ");
        magicNumber = int.Parse(Console.ReadLine());

        do
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        } while (guess != magicNumber);
    }
}