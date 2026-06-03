//Jack Wilson
//CSE 210
//W05 Develop Project

public class EternalGoal : Goal
{
    //EternalGoal has no specific attributes since it cannot be completed.
    
    //Constructor. Takes in as many parameters as needed to populate all base and subclass attributes 
    //(this easily lets the user create goals or load them from files using a single constructor)
    //Really just calls the base constructor.
    public EternalGoal(string goaltype, string goalName, int baseScore, int totalScore) : base(goaltype, goalName, baseScore, totalScore)
    {
        
    }

    //Overridden Reporting method specific to EternalGoal.
    public override void Report()
    {
        _totalScore += _baseScore;
    }

    //Gets the goal string according to Eternal Goal-specific formatting
    public override string GetGoalString()
    {
        return ($"{_goalType},{_goalName},{_baseScore},{_totalScore}");
    }

    //Default behavior, since Eternal goals cannot be completed.
    public override char IsComplete()
    {
        return base.IsComplete();
    }
}
