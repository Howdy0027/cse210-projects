using System; // Importing the System namespace for basic functionalities like Console.

public class Resume
{
    // Public field to store the name of the person whose resume this is.
    public string _name;

    // Public list to store the jobs of the person. Initialized to an empty list.
    public List<Job> _jobs = new List<Job>();

    // Method to display the resume details.
    public void Display()
    {
        // Print the name of the person.
        Console.WriteLine($"Name: {_name}");
        // Print the header for the jobs section.
        Console.WriteLine("Jobs:");

        // Loop through each job in the _jobs list.
        // "Job" is a custom data type defined elsewhere in the project.
        foreach (Job job in _jobs)
        {
            // Call the Display method on each job to print its details.
            job.Display();
        }
    }
}

// Note: The Job class is assumed to be defined elsewhere in the project with its own properties and methods, including a Display method.
