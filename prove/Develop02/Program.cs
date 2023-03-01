using System;
using System.Collections.Generic;
using System.IO;

namespace Diary
{
    class Program
    {
        static void Main(string[] args)
        {
            Journal journal = new Journal();
            bool done = false;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("             Welcome to Diary!");
            Console.WriteLine("          Press [ENTER] to continue ");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("     Please enter your name? ");
            string nom = Console.ReadLine();

            while (!done)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine($"    Hey {nom}! What do you want to do with Diary today?");
                Console.WriteLine();
                Console.WriteLine("         1. Write about an event");
                Console.WriteLine("         2. Display Diary");
                Console.WriteLine("         3. Save your entries to a file");
                Console.WriteLine("         4. Load entries from a file");
                Console.WriteLine("         5. Exit Diary");
                Console.WriteLine();
                Console.WriteLine($"     {nom}, kindly choose a number from the above options: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        journal.AddEntry();
                        break;
                    case "2":
                        journal.DisplayEntries();
                        break;
                    case "3":
                        journal.SaveToFile();
                        break;
                    case "4":
                        journal.LoadFromFile();
                        break;
                    case "5":
                        done = true;
                        break;
                    default:
                        Console.WriteLine(" Invalid option!. Please choose any number from the 1-4 or 5 to [QUIT] Diary.");
                        break;
                }
            }
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
