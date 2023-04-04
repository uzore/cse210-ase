public abstract class Quest
{
        public string name { get; set; }
        public int value { get; set; }
        public int score { get; set; }

        public DateTime Date { get; set; }

        public bool IsComplete{ get; set;}
        public Quest(string name, int value)
        {
            this.name = name;
            this.value = value;
        }

        // Method to record an event (i.e. the goal has been accomplished)
        public abstract void RecordEvent();

        // Method to display the goal's status (i.e. whether it has been completed or not)
        public virtual string GetStatus()
        {
            return "";
        }
}