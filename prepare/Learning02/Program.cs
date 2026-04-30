//Jack Wilson
//CSE210
//Abstraction Learning Assignment

using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Harmony Energy Works";
        job1._jobTitle = "Grant Application Assistant";
        job1._startYear = 2015;
        job1._endYear = 2018;

        //job1.Display();

        Job job2 = new Job();
        job2._company = "Harmony Energy Investments";
        job2._jobTitle = "Group Net Metering Specialist";
        job2._startYear = 2020;
        job2._endYear = 2026;

        //job2.Display();

        Resume resume1 = new Resume();
        resume1._name = "Jack Wilson";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        resume1.Display();


    }



    


}