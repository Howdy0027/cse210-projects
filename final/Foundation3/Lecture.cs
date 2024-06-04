// Lecture class inheriting from Event
public class Lecture : Event
{
    // Private member variables
    private string speaker;
    private int capacity;

    // Constructor to initialize the lecture
    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity)
        : base(title, description, date, time, address)
    {
        this.speaker = speaker;
        this.capacity = capacity;
    }

    // Override method to return full details of the lecture
    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}, Speaker: {speaker}, Capacity: {capacity}";
    }
}