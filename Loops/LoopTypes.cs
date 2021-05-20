using System;
class Test
{
    public static void Main()
    {
        int i=1;
         //do-while loop
        do
        {
            Console.WriteLine("Do While Loop");
            i++;
        }while(i<4); 

        //while loop
        i=1;
        while(i<4)
        {
            Console.WriteLine("While Loop {0}",i);
            i++;
        }   

        //for loop
        for(i=1;i<4;i++)
        {
            Console.WriteLine("Hello world {0}",i);
        }   

        //infinite while loop
        i=1;
        while (true)
        {
            Console.WriteLine("Infinite while loop {0}",i);
            if(i==20)
                break;
            i++;
        }   

        //infinite for loop
        i=1;
        for(;;)
        {
            Console.WriteLine("Infinite for loop {0}",i);
            if(i==20)
                break;
            i++;
        }   

        int[] a=new int[]{1,2,3,4,5};
        foreach(var j in a)
        {
            System.Console.Write($"{j} ");
        }

    }
}
