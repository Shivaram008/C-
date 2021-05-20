using System;
String s=new string("Hello");
String s1=s;
System.Console.WriteLine(s1.Equals(s));
System.Console.WriteLine($"{s.GetHashCode()} {s1.GetHashCode()}");
s="Hai";
System.Console.WriteLine(s1);
System.Console.WriteLine($"{s.GetHashCode()} {s1.GetHashCode()}");