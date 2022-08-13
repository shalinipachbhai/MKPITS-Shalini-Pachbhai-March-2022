using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._1
{
    internal class Program
    {
        // Wap to accept length and breadth and display the area of a Rectangle.

        static void Main(string[] args)
        {
            int length, breadth;
            Console.WriteLine("enter length ");
            length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter breadth");
            breadth = Convert.ToInt32(Console.ReadLine());
            int area = length * breadth;
            Console.WriteLine("area of rectangle = " + area);
            Console.ReadLine();


        }
    }
}
