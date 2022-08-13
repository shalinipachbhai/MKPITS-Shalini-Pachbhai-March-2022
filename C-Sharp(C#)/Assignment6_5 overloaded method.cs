//Create a class student having fields rno,name,course,fees. create a method getdata with no parameters,create overloaded method with 2parameters, 3parameters,4 parameters and display method.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overloaded_method
{
    class student
    {
      int rno,fees;
      string name,course;
      public void getstudentdata()
      { 
        rno=13;
        name="Ishwari";
        course="B-Tec";
        fees=25000;
      }
      public void getstudentdata(int rno,string name)
      {
        this.rno=rno;
        this.name=name;
      }
      public void getstudentdata(int rno,string name,string course)
      {
        this.rno=rno;
        this.name=name;
        this.course=course;
      }
      public void getstudentdata(int rno, string name,string course,int fees)
      {
        this.rno=rno;
        this.name=name;
        this.course=course;
        this.fees;
      }
      public void display()
      {
        Console.WriteLine("roll no="+rno);
        Console.WriteLine("student name="+name);
        Console.WriteLine("course="+course);
        Console.WriteLine("Student fees="+fees);
      }
    }
    class program
    {
        static void main(string[]arg)
        {
            student s1=new student();
            s1.getstudentdata(13,"Ishwari");
            s1.display();
            Console.WriteLine("--------------Student Details----------");

            student s2=new student();
            s2.getstudentdata(13,"Ishwari","B-Tec");
            s2.display();
            Console.WriteLine("--------------Student Details----------");

            student s3=new student();
            s3.getstudentdata(13,"Ishwari","B-Tec",25000);
            s3.display();
            Console.WriteLine("--------------Student Details----------");

            Console.WriteLine();
        }
    }
}