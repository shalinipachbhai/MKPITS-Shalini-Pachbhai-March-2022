using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace table
{
    //print table using do while loop
    internal class static 
        
    {
        static void Main(string[])
        {
           int i=1,num,res;
           Console.WriteLine("Enter number");
           num=Convert.ToInt32(Console.ReadLine());
           do
           {
              res=num*i;
              Console.WriteLine(num+"*"+i+"="+res);
              i++;
           }while(i<=10);
        }
    }
}