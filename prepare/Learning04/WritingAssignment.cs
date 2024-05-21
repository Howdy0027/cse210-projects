// WritingAssignment class inherits from the Assignment class
public class WritingAssignment : Assignment
{
    // Private field to store the title of the writing assignment
    private string _title;

    // Constructor to initialize the WritingAssignment object with student's name, topic, and title
    // Calls the base class (Assignment) constructor to initialize studentName and topic
    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic) // Calls the constructor of the base class (Assignment)
    {
        _title = title; // Assign the title to the private field
    }

    // Public method to get the writing assignment information
    public string GetWritingInformation()
    {
        // Retrieve the student's name using the GetStudentName method from the base class
        string studentName = GetStudentName();
        // Return a formatted string with the title and student's name
        return $"{_title} by {studentName}";
    }
}
