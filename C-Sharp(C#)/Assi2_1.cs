using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2._2
{
    internal class Program
    {
        // wap to accept 2 no. and print greater no.

        static void Main()
        {
            int num1,num2;
            Console.WriteLine("enter number1");
            num= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number2");
            num2= Convert.ToInt32(Console.ReadLine());
            if(num1 >num2)
            {
                Console.WriteLine("num1 is greater");
            }
            else
            {
                Console.WriteLine("num2 is greater");
            }

        }

        
    }
}