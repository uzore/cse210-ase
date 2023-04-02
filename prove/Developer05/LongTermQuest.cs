public class LongTermQuest : Quest
{
    public int count { get; set; }

    public LongTermQuest(string name, int value) : base(name, value)
    {
        count = 0;
    }

    public override void RecordEvent()
    {
        count ++;
        score += value;
    }

    public override string GetStatus()
    {
        return " Completed" + count + " times";
    }
}