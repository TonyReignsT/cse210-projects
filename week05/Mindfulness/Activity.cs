public class Activity
{
    private string _name;
    private string _description;
    private int _duration;


    // public Activity(string name, string description, int duration)
    // {
    //     _name = name;
    //     _description = description;
    //     _duration = duration;
    // }

    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b"); // Erase the previous number
        }
    }
    
    public void ShowSpinner(int seconds)
    {
        char[] spinner = { '|', '/', '-', '\\' };
        int interations = seconds * 4; // 4 iterations per second

        for (int i = 0; i < interations; i++)
        {
            Console.Write("|");
        System.Threading.Thread.Sleep(250);
        Console.Write("\b");
        
        Console.Write("/");
        System.Threading.Thread.Sleep(250);
        Console.Write("\b");
        
        Console.Write("-");
        System.Threading.Thread.Sleep(250);
        Console.Write("\b");
        
        Console.Write("\\");
        System.Threading.Thread.Sleep(250);
        Console.Write("\b");
        }
    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine("Menu Options: ");
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Start reflecting activity");
        Console.WriteLine("3. Start listing activity");
        Console.WriteLine("4. Quit");
        Console.Write("Select a choice from the menu: ");
        string choice = Console.ReadLine();
        Console.WriteLine();
        switch (choice)
        {
            case "1":
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
                break;
            case "2":
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.Run();
                reflectingActivity.DisplayPrompt();
                Console.WriteLine("When you have something in mind, press enter to continue.");
                Console.ReadLine();
                for (int i = 0; i < 3; i++)
                {
                    reflectingActivity.DisplayQuestion();
                    Console.WriteLine("Press enter to continue.");
                    Console.ReadLine();
                }
                break;
            case "3":
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();
                string result = listingActivity.GetListFromUser();
                Console.WriteLine(result);
                break;
            case "4":
                Console.WriteLine("Goodbye!");
                break;
            default:
                Console.WriteLine("Invalid choice. Please select a valid option.");
                break;
        }
    }

    public void DisplayEndingMessage()
    {
        
    }
}