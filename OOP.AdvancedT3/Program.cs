


using OOP.AdvancedT3;
using System;

Rectangle rectangle1 = new Rectangle("Green", 6, 8);
Rectangle rectangle2 = new Rectangle("Yellow", 10, 12);

Circle circle1 = new Circle("Purple", 3);
Circle circle2 = new Circle("Orange", 5);

List<Shape> shapes = new List<Shape> { rectangle1, rectangle2, circle1, circle2 };

foreach (Shape shape in shapes)
{
    shape.CalculateArea();
}

shapes.Sort((shape1, shape2) => shape2.Area.CompareTo(shape1.Area));

foreach (Shape shape in shapes)
{
    Console.WriteLine(shape.Color + ": " + shape.Area);
}

/* Outputs:
Yellow: 120
Purple: 28.2743338823081
Orange: 78.5398163397448
Green: 48
*/

double totalPerimeter = 0;
foreach (Shape shape in shapes)
{
    totalPerimeter += shape.GetPerimeter();
}

Console.WriteLine("Total perimeter: " + totalPerimeter + " meters"); // Outputs "Total perimeter: 122,26548245744 inches"