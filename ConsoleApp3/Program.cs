
using System;
class Program1
{
static void Main(string[] args) 
    { 
    Console.WriteLine("Enter the length of the first side of the rectangle:");
        double side1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the length of the second side of the rectangle:");
        double side2 = double.Parse(Console.ReadLine());

        Rectangle rectangle = new Rectangle(side1, side2);

        double area = rectangle.CalculateArea();
        double perimeter = rectangle.CalculatePerimeter();

        Console.WriteLine($"Area of ​​the rectangle: {area}");
        Console.WriteLine($"Perimeter of a rectangle: {perimeter}");

        Console.ReadLine();
    }
}
