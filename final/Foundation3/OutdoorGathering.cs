// OutdoorGathering class inheriting from Event
public class OutdoorGathering : Event
{
    // Private member variable
    private string weather;

    // Constructor to initialize the outdoor gathering
    public OutdoorGathering(string title, string description, string date, string time, Address address, string weather)
        : base(title, description, date, time, address)
    {
        this.weather = weather;
    }

    // Override method to return full details of the outdoor gathering
    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}, Weather: {weather}";
    }
}