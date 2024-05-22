using System; // Importing the System namespace for basic functionality

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of GoalManager to manage the goals
        GoalManager manager = new GoalManager();

        // Create a SimpleGoal instance for running a marathon and add it to the manager
        SimpleGoal sg = new SimpleGoal("Run a marathon", "Complete a marathon", "1000");
        manager.CreateGoal(sg);

        // Create an EternalGoal instance for reading scriptures and add it to the manager
        EternalGoal eg = new EternalGoal("Read scriptures", "Read the scriptures daily", "100");
        manager.CreateGoal(eg);

        // Create a ChecklistGoal instance for attending the temple and add it to the manager
        ChecklistGoal cg = new ChecklistGoal("Attend temple", "Attend the temple 10 times", "50", 10, 500);
        manager.CreateGoal(cg);

        // List the names of all the goals managed by GoalManager
        manager.ListGoalNames();

        // List the details of all the goals managed by GoalManager
        manager.ListGoalDetails();

        // Record an event for the first goal (index 0), marking it as completed
        manager.RecordEvent(0); // Complete the marathon

        // Record an event for the second goal (index 1), marking it as completed
        manager.RecordEvent(1); // Read scriptures

        // Record an event for the third goal (index 2), marking it as completed
        manager.RecordEvent(2); // Attend temple

        // Display the player's current score
        manager.DisplayPlayerInfo();

        // Save the goals and the current score to a file named "goals.txt"
        manager.SaveGoals("goals.txt");

        // Load the goals and the current score from the file named "goals.txt"
        manager.LoadGoals("goals.txt");
    }
}

