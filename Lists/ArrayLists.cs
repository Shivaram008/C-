using System;
using System.Collections;
public class ArrayLists
{
    
    public static void Main()
    {
        ArrayList a = new ArrayList(); 
        a.Add(1);
        a.Add("Ram");
        a.Add(2.5);
        a.Add(true);
        a.Add(null);

        System.Console.WriteLine("Initial Array List is :");
        foreach(var i in a)
        {
            System.Console.Write($"{i}, ");
        }
        System.Console.WriteLine();

        a.Insert(4,"Hello");
        foreach(var i in a)
        {
            System.Console.Write($"{i}, ");
        }
        System.Console.WriteLine();

        ArrayList arlist1 = new ArrayList(){100, 200, 600 };
        a.InsertRange(4,arlist1);
        a.Remove(null);
        System.Console.WriteLine("After Insert Range the list is :");
        foreach(var i in a)
        {
            System.Console.Write($"{i}, ");
        }
        System.Console.WriteLine();

    }
}