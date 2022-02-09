using System;

abstract class Shape
{
    public Shape(string name)
    {
        Name = name; 
    }

    public string Name;

    public abstract double GetArea();

    public void Print()
    {
        Console.Write("My name is: " + Name);
    }

}

class Rectangle : Shape
{
    public double Length;
    public double Width;
    
    public Rectangle(string name, double length, double width) : base(name)
    {
        Length = length;
        Width = width;
    }
    public override double GetArea()
    {
        return Length * Width;
    }

    public void Print()
    {
        Console.WriteLine("My name is: " + Name);
        Console.WriteLine("My Area is: " + GetArea());
    }
}


class Program
{
    static void Main(string[] args)
    {
        var rec = new Rectangle("Test_Rec", 2, 4);
        rec.Print();
    }
}