using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop
{
    //print table of a number using for loop
    internal class static 
        
    {
        static void Main(string[])
        {
            int i,n;
            Console.WriteLine("Enter the number");
            num=Convert.ToInt32(Console.ReadLine());
            for(i=1;i<=10;i++)
            {
                int res=num*i;
                Console.WriteLine(num+"*"+i+"="+res);
            }
        }
    }
}   