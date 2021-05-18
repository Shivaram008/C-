using System;
class Child
{
    public static int Add(int a,int b)
    {
        return a+b;
    }
}

class Parent
{
    public static void Main()
    {
        //Child n = new Child();
        System.Console.WriteLine(Child.Add(10,11));
    }
}