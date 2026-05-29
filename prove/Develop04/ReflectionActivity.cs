class ReflectionActivity : Activity
{
    private List<string> _reflectionList = new List<string>();

    public ReflectionActivity(int duration)
    {
        _name = "Reflection Activity";
        _description = "This activity will help you to relax and calm your mind through a controlled breathing exercise.";
        _duration = duration;

        _promptList.Add("Think of a time when you stood up for someone else.");
        _promptList.Add("Think of a time when you did something really difficult.");
        _promptList.Add("Think of a time when you helped someone in need.");
        _promptList.Add("Think of a time when you did something truly selfless.");

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
        DateTime startTime = DateTime.Now;
        DateTime stopTime = startTime.AddSeconds(_duration);
        DateTime currentTime = startTime;

        int promptRandInt = _rand.Next(0, _promptList.Count());
        int reflectionRandInt = _rand.Next(0, _reflectionList.Count());

        Console.WriteLine(_promptList[promptRandInt]);

        while (currentTime < stopTime)
        {
            Console.WriteLine(_reflectionList[reflectionRandInt]);
            Spin(6);
            currentTime = DateTime.Now;
        }
    }
}