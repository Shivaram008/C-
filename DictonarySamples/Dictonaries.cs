using System;
using System.Collections.Generic;
public class Program
{
    public static void Display(Dictionary<int,string> d)
    {
        foreach(var i in d)
        {
            System.Console.WriteLine($"{i.Key} : {i.Value}");
        }
        System.Console.WriteLine(d.Count);
    }
    
    public static void Main()
    {
        Dictionary <int ,string> d =new Dictionary<int,string>();
        d.Add(1,"one");
        d.Add(2,"Two");
        SortedDictionary<int,int> b=new SortedDictionary<int, int>();
        b.Add(5,7);
        b.Add(2,4);
        b.Add(1,2);
        Display(d);
        //Display(b);
        System.Console.WriteLine(d.Count);
        string value="";
        //System.Console.WriteLine(d.TryGetValue(1,out value));
        System.Console.WriteLine(value);
        d.Clear();      //To clear the dictionary
        Display(d);
    }
    
}