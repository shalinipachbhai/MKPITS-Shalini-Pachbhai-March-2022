//create a class employee having fields empno,empname,designation and salary create a constructor with no parameters and method display
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_employee
{
    class employee
    {
        int empno;
        string empname,designation;
        int salary;
    }//constructor with no parameters
    public employee()
    {
        empno=12;
        empname="ram";
        designation="yavatmal";
        salary=25000;
    }
    public void display()
    {
        Console.WriteLine("employee no="+empno);
        Console.WriteLine("employee name="+empname);
        Console.WriteLine("employee designation="+designation);
        Console.WriteLine("employee salary="+salary);
    }
}
class program
{
    static void main(string[]arg)
    {
        employee b=new employee();//this will call constructor automaticlly
        b.display();
        Console.ReadLine();
    }
}