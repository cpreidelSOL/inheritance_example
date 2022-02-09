package jav;

class Shape{

    String Name; 

    public Shape(String name)
    {
        Name = name; 
    }

    void print()
    {
        System.out.println("My name is: " + Name);  
    }
}

class Rectangle extends Shape{

    Double Length; 
    Double Width; 

    public Rectangle(String name, Double length, Double width) {
        super(name);
        Length = length; 
        Width = width; 
    }

    public double GetArea()
    {
        return Length * Width; 
    }

    void print()
    {
        System.out.println("My name is: " + Name);  
        System.out.println("My Area is: " + GetArea());  
    }
}

public class inheritance{

    public static void main(String[] args) 
    {

        Rectangle rec = new Rectangle("Test", 2.0, 4.0); 

        rec.print();
        
    }

}