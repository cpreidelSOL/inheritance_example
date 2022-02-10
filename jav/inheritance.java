package jav;

class BuildingElement{

    String Name; 

    public BuildingElement(String name)
    {
        Name = name; 
    }

    void print()
    {
        System.out.println("My name is = " + Name);  
    }
}

class Wall extends BuildingElement{

    Double Length; 
    Double Thickness; 
    Double Height;

    public Wall(String name, Double length, Double thickness, Double height) {
        super(name);
        Length = length; 
        Thickness = thickness;
        Height = height; 
    }

    public double GetVolume()
    {
        return Length * Thickness * Height; 
    }

    void print()
    {
        super.print();
        System.out.println("My volume is = " + GetVolume());  
    }
}

public class inheritance{

    public static void main(String[] args) 
    {
        Wall wall = new Wall("Test_Wall", 2.0, 0.24, 2.0); 
        wall.print();
    }

}