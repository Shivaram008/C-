using System;
using System.Collections.Generic;
namespace StructureDict
{
    class Student 
    {  
        public int StudentId { get; set; }  
        public string StudentName { get; set; }  
        public string Gender { get; set; }  
        public double TotalMarks { get; set; }  
    } 

    class Program 
    {  
        static void Main(string[] args) 
        {  
            Student sOne = new Student() { StudentId = 201, StudentName = "Aiden Pearce", Gender = "Male", TotalMarks = 455.50 };  
            Student sTwo = new Student() { StudentId = 202, StudentName = "Lara Croft", Gender = "Female", TotalMarks = 455.50 };  
            Student sThree = new Student() { StudentId = 203, StudentName = "Black Widow", Gender = "Female", TotalMarks = 342 };  
            Student sFour = new Student() { StudentId = 204, StudentName = "Sam Fisher", Gender = "Male", TotalMarks = 550.12 };  
            Student sFive = new Student() { StudentId = 205, StudentName = "Max Payne", Gender = "Male", TotalMarks = 288.50 };  

            Dictionary<int, Student> StudentDictionary = new Dictionary<int, Student>();

            StudentDictionary.Add(sOne.StudentId, sOne);  
            StudentDictionary.Add(sTwo.StudentId, sTwo);  
            StudentDictionary.Add(sThree.StudentId, sThree);  
            StudentDictionary.Add(sFour.StudentId, sFour);  
            StudentDictionary.Add(sFive.StudentId, sFive); 

            var s = StudentDictionary[202];  
            Console.WriteLine("Student Name is {0}",s.StudentName);

            foreach (KeyValuePair<int,Student> students in StudentDictionary) 
            {  
                Student ss = students.Value;  
                Console.WriteLine(ss.StudentName);  
            }  

            try
            {
                StudentDictionary.Add(sFive.StudentId, sFive); 
            }
            catch(Exception e)
            {
                System.Console.WriteLine(e.Message);
            }

            int TotalItem = StudentDictionary.Count;  
            Console.WriteLine(TotalItem); 
        }  
} 
}