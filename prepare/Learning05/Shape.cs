// Abstract class Shape
public abstract class Shape
{
    // Private field to store the color of the shape
    private string _color;

    // Constructor for Shape class, takes color as a parameter
    // Initializes the _color field
    public Shape(string color)
    {
        _color = color;
    }

    // Public method to get the color of the shape
    public string GetColor()
    {
        return _color;
    }

    // Public method to set the color of the shape
    public void SetColor(string color)
    {
        _color = color;
    }

    // Abstract method to get the area of the shape
    // Must be implemented by derived classes
    public abstract double GetArea();
}
