using System;
namespace Inheritence
{
    public class Class1
    {
        private int a;
        public Class1(int i)
        {
            this.a=i;
            System.Console.WriteLine("Class1 Constructor "+a);
        }
        public void Example1()
        {
            System.Console.WriteLine("Inside Example1");
        }
        public void Example2()
        {
            System.Console.WriteLine("Inside Example2");
        }
    }
    public class Class2 : Class1
    {
        
        public Class2(int a) : base(a)
        {
            System.Console.WriteLine("Class2 Constructor");
        }
        public void Example3()
        {
            System.Console.WriteLine("Inside Example3");
        }
        public static void Main()
        {
            Class2 c=new Class2(10);
            
            c.Example1();
            c.Example2();
            c.Example3();
            System.Console.WriteLine(c.GetType());

            Class1 p=new Class1(10);
            p.Example1();
            p.Example2();
            //p.Example3();         Error will occur
            System.Console.WriteLine(p.GetType());
            object obj=new object();
            System.Console.WriteLine(obj.GetType());
        }
    }
}