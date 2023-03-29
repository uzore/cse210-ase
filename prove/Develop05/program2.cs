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

    class dailyEvents
    {
            public string Prompt { get; set; }
            public string Response { get; set; }
            public DateTime Date { get; set; }

            public dailyEvents(string prompt, string response, DateTime date)
            {
                Prompt = prompt;
                Response = response;
                Date = date;
            }

            public override string ToString()
            {
                return $"{Date.ToShortDateString()}: {Prompt}\n{Response}\n";
            }
    }

    class Journal
    {
        private List<dailyEvents> entries = new List<dailyEvents>();
        private List<Prompt> prompts = new List<Prompt>
        {
            new Prompt(     "How did you use your time today "),
            new Prompt(     "What time were you busy the most today? "),
            new Prompt(     "What was the best part of your day? "),
            new Prompt(     "What did you notice about your environment today? "),
            new Prompt(     "Who did you talk to most time today? "),
            new Prompt(     "What could you have done today but could not? "),
            new Prompt(     "What will you do better tomorrow? "),
        };

        public void AddEntry()
        {
            Console.WriteLine("      Tip:");
            Console.WriteLine("      Kindly choose the number you want to write about from the options below");
            Console.WriteLine();
            for (int i = 0; i < prompts.Count; i++)
            {
                Console.WriteLine($"       {i + 1}. {prompts[i].Text}");
            }
                int index = int.Parse(Console.ReadLine()) - 1;
                Console.WriteLine(prompts[index].Text);
                string response = Console.ReadLine();
                dailyEvents entry = new dailyEvents(prompts[index].Text, response, DateTime.Now);
                entries.Add(entry);
        }

        public void DisplayEntries()
        {
                if (entries.Count == 0)
                {
                    Console.WriteLine("     No entries to display.");
                }
                else
                {
                    foreach (dailyEvents entry in entries)
                    {
                        Console.WriteLine(entry.ToString());
                    }
                }
        }

            public void SaveToFile()
            {
                Console.WriteLine("     Give the file a name:");
                string filename = Console.ReadLine();
                StreamWriter writer = new StreamWriter(filename);
                foreach (dailyEvents entry in entries)
                {
                    writer.WriteLine($"     {entry.Date.ToShortDateString()}|{entry.Prompt}|{entry.Response}");
                }
                writer.Close();
        }

        public void LoadFromFile()
        {
                    Console.WriteLine(" Enter a filename:");
                    string filename = Console.ReadLine();
                    StreamReader reader = new StreamReader(filename);
                    entries.Clear();
                    while (!reader.EndOfStream)
                    {
                        string[] fields = reader.ReadLine().Split('|');
                        DateTime date = DateTime.Parse

                        (fields[0]);
                        string prompt = fields[1];
                        string response = fields[2];
                        dailyEvents entry = new dailyEvents(prompt, response, date);
                        entries.Add(entry);
                    }
                    reader.Close();
        }
        

    class Prompt
    {
        public string Text { get; set; }

        public Prompt(string text)
        {
            Text = text;
        }
    }

}
    