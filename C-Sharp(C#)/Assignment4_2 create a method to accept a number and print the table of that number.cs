//create a method to accept a number and print the table of that number
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_table_by_method
{
    internal class Program
    {
        static void print(int n)
        {
            for(int i=1;i<=10;i++)
            {

                Console.WriteLine("{0}*{1}={2}",n,i,n*i);
            }
        }
        static void Main(string[] args)
        {
            int num;
            Console.Write("Enter any number: ");
            num=Convert.ToInt32(Console.ReadLine());
            print(num);
        }
    }
}