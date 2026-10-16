using System;

class Point
{
    public double X, Y;

    public Point() { X = 0; Y = 0; }

    public Point(double x, double y) { X = x; Y = y; }

    public override string ToString() { return $"({X}; {Y})"; }
}

class Program
{
    static void Main()
    {
        Point p1 = new Point();
        Point p2 = new Point(3, 7.5);
        Console.WriteLine("Без параметрів: " + p1);
        Console.WriteLine("З параметрами: " + p2);
    }
}
