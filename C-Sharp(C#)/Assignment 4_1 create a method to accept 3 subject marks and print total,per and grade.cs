   // create a method to accept 3subject marks and print total,per and grade
 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dis_tot_per_grade
{
    internal class Program
    {
        static void dis(int n1,int n2,int n3)
        {
            int Total = n1 + n2 + n3;
            float per = (Total / 300.0f) * 100;         
            Console.WriteLine("\nTotal: "+Total);
            Console.WriteLine("Percentage: "+per);
            if (per >= 75)
            {
                Console.WriteLine("grade: Distinction");
            }
            else if(per>=60 && per<75)
            {
                Console.WriteLine("grade: First Division");
            }
            else if (per >= 40 && per < 60)
            {
                Console.WriteLine("grade: Second Division");
            }
            else
            {
                Console.WriteLine("Fail");
            }

        }
        static void Main(string[] args)
        {
            int n1, n2, n3;
            Console.Write("Enter subject 1 marks: ");
            n1=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter subject 2 marks: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter subject 3 marks: ");
            n3 = Convert.ToInt32(Console.ReadLine());
            dis(n1, n2, n3);

        }
        
    }
}  