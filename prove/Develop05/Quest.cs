public class Quest
{
    private string name;
    private string description;
    protected int duration;
    public Quest(string name, string description)
    {
        this.name = name;
        this.description = description;
    }

    public void Start()
    {
        Console.WriteLine($"{name} - {description}");
        Console.Write("Enter duration in seconds:  ");
        duration = int.Parse(Console.ReadLine());
        Console.WriteLine($"Prepare to do {name} in 3 seconds...");
        Thread.Sleep(3000);
    }

    public void End()
    {
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine($"Awesome Job! You've completed {name} for {duration} seconds.");
        Console.WriteLine();
        Console.WriteLine($"Press ENTER to continue...");
        Console.ReadKey();
    }
    
}


            