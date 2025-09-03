using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("What is your grade percentage? ");
        int marks = int.Parse(Console.ReadLine());
        // string grade = "";
        int lastDigit = marks % 10;


        if (marks >= 90)
        {
            if (lastDigit < 3)
            {
                Console.WriteLine("Grade: A-");
            }
            else
            {
                Console.WriteLine("Grade: A");
            }
        }
        else if (marks >= 80)
        {
            if (lastDigit >= 7)
            {
                Console.WriteLine("Grade: B+");
            }
            else if (lastDigit < 3)
            {
                Console.WriteLine("Grade: B-");
            }
            else
            {
                Console.WriteLine("Grade: B");
            }
        }
        else if (marks >= 70)
        {
            if (lastDigit > 7)
            {
                Console.WriteLine("Grade: C+");
            }
            else if (lastDigit < 3)
            {
                Console.WriteLine("Grade: C-");
            }
            else
            {
                Console.WriteLine("Grade: C");
            }
        }
        else if (marks >= 60)
        {
            if (lastDigit > 7)
            {
                Console.WriteLine("Grade: D+");
            }
            else if (lastDigit < 3)
            {
                Console.WriteLine("Grade: D-");
            }
            else
            {
                Console.WriteLine("Grade: D");
            }
        }
        else
        {
            Console.WriteLine("Grade: F");
        }

        if (marks > 70)
        {
            Console.WriteLine("Congratulations for the excellent performance!");
        }
        else
        {
            Console.WriteLine("Don't give up, put more effort next time.");
        }

    }
}
