using System;
class PropDemo
{
    private static string Sname;
    private int Id;
    public string Name
    {
        get{return Sname;}set{ Sname=value;}
    }
    
    public int ID
    {
        get{return Id;}set{Id=value;}
    }

    public void Display()
    {   
        System.Console.WriteLine("Student Details :");
        System.Console.WriteLine($"{Sname,-10} {Id,-10}");
    }
}
public class Properties
{
    public static void Main()
    {
        PropDemo p =new PropDemo();
        p.Name="Hello";
        p.ID=101;
        p.Display();     
        System.Console.WriteLine(p.Name);  
    }
}
