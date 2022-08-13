using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2._2
{
    internal class Program
    {
        // wap to accept a no. and print whether it is even no or oddno  using if else

        static void Main()
        {
            int num;
            Console.WriteLine("enter number");
            num= Convert.ToInt32(Console.ReadLine());
            
            if(num%2==0)
            {
                Console.WriteLine("it is even no");
            }
            else
            {
                Console.WriteLine("it is odd no");
            }

        }

        
    }
}