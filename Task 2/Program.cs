public class Circle
{
    public const double PI = 3.14;
    public double CalculateArea(double radius)
    {
        return PI * radius * radius;
    }
    public double CalculatePerimeter(double radius)
    {
        return 2 * PI * radius;
    }
    static void Main(string[] Args)
    {
        Console.WriteLine($"Value of P1: {Circle.PI}");

        Circle c = new Circle();
        double radius = 5;
        Console.WriteLine($"Area: {c.CalculateArea(radius)}");
        Console.WriteLine($"Perimeter: {c.CalculatePerimeter(radius)}");
    }
}