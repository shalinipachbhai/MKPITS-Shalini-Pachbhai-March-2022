using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    //wap to accept a no. and print whether it is prime no or not.

    class Prime
    {
        static void Main()
        {
            int num;
             Console.WriteLine("enter number");
            num= Convert.ToInt32(Console.ReadLine());
            if(num==2)
            {
                 Console.WriteLine("prime no");
            }
            else{
                console.WriteLine("not prime no")
            }
        }
    }
}
