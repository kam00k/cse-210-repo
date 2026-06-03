public class ChecklistGoal : Goal
{
    private bool _isComplete;
    private int _timesCompleted;
    private int _completionsForBonus;
    private int _bonusScore;

    public ChecklistGoal(string goaltype, string goalName, int baseScore, bool isComplete, int timesCompleted, int completionsForBonus, int bonusScore) : base(goaltype, goalName, baseScore)
    {
        _isComplete = isComplete;
        _timesCompleted = timesCompleted;
        _completionsForBonus = completionsForBonus;
        _bonusScore = bonusScore;
    }
}