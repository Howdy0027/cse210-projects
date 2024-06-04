// Product class
public class Product
{
    // Private member variables
    private string name;
    private string productId;
    private decimal price;
    private int quantity;

    // Constructor to initialize the product
    public Product(string name, string productId, decimal price, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.price = price;
        this.quantity = quantity;
    }

    // Public getter methods
    public string GetName() => name;
    public string GetProductId() => productId;
    public decimal GetPrice() => price;
    public int GetQuantity() => quantity;

    // Method to calculate the total cost of the product
    public decimal GetTotalCost()
    {
        return price * quantity;
    }
}