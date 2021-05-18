using System;
using System.Collections.Generic;
int[] a=new int[]{1,2,3,4,5};

int[] b=new int[5];

Array.Copy(a,b,5);
foreach(var i in b)
{
    Console.Write($"{i} ");
}
Console.BackgroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine();
/*int ele=int.Parse(Console.ReadLine());
var z=Array.BinarySearch(a,ele);
if(z<0)
{
    Console.WriteLine("Element not present in the array");
}
else{
    Console.WriteLine($"Element present at the index {z}");
}*/
int[] values = new int[50];
Random rnd =new Random();
for(int i=0;i<50;i++)
{
    values[i]=rnd.Next(0,50);
}
foreach(var i in values)
{
    Console.Write($"{i} ");
}