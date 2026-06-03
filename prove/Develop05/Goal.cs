

public class Goal
{
    protected string _goalType;
    protected string _goalName;
    protected int _baseScore;
    protected int _totalScore;

    public Goal(string goaltype, string goalName, int baseScore)
    {
        _goalType = goaltype;
        _goalName = goalName;
        _baseScore = baseScore;
        _totalScore = 0;
    }

    public int GetScore()
    {
        return _totalScore;
    }

    public virtual void Report()
    {
        
    }
}
