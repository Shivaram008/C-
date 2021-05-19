using System;
using System.Globalization;
public class StringFormatters
{
    public static void Main(String[] args) 
    {
        CultureInfo cultures=new CultureInfo("en-US");
        DateTime s=new DateTime(2019,6,6);
        string output = String.Format(cultures,"{0,11:T}",DateTime.Now);
        Console.WriteLine(output);
        Console.WriteLine($"{cultures.Name}");
        foreach(var i in args)
        {
            Console.WriteLine(i);
        }
        //Console.WriteLine($"{s.CultutreInfo.Name}");

        
        /*string s = String.Format("{0:d} At {0:t}, the temperature is {1}°C.",DateTime.Now, 20.4);
        Console.WriteLine(s);

        int[] years = { 2013, 2014, 2015 };
        int[] population = { 1025632, 1105967, 1148203 };
        String st = String.Format("{0,-10} {1,-10}\n\n", "Year", "Population");
        for(int index = 0; index < years.Length; index++)
            st += String.Format("{0,-10} {1,-10:N0}\n",years[index], population[index]);
        Console.WriteLine($"{st}");

        
        var value = String.Format(new System.Globalization.CultureInfo("en-US"),"{0,-10:c}", 126347.894m);         
        Console.WriteLine(value);

    
        string[] names = { "Balto", "Vanya", "Dakota", "Samuel", "Koani", "Yiska", "Yuma" };
        string output = names[0] + ", " + names[1] + ", " + names[2] + ", " + names[3] + ", " + names[4] + ", " + names[5] + ", " + names[6];  
        output += "\n";  
        var date = DateTime.Now;
        output += String.Format("It is {0:t} on {0:d}. The day of the week is {1}.", date, date.DayOfWeek);
        Console.WriteLine(output);

        Console.WriteLine($"It is {date:t} on {date:d}. The day of the week is {date.DayOfWeek}.");

        var value1=126347.894m;
        Console.WriteLine(String.Format("{0,12:#.00000} {0,16:0,000.00} {0,20:000.00#}", value1));
        */
    }
}