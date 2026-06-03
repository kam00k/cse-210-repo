public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string goaltype, string goalName, int baseScore, bool complete) : base(goaltype, goalName, baseScore)
    {
        _isComplete = complete;
    }

    public override void Report()
    {
        _isComplete = true;
        _totalScore = _baseScore;
    }
}