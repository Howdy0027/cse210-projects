using System;
using System.Collections.Generic; // Required for List<T>

class Program
{
    static void Main(string[] args)
    {
        // Create a list to hold shapes
        List<Shape> shapes = new List<Shape>();

        // Create a new Square object with color "Red" and side length 3
        Square s1 = new Square("Red", 3);
        // Add the Square object to the shapes list
        shapes.Add(s1);

        // Create a new Rectangle object with color "Blue", length 4, and width 5
        Rectangle s2 = new Rectangle("Blue", 4, 5);
        // Add the Rectangle object to the shapes list
        shapes.Add(s2);

        // Create a new Circle object with color "Green" and radius 6
        Circle s3 = new Circle("Green", 6);
        // Add the Circle object to the shapes list
        shapes.Add(s3);

        // Iterate over each shape in the shapes list
        foreach (Shape s in shapes)
        {
            // Get the color of the shape
            string color = s.GetColor();

            // Get the area of the shape
            double area = s.GetArea();

            // Print the color and area of the shape
            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}
