//Jack Wilson
//CSE 210
//W05 Develop Project

public class ChecklistGoal : Goal
{
    //Attributes specific to Checklist goals.
    private bool _isComplete;
    private int _timesCompleted;
    private int _completionsForBonus;
    private int _bonusScore;

    //Constructor. Takes in as many parameters as needed to populate all base and subclass attributes 
    //(this easily lets the user create goals or load them from files using a single constructor)
    public ChecklistGoal(string goaltype, string goalName, int baseScore, int totalScore, bool isComplete, int timesCompleted, int completionsForBonus, int bonusScore) : base(goaltype, goalName, baseScore, totalScore)
    {
        _isComplete = isComplete;
        _timesCompleted = timesCompleted;
        _completionsForBonus = completionsForBonus;
        _bonusScore = bonusScore;
    }

    //Returns a string showing the Checklist's progress, used when all goals are displayed.
    public override string GetChecklistProgress()
    {
        return ($"{_timesCompleted} / {_completionsForBonus}");
    }

    //Overridden Reporting method specific to ChecklistGoal.
    public override void Report()
    {
        if (_timesCompleted < _completionsForBonus)
        {
            _timesCompleted += 1;
            if (_timesCompleted == _completionsForBonus)
            {
                _totalScore += _bonusScore;
                _isComplete = true;    
            }
            else if (_timesCompleted < _completionsForBonus)
            {
                _totalScore += _baseScore;
            }
        }
        
    }
    //Gets the goal string according to Checklist Goal-specific formatting
    public override string GetGoalString()
    {
        return ($"{_goalType},{_goalName},{_baseScore},{_totalScore},{_isComplete},{_timesCompleted},{_completionsForBonus},{_bonusScore}");
    }

    //Returns the fill character for the completion checkbox 
    //when the goal list is displayed. 
    public override char IsComplete()
    {
        if (_isComplete == true)
        {
            return 'X';
        }
        else
        {
            return ' ';
        }
    }
}