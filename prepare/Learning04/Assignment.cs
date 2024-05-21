public class Assignment
{
    // Private fields to store the student's name and the topic of the assignment
    private string _studentName;
    private string _topic;

    // Constructor to initialize the Assignment object with the student's name and topic
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName; // Assign the student's name to the private field
        _topic = topic; // Assign the topic to the private field
    }

    // Public method to retrieve the student's name
    public string GetStudentName()
    {
        return _studentName; // Return the value of the private field _studentName
    }

    // Public method to retrieve the topic of the assignment
    public string GetTopic()
    {
        return _topic; // Return the value of the private field _topic
    }

    // Public method to get a summary of the assignment
    public string GetSummary()
    {
        // Concatenate the student's name and the topic with a hyphen and return the result
        return _studentName + " - " + _topic;
    }
}
