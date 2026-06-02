class ReflectionActivity : Activity
{
    private List<string> _reflectionList = new List<string>();

    public ReflectionActivity()
    {
        _name = "Reflection Activity";
        _description = "This activity will help you to think positively by having you recall times of growth from your past and ponder them.";

        _promptList.Add("Think of a time when you helped someone out of trouble");
        _promptList.Add("Think of a time when you pushed your limits.");
        _promptList.Add("Think of a time when someone confided in you.");
        _promptList.Add("Think of a time when your values were challenged.");

        _reflectionList.Add("Why was this experience meaningful to you?");
        _reflectionList.Add("Have you ever done anything like this before?");
        _reflectionList.Add("How did you get started?");
        _reflectionList.Add("How did you feel when it was complete?");
        _reflectionList.Add("What made this time different than other times when you were not as successful?");
        _reflectionList.Add("What is your favorite thing about this experience?");
        _reflectionList.Add("What could you learn from this experience that applies to other situations?");
        _reflectionList.Add("What did you learn about yourself through this experience?");
        _reflectionList.Add("How can you keep this experience in mind in the future?");
    }

    public void ReflectionLoop()
    {
        Console.WriteLine("Please enter how long you would like to do this activity for (in seconds):");
        _duration = Convert.ToInt32(Console.ReadLine());

        DateTime startTime = DateTime.Now;
        DateTime stopTime = startTime.AddSeconds(_duration);
        DateTime currentTime = startTime;

        int promptRandInt = _rand.Next(0, _promptList.Count());
        Console.Clear();
        Console.WriteLine(_promptList[promptRandInt]+"\n");

        while (currentTime < stopTime)
        {
            int reflectionRandInt = _rand.Next(0, _reflectionList.Count());
            Console.WriteLine(_reflectionList[reflectionRandInt]);
            Spin(12);
            currentTime = DateTime.Now;
        }
        EndMessage();
    }
}