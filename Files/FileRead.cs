using System;  
using System.IO;  
namespace FileReading_SR  
{  
    class Program  
    {  
        class FileRead  
        {  
            public void ReadData()  
            {  
                FileStream fs = new FileStream(@"c:\Users\Ram Cheruku\CSharp-Samples\Files\Sample.txt", FileMode.Open, FileAccess.Read);  
                StreamReader sr = new StreamReader(fs);  
                Console.WriteLine("Program to show content of test file");  
                sr.BaseStream.Seek(0, SeekOrigin.Begin);  
                string str = sr.ReadLine();  
                while (str != null)  
                {  
                    Console.WriteLine(str);  
                    str = sr.ReadLine();  
                }  
                Console.ReadLine();
                sr.Close();  
                fs.Close();  
            }  
        }  
        static void Main(string[] args)  
        {  
            FileRead wr = new FileRead();  
            wr.ReadData();  
        }  
    }  
}  