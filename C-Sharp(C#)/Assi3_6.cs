using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_number
{
    //print prime number using for loop
    internal class static 
        
    {
        static void Main(string[])
        {
           int i,j;
           for(i=1;i<=20;i++)
           {
            int count=0;
            for(j=1;j<=i;j++)
            {
                if(i%j==0)
                {
                    count++;
                }
            }
            if(count==2)
            {
                Console.Write(i+"");
            }
           }
        }
    }
}