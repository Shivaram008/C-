using System;
class PropDemo
{
    private static string Sname;
    private int Id;
    public string Name
    {
        get{return Sname;}set{ Sname=value;}
    }

    public void Display()
    {
        System.Console.WriteLine(Sname);
    }
}
public class Properties
{
    public static void Main()
    {
        PropDemo p =new PropDemo();
        p.Name="Hello";
        p.Display();     
        System.Console.WriteLine(p.Name);  
    }
}