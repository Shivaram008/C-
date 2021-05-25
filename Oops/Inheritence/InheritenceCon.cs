using System;
using System.Text;
public class Person
{
    public int Id;
    public string Pname,Paddress,Pphone;
    public Person(int id,string name,string phone,string address)
    {
        this.Id=id;
        this.Pname=name;
        this.Paddress=address;
        this.Pphone=phone;
    }

}
public class Student : Person
{
    public int Sclass;
    public Char Sgrade;
    public Student(int id,string name,string phone,string address,int cls,char grade) :base(id,name,phone,address)
    {
        this.Sclass=cls;
        this.Sgrade=grade;
    }
    public override string ToString()
    {
        String s="";
        s+=("Student Details : \n");
        object[] vals={this.Id,this.Pname,this.Pphone,this.Paddress,this.Sclass,this.Sgrade};
        s+=(string.Format("{0,-5} {1,-7} {2,-12} {3,-15} {4,-5} {5,-5} \n","ID","NAME","PHONE","ADDRESS","CLASS","GRADE"));
        s+=(string.Format("{0,-5} {1,-7} {2,-12} {3,-15} {4,-5} {5,-5} \n",vals));
        return  s;
    }
}
public class InheritenceEx
{
    public static void Main()
    {
        Student s = new Student(101,"Ram","8465814554","Vissannapeta",16,'A');
        System.Console.WriteLine(s);      
    }
}