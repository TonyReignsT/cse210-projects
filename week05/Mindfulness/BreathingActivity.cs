public class BreathingActivity : Activity
{
    
    public BreathingActivity(){}
    public void Run()
    {
        Console.WriteLine("Welcome to the Breathing Activity.");
        Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        Console.WriteLine();

        //Prompt for duration
        Console.Write("How long in seconds would you like for your session? ");
        int duration = int.Parse(Console.ReadLine());
        Console.WriteLine();

        //Starting message
        Console.WriteLine("Get ready...");
        ShowSpinner(3); //Pause for 3 seconds
        Console.WriteLine();

        //Main breathing loop
        int elapsed = 0;
        while (elapsed < duration)
        {
            //Breathe in
            Console.Write("Breathe in...");
            ShowCountdown(4); //4 seconds 
            Console.WriteLine();
            elapsed += 4;

            if (elapsed >= duration) break;

            //Breathe out
            Console.Write("Breathe out...");
            ShowCountdown(6); //6 seconds
            Console.WriteLine();
            elapsed += 6;
        }

        Console.WriteLine();
        Console.WriteLine("Well done!!");
        Console.WriteLine();
        Console.WriteLine($"You have completed {duration} seconds of the Breathing Activity.");
        ShowSpinner(3); //Pause for 3 seconds
    }
}