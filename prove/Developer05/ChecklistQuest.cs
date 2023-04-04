public class ChecklistQuest : Quest
{
    protected int _totalCount { get; set; }
    protected int _currentCount { get; set; }

    public ChecklistQuest(string name, int value, int totalCount) : base(name, value)
    {
        _totalCount = totalCount;
        _currentCount = 0;

    }

    public override string GetStatus()
    {
        // if (_currentCount < _totalCount )
        // {
        //     score += value * 5;//Bonus for completing checklist
        // }
        {
            return "Completed " + _currentCount + "/" + _totalCount + " times";
        }
    }
    public override void RecordEvent()
    {
        if (_currentCount < _totalCount)
        {
            _currentCount++;
            score += value;
            if (_currentCount == _totalCount)
            {
                score +=value * 5;
            }
        }
    }
}