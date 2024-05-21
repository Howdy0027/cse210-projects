using System;
using System.Collections.Generic;

// Class representing the Listing Activity, derived from the Activity base class
public class ListingActivity : Activity
{
    // Private member variables specific to ListingActivity
    private List<string> _prompts;  // List of prompts to guide the user
    private int _count;  // Count of items listed by the user

    // Constructor for ListingActivity that sets the name, description, and initializes the prompts
    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        // Initialize the list of prompts
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    // Method to get a random prompt from the list of prompts
    private string GetRandomPrompt()
    {
        Random rand = new Random();  // Create a new random number generator
        int index = rand.Next(_prompts.Count);  // Get a random index in the range of the prompt list
        return _prompts[index];  // Return the prompt at the random index
    }

    // Method to get a list of items from the user
    private List<string> GetListFromUser()
    {
        List<string> items = new List<string>();  // Create a new list to store items
        string input;  // Variable to store user input
        Console.WriteLine("Start listing items. Press Enter after each item. Type 'done' when finished:");  // Prompt the user to start listing items

        // Loop to read user input until the user types 'done'
        while ((input = Console.ReadLine()) != "done")
        {
            if (!string.IsNullOrEmpty(input))  // Check if the input is not empty
            {
                items.Add(input);  // Add the input to the list
            }
        }
        return items;  // Return the list of items
    }

    // Override of the abstract Run method to implement the specific behavior for the Listing Activity
    public override void Run()
    {
        DisplayStartingMessage();  // Display the starting message for the activity
        Console.WriteLine(GetRandomPrompt());  // Display a random prompt to the user
        ShowCountDown(5);  // Show a countdown for 5 seconds to give the user time to prepare
        List<string> items = GetListFromUser();  // Get the list of items from the user
        _count = items.Count;  // Store the count of items listed by the user
        Console.WriteLine($"You listed {_count} items.");  // Display the count of listed items
        DisplayEndingMessage();  // Display the ending message for the activity
    }
}

