using System;

namespace AbstractClassExample
{
    abstract class Shape
    {
        public abstract double GetArea();
    }

    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double GetArea()
        {
            return Width * Height;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Shape myCircle = new Circle(5.0);
            Shape myRectangle = new Rectangle(4.0, 6.0);

            Console.WriteLine($"Area of Circle: {myCircle.GetArea()}");
            Console.WriteLine($"Area of Rectangle: {myRectangle.GetArea()}");
        }
    }
}
