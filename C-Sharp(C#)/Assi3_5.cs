using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_number
{
    //check whether entered number is prime or not
    internal class program 
        
    {
        static void Main(string[])
        {
           int i,num,count=0;
           Console.WriteLine("enter number");
           num=Convert.ToInt32(Console.ReadLine());
           for(i=1;i<=num;i++)
           {
            if(num%i==0)
            {
                count++;
            }
           }
           if(count==2)
           {
            Console.WriteLine("Prime number");
           }
           else
           {
            Console.WriteLine("not a prime number");
           }
        }
    }
}