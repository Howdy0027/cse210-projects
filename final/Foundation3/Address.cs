// Address class
public class Address
{
    // Private member variables
    private string street;
    private string city;
    private string state;
    private string country;

    // Constructor to initialize the address
    public Address(string street, string city, string state, string country)
    {
        this.street = street;
        this.city = city;
        this.state = state;
        this.country = country;
    }

    // Method to return the full address as a string
    public string GetFullAddress()
    {
        return $"{street}, {city}, {state}, {country}";
    }
}