using System.Runtime.InteropServices;

public class EternalGoal : Goal
{
    public EternalGoal(string goaltype, string goalName, int baseScore, int totalScore) : base(goaltype, goalName, baseScore, totalScore)
    {
        
    }

    public override void Report()
    {
        _totalScore += _baseScore;
    }

    public override string GetGoalString()
    {
        return ($"{_goalType},{_goalName},{_baseScore},{_totalScore}");
    }

    public override char IsComplete()
    {
        return base.IsComplete();
    }
}
