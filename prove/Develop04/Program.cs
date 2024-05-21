using System;

// Class representing the main program
public class Program
{
    // Main method where the program starts execution
    public static void Main(string[] args)
    {
        // Infinite loop to keep the program running until the user decides to exit
        while (true)
        {
            // Display the menu options to the user
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Listing");
            Console.WriteLine("3. Reflecting");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            // Read the user's choice from the console
            string choice = Console.ReadLine();

            // Declare a variable to hold the selected activity
            Activity activity = null;

            // Determine which activity to create based on the user's choice
            switch (choice)
            {
                case "1":
                    activity = new BreathingActivity();  // Create a BreathingActivity instance
                    break;
                case "2":
                    activity = new ListingActivity();  // Create a ListingActivity instance
                    break;
                case "3":
                    activity = new ReflectingActivity();  // Create a ReflectingActivity instance
                    break;
                case "4":
                    return;  // Exit the program
                default:
                    Console.WriteLine("Invalid choice. Please try again.");  // Inform the user of an invalid choice
                    continue;  // Continue to the next iteration of the loop
            }

            // Run the selected activity
            activity.Run();
        }
    }
}

