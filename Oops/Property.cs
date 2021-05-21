using System;
class PropertiesDemo
{
    private String SName1;
    private int SAge;
    public string Name
    {
        get
        {
            return Name;
        }
        set
        {
            System.Console.WriteLine("hi"); 
            Name=value;
        }
    }
    public int Age
    {
        get;set;
    }
    
}
public class Property
{
    public static void Main(string[] args)
    {
        PropertiesDemo e=new PropertiesDemo();
        e.Name="Ram";
        e.Age=20;
        System.Console.WriteLine("Student Details :");
        System.Console.WriteLine("{0,-10} {1,-10}",e.Name,e.Age);

    }
}