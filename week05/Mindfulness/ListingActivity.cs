public class ListingActivity : Activity
{
    private int _count;
    List<string> _prompts = new List<string>();

    public void Run()
    {
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
    }

    public string GetRandomPrompt()
    {
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");

        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public string GetListFromUser()
    {
        Console.WriteLine("List as many responses you can to the following prompt:");
        string prompt = GetRandomPrompt();
        Console.WriteLine($"--- {prompt} ---");
        Console.Write("You may begin in: ");
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i + " ");
            System.Threading.Thread.Sleep(1000);
        }
        Console.WriteLine();
        Console.WriteLine("Start listing your items! Type 'done' when you are finished.");

        _count = 0;
        while (true)
        {
            string response = Console.ReadLine();
            if (response.ToLower() == "done")
            {
                break;
            }
            _count++;
        }
        return $"You listed {_count} items!";
    }
}