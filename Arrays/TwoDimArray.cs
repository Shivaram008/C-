using System;
using System.Collections.Generic;
int[,] a=new int[3,4];
int k=1;

//Initializing the array
for(int i=0;i<a.GetLength(0);i++)
{
    for(int j=0;j<a.GetLength(1);j++)
    {
        a[i,j]=k;
        k+=1;
    }
}

//Printing the array
for(int i=0;i<a.GetLength(0);i++)
{
    for(int j=0;j<a.GetLength(1);j++)
    {
        System.Console.Write(a[i,j]+" ");
    }
    System.Console.WriteLine();
}