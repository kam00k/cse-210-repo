//Jack Wilson
//CSE 210
//W05 Develop Project

public class SimpleGoal : Goal
{
    //completion indicator. Used in Checklist as well.
    private bool _isComplete;

    //Constructor. Takes in as many parameters as needed to populate all base and subclass attributes 
    //(this easily lets the user create goals or load them from files using a single constructor)
    public SimpleGoal(string goaltype, string goalName, int baseScore, int totalScore, bool complete) : base(goaltype, goalName, baseScore, totalScore)
    {
        _isComplete = complete;
    }

    //Overridden Reporting method specific to SimpleGoal.
    public override void Report()
    {
        _isComplete = true;
        _totalScore = _baseScore;
    }

    //Gets the goal string according to Simple Goal-specific formatting
    public override string GetGoalString()
    {
        return ($"{_goalType},{_goalName},{_baseScore},{_totalScore},{_isComplete}");
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