public abstract class Quest
{
        protected string name { get; set; }
        protected int value { get; set; }
        protected int score { get; set; }

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