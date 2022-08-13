using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._2
{
    internal class Program
    {
        // Wap to accept 3 number and display the addition of Three Number.


        static void Main(string[] args)
        {
            int num1,num2,num3;
Console.WriteLine("enter number1 ");
num1 =Convert.ToInt32( Console.ReadLine()); 
Console.WriteLine("enter number2 ");
num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter number3 ");
num3 =Convert.ToInt32( Console.ReadLine()); 
int result = num1+num2+num3;
Console.WriteLine("addition of 3num = " + result );
Console.ReadLine();




        }
    }
}
