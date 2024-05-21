using System; // Importing the System namespace for basic functionalities like Console.

class Program
{
    // Main method - the entry point of the application.
    static void Main(string[] args)
    {
        // Creating an instance of the Job class and setting its properties.
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        // Creating another instance of the Job class and setting its properties.
        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        // Creating an instance of the Resume class and setting its name property.
        Resume myResume = new Resume();
        myResume._name = "Allison Rose";

        // Adding the job instances to the _jobs list of the Resume instance.
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // Calling the Display method to print the resume details.
        myResume.Display();
    }
}

// Note: The Job class is assumed to be defined elsewhere in the project with properties _jobTitle, _company, _startYear, and _endYear, and a Display method.
