using System;
using System.Collections.Generic;
using System.Threading;

// Abstract base class representing a generic activity
public abstract class Activity
{
    // Protected member variables to be inherited by derived classes
    protected string _name;  // Name of the activity
    protected string _description;  // Description of the activity
    protected int _duration;  // Duration of the activity in seconds

    // Constructor to initialize the activity with a name and description
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    // Method to display the starting message for the activity
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Starting {_name} Activity.");  // Display the name of the activity
        Console.WriteLine(_description);  // Display the description of the activity
        Console.Write("Enter duration in seconds: ");  // Prompt the user to enter the duration
        _duration = int.Parse(Console.ReadLine());  // Read and parse the duration from the user input
        Console.WriteLine("Prepare to begin...");  // Inform the user to prepare
        ShowSpinner(3);  // Show a spinner for 3 seconds
    }

    // Method to display the ending message for the activity
    public void DisplayEndingMessage()
    {
        Console.WriteLine($"You have completed the {_name} activity for {_duration} seconds.");  // Display the completion message with the duration
        Console.WriteLine("Great job!");  // Encourage the user
        ShowSpinner(3);  // Show a spinner for 3 seconds
    }

    // Method to show a spinner animation for a given number of seconds
    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)  // Loop for the given number of seconds
        {
            Console.Write("/");  // Display /
            Thread.Sleep(250);  // Pause for 250 milliseconds
            Console.Write("\b");  // Move the cursor back
            Console.Write("-");  // Display -
            Thread.Sleep(250);  // Pause for 250 milliseconds
            Console.Write("\b");  // Move the cursor back
            Console.Write("\\");  // Display \
            Thread.Sleep(250);  // Pause for 250 milliseconds
            Console.Write("\b");  // Move the cursor back
            Console.Write("|");  // Display |
            Thread.Sleep(250);  // Pause for 250 milliseconds
            Console.Write("\b");  // Move the cursor back
        }
    }

    // Method to show a countdown from a given number of seconds
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)  // Loop from the given number down to 1
        {
            Console.WriteLine(i);  // Display the current number
            Thread.Sleep(1000);  // Pause for 1 second
        }
    }

    // Abstract method to be implemented by derived classes for running the specific activity
    public abstract void Run();
}

