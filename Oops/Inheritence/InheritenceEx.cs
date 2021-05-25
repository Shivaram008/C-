using System;
using System.Text;
public class Person
{
    private int Id;
    private string Pname,Paddress,Pphone;
    public int ID{get{return Id;} set{this.Id=value;}}
    public string Name{get{return Pname;} set{this.Pname=value;}}
    public string Address{get{return Paddress;} set{this.Paddress=value;}}
    public string Phone{get{return Pphone;} set{this.Pphone=value;}}

}
public class Student : Person
{
    private int Sclass;
    private Char Sgrade;
    public int Class{get{return Sclass;} set{this.Sclass=value;}}
    public char Grade{get{return Sgrade;} set{this.Sgrade=value;}}
    public override string ToString()
    {
        String s="";
        s+=("Student Details : \n");
        object[] vals={this.ID,this.Name,this.Phone,this.Address,this.Class,this.Grade};
        s+=(string.Format("{0,-5} {1,-7} {2,-12} {3,-15} {4,-5} {5,-5} \n","ID","NAME","PHONE","ADDRESS","CLASS","GRADE"));
        s+=(string.Format("{0,-5} {1,-7} {2,-12} {3,-15} {4,-5} {5,-5} \n",vals));
        return  s;
    }
}
public class InheritenceEx
{
    public static void Main()
    {
        Student s = new Student();
        s.ID=101;
        s.Name="Ram";
        s.Phone="8465814554";
        s.Address="Vissannapeta";
        s.Class=16;
        s.Grade='A';
        System.Console.WriteLine(s);      
    }
}