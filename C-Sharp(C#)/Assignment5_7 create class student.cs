//create a class student having fields rno, name, mathsmarks, chemmarks, phymarks, total, per, grade and method result to calculate and display total, per and grade

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace create_a_students_class
{
    public class Students
    {
        public int roll_no;
        public string name;
        public byte maths_marks;
        public byte che_marks;
        public byte phy_marks;
        public float per;
        public int total;
        public string grade;

        public void result(int roll_no,string name,int total,float per,string grade)
        {
            Console.WriteLine("");
            Console.WriteLine("Roll No: "+roll_no); 
            Console.WriteLine("Name: "+name);
            Console.WriteLine("Total: "+total);
            Console.WriteLine("Percentage: "+per);
            Console.WriteLine("Grade: "+grade);

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string grade;
            Students stud = new Students();
            Console.Write("Enter student roll number: ");
            int roll_no=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter student name: ");
            string name =Console.ReadLine();
            Console.Write("Enter student maths marks: ");
            byte maths_marks = Convert.ToByte(Console.ReadLine());
            Console.Write("Enter student chemistry marks: ");
            byte che_marks = Convert.ToByte(Console.ReadLine());
            Console.Write("Enter student physics marks: ");
            byte phy_marks = Convert.ToByte(Console.ReadLine());
            int total=maths_marks+che_marks+phy_marks;
            float per = (total / 300.0f) * 100;
            if(per>=75)
            {
                grade = "distinction";
            }
            else if(per>=60 && per<75)
            {
                grade = "first division";
            }
            else if (per >= 40 && per < 60)
            {
                grade = "second division";
            }
            else
            {
                grade = "Fail";
            }

            stud.result(roll_no, name, total, per, grade);
        }
    }
}