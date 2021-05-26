using System;
public abstract class Shape
{
    public double radius,width,height;
    public const float PI=3.14f;
    public abstract double GetArea();
}
public class Rectangle : Shape
{
    public Rectangle(double width,double height)
    {
        this.width=width;
        this.height=height;
    }
    public override double GetArea()
    {
        return width*height;
    }
}
public class Circle : Shape
{
    public Circle(double radius)
    {
        this.radius=radius;
    }
    public override double GetArea()
    {
        return PI*radius*radius;
    }
}
public class AbstractDemo
{
    public static void Main(String[] args)
    {
        Rectangle r = new Rectangle(10,20);
        System.Console.WriteLine(r.GetArea());
        Circle c = new Circle(10);
        System.Console.WriteLine(c.GetArea());
    }
}