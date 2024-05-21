// Square class inherits from Shape class
public class Square : Shape
{
    // Private field to store the side length of the square
    private double _side;

    // Constructor for Square class, takes color and side length as parameters
    // Calls the base class constructor to initialize the color field
    public Square(string color, double side) : base(color)
    {
        _side = side;
    }

    // Override the GetArea method from the Shape class
    // Calculates and returns the area of the square
    public override double GetArea()
    {
        // Area of a square formula: side * side
        return _side * _side;
    }
}
