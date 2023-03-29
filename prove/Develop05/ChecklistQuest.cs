public class ChecklistQuest : Quest
        {
            
            public ChecklistQuest() : base("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
            {
            }

            public void DoActivity()

            {
                base.Start();
                int secondsRemaining = base.duration;

                while (secondsRemaining > 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Breathe in...");
                    Console.WriteLine();
                    Thread.Sleep(1000);
                    Console.WriteLine("Breathe out...");
                    Thread.Sleep(500);
                    secondsRemaining -= 2;
                }

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
                Thread.Sleep(500);
                Console.Write("\b \b");
            }

                base.End();
            }
        }