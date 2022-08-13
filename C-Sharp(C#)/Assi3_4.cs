using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial
{
    //print factorial of any number using do while loop
    internal class static 
        
    {
        static void Main(string[])
        {
            int i, num,fact=1;
            Console.WriteLine("enter number");
            num=Convert.ToInt32(Console.ReadLine());
            i=num;
            do
            {
              fact=fact*i;
                i--;  
            }while(i>0)
            Console.WriteLine(fact);
        }
    }
}