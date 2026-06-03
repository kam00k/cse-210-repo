using System.Runtime.InteropServices;

public class EternalGoal : Goal
{
    public EternalGoal(string goaltype, string goalName, int baseScore) : base(goaltype, goalName, baseScore)
    {
        
    }

    public override void Report()
    {
        _totalScore += _baseScore;
    }
}
