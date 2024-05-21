using System; // Import the System namespace for console input/output

class Program
{
    static void Main(string[] args)
    {
        // Create an Assignment object with student name "Samuel Bennett" and topic "Multiplication"
        Assignment a1 = new Assignment("Samuel Bennett", "Multiplication");
        // Print the summary of the assignment
        Console.WriteLine(a1.GetSummary());

        // Create a MathAssignment object with student name "Roberto Rodriguez", topic "Fractions",
        // textbook section "7.3", and problems "8-19"
        MathAssignment a2 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        // Print the summary of the math assignment
        Console.WriteLine(a2.GetSummary());
        // Print the list of homework problems for the math assignment
        Console.WriteLine(a2.GetHomeworkList());

        // Create a WritingAssignment object with student name "Mary Waters", topic "European History",
        // and title "The Causes of World War II"
        WritingAssignment a3 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        // Print the summary of the writing assignment
        Console.WriteLine(a3.GetSummary());
        // Print the writing information, including the title and the student's name
        Console.WriteLine(a3.GetWritingInformation());
    }
}
