// Base Event class
public abstract class Event
{
    // Private member variables
    private string title;
    private string description;
    private string date;
    private string time;
    private Address address;

    // Constructor to initialize the event
    public Event(string title, string description, string date, string time, Address address)
    {
        this.title = title;
        this.description = description;
        this.date = date;
        this.time = time;
        this.address = address;
    }

    // Public getter methods
    public string GetTitle() => title;
    public string GetDescription() => description;
    public string GetDate() => date;
    public string GetTime() => time;
    public Address GetAddress() => address;

    // Method to return standard details of the event
    public virtual string GetStandardDetails()
    {
        return $"{title}: {description} on {date} at {time}, {address.GetFullAddress()}";
    }

    // Abstract method to return full details of the event
    public abstract string GetFullDetails();

    // Method to return short description of the event
    public virtual string GetShortDescription()
    {
        return $"{this.GetType().Name}: {title} on {date}";
    }
}