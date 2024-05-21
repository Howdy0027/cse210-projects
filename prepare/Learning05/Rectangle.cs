// Rectangle class inherits from Shape class
public class Rectangle : Shape
{
    // Private fields to store the length and width of the rectangle
    private double _length;
    private double _width;

    // Constructor for Rectangle class, takes color, length, and width as parameters
    // Calls the base class constructor to initialize the color field
    public Rectangle(string color, double length, double width) : base(color)
    {
        _length = length;
        _width = width;
    }

    // Override the GetArea method from the Shape class
    // Calculates and returns the area of the rectangle
    public override double GetArea()
    {
        // Area of a rectangle formula: length * width
        return _length * _width;
    }
}
