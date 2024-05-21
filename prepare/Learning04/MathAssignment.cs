// MathAssignment class inherits from the Assignment class
public class MathAssignment : Assignment
{
    // Private fields to store the textbook section and the list of problems
    private string _textbookSection;
    private string _problems;

    // Constructor to initialize the MathAssignment object with student's name, topic, textbook section, and problems
    // Calls the base class (Assignment) constructor to initialize studentName and topic
    public MathAssignment(string studentName, string topic, string textbookSection, string problems)
        : base(studentName, topic) // Calls the constructor of the base class (Assignment)
    {
        _textbookSection = textbookSection; // Assign the textbook section to the private field
        _problems = problems; // Assign the problems to the private field
    }

    // Public method to get the list of homework problems
    public string GetHomeworkList()
    {
        // Return a formatted string with the textbook section and problems
        return $"Section {_textbookSection} Problems {_problems}";
    }
}
