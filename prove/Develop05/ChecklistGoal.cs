using System.ComponentModel.DataAnnotations;

public class ChecklistGoal : Goal
{
    private bool _isComplete;
    private int _timesCompleted;
    private int _completionsForBonus;
    private int _bonusScore;

    public ChecklistGoal(string goaltype, string goalName, int baseScore, int totalScore, bool isComplete, int timesCompleted, int completionsForBonus, int bonusScore) : base(goaltype, goalName, baseScore, totalScore)
    {
        _isComplete = isComplete;
        _timesCompleted = timesCompleted;
        _completionsForBonus = completionsForBonus;
        _bonusScore = bonusScore;
    }

    public override void Report()
    {
        if (_timesCompleted < _completionsForBonus)
        {
            _timesCompleted += 1;
            if (_timesCompleted == _completionsForBonus)
            {
                _totalScore += _bonusScore;    
            }
            else if (_timesCompleted < _completionsForBonus)
            {
                _totalScore += _baseScore;
            }

            _totalScore += _baseScore;
        }
        
    }

    public override string GetGoalString()
    {
        return ($"{_goalType},{_goalName},{_baseScore},{_totalScore},{_isComplete},{_timesCompleted},{_completionsForBonus},{_bonusScore}");
    }
}