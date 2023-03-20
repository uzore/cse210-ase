public class MathAss : Assignment
{

    private string _textbookSection;
    private string _problems;

    //Notice the syntax here that the MathAss constructor has 4 parameters and then
    //it passes 2 of them directly to the "base" constructor, which is the "Assignment" class constructor.
    public MathAss (string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)

    {
        //Here we set the MathAss specific variables
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section:{_textbookSection}  Problems:{_problems}";
    }
}