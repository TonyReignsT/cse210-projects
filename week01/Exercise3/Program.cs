using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Exercise3 Project.");

        int magicNumber;
        int guess;

        Console.WriteLine("Guess a number between 1 and 100: ");
        // magicNumber = int.Parse(Console.ReadLine());
        Random randomGenerator = new Random();
        magicNumber = randomGenerator.Next(1, 100);

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