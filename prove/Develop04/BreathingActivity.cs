// Class representing the Breathing Activity, derived from the Activity base class
public class BreathingActivity : Activity
{
    // Constructor for BreathingActivity that sets the name and description of the activity
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    // Override of the abstract Run method to implement the specific behavior for the Breathing Activity
    public override void Run()
    {
        DisplayStartingMessage();  // Display the starting message for the activity
        int elapsed = 0;  // Initialize elapsed time to 0

        // Loop to alternate between "Breathe in..." and "Breathe out..." until the duration is reached
        while (elapsed < _duration)
        {
            Console.WriteLine("Breathe in...");  // Prompt the user to breathe in
            ShowCountDown(3);  // Show a countdown for 3 seconds
            elapsed += 3;  // Increment elapsed time by 3 seconds

            if (elapsed >= _duration) break;  // Check if the total duration is reached

            Console.WriteLine("Breathe out...");  // Prompt the user to breathe out
            ShowCountDown(3);  // Show a countdown for 3 seconds
            elapsed += 3;  // Increment elapsed time by 3 seconds
        }

        DisplayEndingMessage();  // Display the ending message for the activity
    }
}

