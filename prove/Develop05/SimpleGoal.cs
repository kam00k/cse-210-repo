public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string goaltype, string goalName, int baseScore, int totalScore, bool complete) : base(goaltype, goalName, baseScore, totalScore)
    {
        _isComplete = complete;
    }

    public override void Report()
    {
        _isComplete = true;
        _totalScore = _baseScore;
    }

    public override string GetGoalString()
    {
        return ($"{_goalType}: {_goalName},{_baseScore},{_totalScore},{_isComplete}");
    }
}