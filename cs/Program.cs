using System;

class BuildingElement
{
    public BuildingElement(string name)
    {
        Name = name; 
    }
    public string Name;
    public void Print()
    {
        Console.Write("My name is: " + Name + "\n");
    }
}

class Wall : BuildingElement
{
    public double Length;
    public double Thickness;
    public double Height;
    
    public Wall(string name, double length, double thickness, double height) : base(name)
    {
        Length = length;
        Thickness = thickness;
        Height = height; 
    }
    public double GetVolume()
    {
        return Length * Thickness * Height;
    }

    public void Print()
    {
        base.Print();
        Console.WriteLine("My Volume is: " + GetVolume());
    }
}

class Program
{
    static void Main(string[] args)
    {
        var wall = new Wall("Test_Wall", 2, 0.24, 2);
        wall.Print();
    }
}