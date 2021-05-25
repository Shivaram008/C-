using System;
public class Variables
{
    int a=20;
    static int b=100;
    const float PI=3.14f;
    readonly bool flag;
    public Variables(int x,bool flag)
    {
        this.a=x;
        this.flag=flag;
    }
    public static void Main()
    {
        System.Console.WriteLine("b = "+b);
        System.Console.WriteLine("PI = "+PI);
        
        //PI=20;        constants can not be modified
        
        b=200;          //we can modify static variables
        System.Console.WriteLine("b = "+b);
        
        Variables v=new Variables(10,true);
        System.Console.WriteLine(v.a+"  "+v.flag);

        v.a+=20;            //object specific modifications are done on non-static variables
        //v.flag=false;     //read-only variables can not be modified once initialized
        System.Console.WriteLine(v.a+"  "+v.flag);
    }
}