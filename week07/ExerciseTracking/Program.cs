using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the ExerciseTracking Project.");

        //A list to hold all types of activities
        List<Activity> activities = new List<Activity>();
        
        // Create at least one of each activity type and add them to the list
        activities.Add(new Running(new DateTime(2025, 10, 15), 30, 4.8));
        activities.Add(new Cycling(new DateTime(2025, 10, 16), 45, 25.0));
        activities.Add(new Swimming(new DateTime(2025, 10, 17), 60, 40));

        Console.WriteLine("Activity Tracker Summary:");
        Console.WriteLine();

        // Iterate through the list and display the summary for each activity
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine(); 
        }


    }
}