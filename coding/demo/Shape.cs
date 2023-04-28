using System;

public class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Drawing a generic shape");
    }
}

public class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a circle");
    }

    public void Draw(int radius)
    {
        Console.WriteLine("Drawing a circle with radius " + radius);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Shape shape = new Shape();
        shape.Draw(); // Output: Drawing a generic shape

        Circle circle1 = new Circle();
        circle1.Draw(); // Output: Drawing a circle

        Circle circle2 = new Circle();
        circle2.Draw(10); // Output: Drawing a circle with radius 10
    }
}
