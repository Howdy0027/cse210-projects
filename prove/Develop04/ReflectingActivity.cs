using System;
using System.Collections.Generic;

// Class representing the Reflecting Activity, derived from the Activity base class
public class ReflectingActivity : Activity
{
    // Private member variables specific to ReflectingActivity
    private List<string> _prompts;  // List of reflection prompts
    private List<string> _questions;  // List of questions for deeper reflection

    // Constructor for ReflectingActivity that sets the name, description, and initializes the prompts and questions
    public ReflectingActivity() : base("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        // Initialize the list of prompts
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        // Initialize the list of questions
        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

    // Method to get a random prompt from the list of prompts
    private string GetRandomPrompt()
    {
        Random rand = new Random();  // Create a new random number generator
        int index = rand.Next(_prompts.Count);  // Get a random index in the range of the prompt list
        return _prompts[index];  // Return the prompt at the random index
    }

    // Method to get a random question from the list of questions
    private string GetRandomQuestion()
    {
        Random rand = new Random();  // Create a new random number generator
        int index = rand.Next(_questions.Count);  // Get a random index in the range of the question list
        return _questions[index];  // Return the question at the random index
    }

    // Method to display a random prompt to the user
    private void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());  // Display the random prompt
    }

    // Method to display random questions to the user until the duration is reached
    private void DisplayQuestions()
    {
        DateTime startTime = DateTime.Now;  // Record the start time
        DateTime endTime = startTime.AddSeconds(_duration);  // Calculate the end time based on the duration
        while (DateTime.Now < endTime)  // Loop until the current time reaches the end time
        {
            Console.WriteLine(GetRandomQuestion());  // Display a random question
            ShowSpinner(3);  // Show a spinner for 3 seconds
        }
    }

    // Override of the abstract Run method to implement the specific behavior for the Reflecting Activity
    public override void Run()
    {
        DisplayStartingMessage();  // Display the starting message for the activity
        DisplayPrompt();  // Display a random prompt to the user
        DisplayQuestions();  // Display random questions to the user until the duration is reached
        DisplayEndingMessage();  // Display the ending message for the activity
    }
}

