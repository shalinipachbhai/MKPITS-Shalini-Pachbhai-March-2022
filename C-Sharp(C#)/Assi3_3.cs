using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial
{
    //print factorial of any number using while loop
    internal class static 
        
    {
        static void Main(string[])
        {
            int i, num,fact=1;
            Console.WriteLine("enter number");
            num=Convert.ToInt32(Console.ReadLine());
            i=num;
            while(i>0)
            {
                fact=fact*i;
                i--;
            }
            Console.WriteLine(fact);
        }
    }
}