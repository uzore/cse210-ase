// Derived class for breathing activity
public class WalkingActivity : Activity
{
            
    public WalkingActivity() : base("Treadmill Walk", "This exercise will help boost your inner athlete, stamina, flexibility and energy")
    {
    }

    public void DoActivity()

    {
        bool done = false;
        while (!done)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("         DIFFICULTY LEVEL ");
            Console.WriteLine();
            Console.WriteLine("         1. Simple");
            Console.WriteLine("         2. Intermediate");
            Console.WriteLine("         3. Extreme");
            Console.WriteLine();
            Console.WriteLine($"     Please choose any difficulty level to continue:");

            string choice = Console.ReadLine();
    
            if (choice == "1")
            {    
                base.Start();
                int secondsRemaining = base.duration;

                while (secondsRemaining > 0)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("     Step One...");
                    Console.WriteLine();
                    Thread.Sleep(1000);
                    Console.WriteLine("     Step Two...");
                    Thread.Sleep(800);
                    secondsRemaining -= 2;
                }
                base.End();
                    break;
            }

            else if (choice == "2")
            {
                base.Start();
                int secondsRemaining = base.duration;

                while (secondsRemaining>0)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("     Step One...");
                    Console.WriteLine();
                    Thread.Sleep(800);
                    Console.WriteLine("     Step Two...");
                    Thread.Sleep(800);
                    secondsRemaining -= 2;
                }
                base.End();
                    break;
            }

            else if  (choice == "3")
            {
                base.Start();
                int secondsRemaining = base.duration;

                while (secondsRemaining>0)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("     Step One...");
                    Console.WriteLine();
                    Thread.Sleep(400);
                    Console.WriteLine("     Step Two...");
                    Thread.Sleep(400);
                    secondsRemaining -= 2;
                }

                    base.End();
                        break;
 
            }
            
        }
    }
}
