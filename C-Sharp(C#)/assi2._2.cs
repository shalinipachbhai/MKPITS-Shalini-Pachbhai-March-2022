using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2._2
{
    internal class Program
    {
        //5 wap to accept 3 no. and display greater no.
        static void Main()
        {
            int n1,n2,n3;
            Console.WriteLine("enter number1");
            n1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number2");
            n2= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number3");
            n3= Convert.ToInt32(Console.ReadLine());
            if(n1 >n2 && n1>n3)
            {
                Console.WriteLine("num1 is greater");
            }
            else if(n2>n1 && n2>n3)
            {
                Console.WriteLine("num2 is greater");
            }
            else
            {
               console.WriteLine("n3 is greater");
            }

        }
    }
}    