//Jack Wilson
//CSE 210
//W05 Develop Project

public class Goal
{
    //Base, shared Goal attributes
    protected string _goalType;
    protected string _goalName;
    protected int _baseScore;
    protected int _totalScore;

    //Base constructor; populates the base attributes.
    public Goal(string goaltype, string goalName, int baseScore, int totalScore)
    {
        _goalType = goaltype;
        _goalName = goalName;
        _baseScore = baseScore;
        _totalScore = totalScore;
    }

    //Virtual method for getting the progress for Checklist goals.
    //Needs to be overridden by the checklist goal rather than specific to it,
    //otherwise it won't work with GoalList's methods.
    public virtual string GetChecklistProgress()
    {
        return " ";
    }

    //Get the current score of the goal.
    public int GetScore()
    {
        return _totalScore;
    }

    //Gets the name of the goal
    public string GetName()
    {
        return _goalName;
    }

    //Gets the type of the goal
    public string GetGoalType()
    {
        return _goalType;
    }

    //Gets the goal string (for writing to files) 
    //in a format specific to each goal type.
    public virtual string GetGoalString()
    {
        return "0";
    }

    //handles reporting completion of a specific goal
    public virtual void Report()
    {
        
    }

    //Returns a blank space or an X depending on 
    //whether the isComplete bool is true.
    //Overridden for behavior based on goal type. 
    //This is only used for populating the completion check box 
    //whenever goals are listed.
    public virtual char IsComplete()
    {
        return ' ';
    }
}
