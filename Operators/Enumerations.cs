using System;
public class Enumerations
{
    public enum Days
    {
        Monday,Tuesday,Wednesday,Thursday,Friday
    };
    public static void Main()
    {
        Days d;
        var k=Enum.GetValues(typeof(Days)).Length;
        System.Console.WriteLine($"Length of Enum list is {k}");
        var z=Enum.GetNames(typeof(Days));
        foreach(var i in z)
            System.Console.WriteLine(i);
        
    }
}