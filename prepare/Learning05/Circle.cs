// Circle class inherits from Shape class
public class Circle : Shape
{
    // Private field to store the radius of the circle
    private double _radius;

    // Constructor for Circle class, takes color and radius as parameters
    // Calls the base class constructor to initialize the color field
    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    // Override the GetArea method from the Shape class
    // Calculates and returns the area of the circle
    public override double GetArea()
    {
        // Area of a circle formula: π * radius^2
        return _radius * _radius * Math.PI;
    }
}
