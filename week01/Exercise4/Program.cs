using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (true)
        {
            Console.Write("Enter Number: ");
            int input = int.Parse(Console.ReadLine());

            if (input == 0)
            {
                break;
            }
            else
            {
                numbers.Add(input);
            }
        }

        // Getting the sum 
        int totalCount = numbers.Count;


        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"Sum is: {sum}");
        // Console.WriteLine($"Total is: {totalCount}");


        // Getting the average 

        float average = sum / totalCount;

        Console.WriteLine($"The avearage is: {average}");


        // Finding the largest number 

        int largest = numbers[0];

        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
            Console.WriteLine($"The largest Number is: {largest} ");
        }

        
    }
}