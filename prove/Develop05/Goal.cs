

public class Goal
{
    protected string _goalType;
    protected string _goalName;
    protected int _baseScore;
    protected int _totalScore;

    public Goal(string goaltype, string goalName, int baseScore, int totalScore)
    {
        _goalType = goaltype;
        _goalName = goalName;
        _baseScore = baseScore;
        _totalScore = totalScore;
    }

    public virtual string GetCompletionRatio()
    {
        return " ";
    }

    public int GetScore()
    {
        return _totalScore;
    }

    public string GetName()
    {
        return _goalName;
    }

    public string GetGoalType()
    {
        return _goalType;
    }

    public virtual string GetGoalString()
    {
        return "0";
    }

    public virtual void Report()
    {
        
    }

    public virtual char IsComplete()
    {
        return ' ';
    }
}
