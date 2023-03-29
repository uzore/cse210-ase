public class Activity

{
    private string name;
    private string description;
    protected int duration;
    public Activity(string name, string description)
    {
        this.name = name;
        this.description = description;
    }

    public void Start()
    {
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine($"{name} - {description}");
        Console.WriteLine();
        Console.Write("     Enter duration in seconds:  ");
        duration = int.Parse(Console.ReadLine());
        Console.WriteLine($"    Prepare to do some {name} exercise in 5 seconds...");
        Thread.Sleep(5000);

        List<string> aStrings = new List<string>();
        aStrings.Add("|");
        aStrings.Add("/");
        aStrings.Add("-");
        aStrings.Add("\\");
        aStrings.Add("|");
        aStrings.Add("/");
        aStrings.Add("-");
        aStrings.Add("\\");

        foreach (string s in aStrings)
        {
            Console.Write(s);
            Thread.Sleep(200);
            Console.Write("\b \b");
        }
    }

        
    public void End()
    {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"    Awesome Job! You've done some {name} exercise for {duration} seconds.");
            Console.WriteLine();
            Console.WriteLine($"    Press ENTER to continue...");
            Console.ReadKey();
    }
}
