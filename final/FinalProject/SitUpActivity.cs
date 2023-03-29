// Derived class for Sit-Up activity
public class SitUpActivity : Activity
{
            
    public SitUpActivity() : base("Sit-Up", "Lie on your back with your hands behind your ears. Then lift your upper body off the floor and slowly up to the sitting position; Don't tug your neck when you get up. Slowly go back to the start position and repeat the exercise. This exercise will help build and strengthen your abs.")
    {
    }

    public void DoActivity()

    {
        bool done = false;
        while (!done)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("         DIFFICULTY LEVEL");
            Console.WriteLine();
            Console.WriteLine("         1. Simple");
            Console.WriteLine("         2. Intermediate");
            Console.WriteLine("         3. Extreme");
            Console.WriteLine();
            Console.WriteLine($"     Please choose any difficulty level to continue:");
            Console.WriteLine();
            Console.WriteLine();

            string choice = Console.ReadLine();
    
            if (choice == "1")
            {    
                base.Start();
                int secondsRemaining = base.duration;

                while (secondsRemaining > 0)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("     Lie on your back on the floor...");
                    Console.WriteLine();
                    Thread.Sleep(3000);
                    Console.WriteLine("     Lift your top body off the floor...");
                    Thread.Sleep(2000);
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
                    Console.WriteLine("     Lie your back on the floor...");
                    Console.WriteLine();
                    Thread.Sleep(2000);
                    Console.WriteLine("     Lift your back off the floor...");
                    Thread.Sleep(1000);
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
                    Console.WriteLine("     Lie your back on the floor...");
                    Console.WriteLine();
                    Thread.Sleep(1600);
                    Console.WriteLine("     Lift your back off the floor...");
                    Thread.Sleep(800);
                    secondsRemaining -= 2;
                }

                    base.End();
                        break;
 
            }
            
        }
    }
}
