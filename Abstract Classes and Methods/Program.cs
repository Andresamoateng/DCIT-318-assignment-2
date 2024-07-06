using System;

// Abstract class Shape
public abstract class Shape
{
    public abstract double GetArea();
}

// Derived class Circle
public class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * radius * radius;
    }
}

// Derived class Rectangle
public class Rectangle : Shape
{
    private double length;
    private double width;

    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    public override double GetArea()
    {
        return length * width;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create instances of Circle and Rectangle
        Circle circle = new Circle(5.0);
        Rectangle rectangle = new Rectangle(4.0, 6.0);

        // Display their areas
        Console.WriteLine("Circle area: " + circle.GetArea());
        Console.WriteLine("Rectangle area: " + rectangle.GetArea());

        Console.ReadLine();
    }
}
