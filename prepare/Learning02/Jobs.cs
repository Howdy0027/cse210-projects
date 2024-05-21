using System; // Importing the System namespace for basic functionalities like Console.

public class Job
{
    // Public field to store the job title.
    public string _jobTitle;

    // Public field to store the company name where the job was held.
    public string _company;

    // Public field to store the year the job started.
    public int _startYear;

    // Public field to store the year the job ended.
    public int _endYear;

    // Method to display the job details in a formatted string.
    public void Display()
    {
        // Print the job details in the format: "JobTitle (Company) StartYear-EndYear".
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}
