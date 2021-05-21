using System;
using System.Collections;
namespace InheritenceEx
{
    public class Class1
    {
        public void A()
        {
            System.Console.WriteLine("Parent class A");
        }
    }

    public class Class2 : Class1
    {
        public void A()
        {
            System.Console.WriteLine("Childs class A");
        }
    }

    public class Inheritence
    {
        public static void Main()
        {
            Class2 i = new Class2();
            i.A();
        }
    }
}