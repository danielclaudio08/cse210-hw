using System;

class Program
{
  static void Main(string[] args)
  {
    Console.Clear();
    Square square = new Square("Blue", 6);
    Console.WriteLine($"Square Color: {square.GetColor()}");
    Console.WriteLine($"Square Area: {square.GetArea()}");

    Rectangle rectangle = new Rectangle("Green", 12, 20);
    Console.WriteLine($"\nRectangle Color: {rectangle.GetColor()}\nRectangle Area: {rectangle.GetArea()}");

    Circle circle = new Circle("Yellow", 10);
    Console.WriteLine($"\nCircle Color: {circle.GetColor()}\nCircle Area: {circle.GetArea()}");

    List<Shape> shapes = new List<Shape>();
    shapes.Add(new Square("Dark-Green", 16));
    shapes.Add(new Rectangle("Orange", 13, 29));
    shapes.Add(new Circle("Violet", 23));

    foreach (Shape S in shapes)
    {
      string color = S.GetColor();
      double area = S.GetArea();

      Console.WriteLine($"\nShape Color: {color}\nShape Area: {area}");
    }

  }
}