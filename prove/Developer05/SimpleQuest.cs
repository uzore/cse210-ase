public class SimpleQuest : Quest
{
    new public bool IsComplete { get; set; }

    public SimpleQuest(string name, int value): base(name, value)
    {
        IsComplete = false;
    }

    public override string GetStatus()
    {
        if (IsComplete)
        {
            return "[X]";
        }
        else
        {
            return "[]";
        }
    }

    public override void RecordEvent()
    {
        if (!IsComplete)
       {
            IsComplete = true;
            score += value;
       }
    }
}