// Reception class inheriting from Event
public class Reception : Event
{
    // Private member variable
    private string rsvpEmail;

    // Constructor to initialize the reception
    public Reception(string title, string description, string date, string time, Address address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        this.rsvpEmail = rsvpEmail;
    }

    // Override method to return full details of the reception
    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}, RSVP: {rsvpEmail}";
    }
}