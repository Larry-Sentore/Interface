public interface IShape
{
    public double CalculateArea();
    public double CalculatePerimeter();

}

public class Trapezium : IShape
{
    private int numberOfSides = 4;
    private int sideA = 3;
    private int sideB = 4;
    private int sideC = 7;
    private int sideD = 6;
    private int height = 5;
    public double CalculateUnknownSides()
    {
        return numberOfSides;
    }

    public double CalculateArea()
    {
        return (sideA + sideB) * height / 2;
    }

    public double CalculatePerimeter()
    {
        return sideA + sideB + sideC + sideD;
    }
}

public class Circle : IShape
{
    private int radius = 5;

    public double CalculateArea()
    {
        return radius * radius * 3.14;
    }

    public double CalculateRadius()
    {
        return radius;
    }

    public double CalculatePerimeter()
    {
        return 2 * radius * 3.14;
    }
}

public class Nonagon : IShape
{
    private int numberOfSides = 9;
    private int sideLength = 4;

    public double CalculateArea()
    {
        //using approximate values for 9/4 and cot(π/9)
        return 2.25 * sideLength * sideLength * 2.74;
    }

    public double CalculatePerimeter()
    {
        //assuming all sides are equal
        return numberOfSides * sideLength;
    }

    public double CalculateNumberOfSides()
    {
        return numberOfSides;
    }
}

public static class Program
{
    public static void Main()
    {
        IShape trapezium = new Trapezium();
        Trapezium trapeziumsides = new Trapezium();
        IShape circle = new Circle();
        Circle circleRadius = new Circle();
        IShape nonagon = new Nonagon();
        Nonagon nonagonSides = new Nonagon();

        Console.WriteLine("-- Trapezium ---");
        Console.WriteLine("Number of sides in Trapezium: " + trapeziumsides.CalculateUnknownSides());
        Console.WriteLine("Trapezium Area: " + trapezium.CalculateArea());
        Console.WriteLine("Trapezium Perimeter: " + trapezium.CalculatePerimeter());

        Console.WriteLine("-- Circle ---");
        Console.WriteLine("Circle Area: " + circle.CalculateArea());
        Console.WriteLine("Circle Radius: " + circleRadius.CalculateRadius());
        Console.WriteLine($"Circle Perimeter: {circle.CalculatePerimeter():F2}");

        Console.WriteLine("-- Nonagon ---");
        Console.WriteLine($"Nonagon Area: {nonagon.CalculateArea():F2}");
        Console.WriteLine("Nonagon Perimeter: " + nonagon.CalculatePerimeter());
        Console.WriteLine("Number of sides in Nonagon: " + nonagonSides.CalculateNumberOfSides());     
    }
}