using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Rocky Balboa", "Culinary Arts");
        Console.WriteLine(assignment.GetSummary());
        MathAssignment math = new MathAssignment("Brad Williams", "Control systems", "3.6", "8-9");
        Console.WriteLine(math.GetSummary() + "\n" + math.GetHomeworkList());
        WritingAssignment write = new WritingAssignment("Tsukiyuki Miyako", "Cuniculture", "28 Baby Rabbits");
        Console.WriteLine(write.GetSummary() + "\n" + write.GetWritingInformation());
    }

}