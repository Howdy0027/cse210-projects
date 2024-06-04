// Customer class
public class Customer
{
    // Private member variables
    private string name;
    private Address address;

    // Constructor to initialize the customer
    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }

    // Public getter methods
    public string GetName() => name;
    public Address GetAddress() => address;

    // Method to check if the customer is in the USA
    public bool IsInUSA()
    {
        return address.IsInUSA();
    }
}