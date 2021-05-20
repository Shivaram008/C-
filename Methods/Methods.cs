using System;
public class Methods
{
    public static void swap(ref int x,ref int y)
    {
        x+=10;
        y+=20;
    }

    public static void MyMethod()
    {
        Console.WriteLine("Hello From MyMethod");
    }

    public static void MyMethod(int a)
    {
        Console.WriteLine("Hello");
    }

    public static void UpdateArray(int[] arr)
	{
		for (int i = 0; i < arr.Length; i++)
			arr[i] = arr[i] + 10;
	}
    public static void call(string s)
    {
        s+=" Hai";
    }
    public static void Main(string[] args)
    {
        int x=10,y=20;
        Console.WriteLine($"Values before swap {x} , {y}");
        Methods n = new Methods();
        swap(ref x,ref y);
        Console.WriteLine($"Values after swap {x} , {y}");
        MyMethod(5);
        MyMethod();
        int[] nums = {1, 2, 3, 4, 5};
		UpdateArray(nums);
		foreach (var item in nums)
			Console.WriteLine(item);
        String s="Hello";
        call( s);
        System.Console.WriteLine(s);       
    }
}