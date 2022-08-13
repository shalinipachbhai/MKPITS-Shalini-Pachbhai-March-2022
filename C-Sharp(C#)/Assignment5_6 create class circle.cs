//create a class circle having fields radius and method calculate area and calculate circ
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_circle
{
    public class circle
    {
      public double rad;

      public void calculatearea(double rad)
      {
        this.rad=rad;
        double res=rad*rad*3.14;
        Console.WriteLine("Area of circle="+res);
      }
       public void calculatecirc(double rad)
        {   this.rad = rad;
            double res = 2 *3.14*rad;
            Console.WriteLine("Circumference of circle= " + res);
            // Console.WriteLine("Circumference of circle= " + (2*3.14 * rad));
        }
    }
  internal class Program
    {
        static void Main(string[] args)
        {
            circle cir = new circle();
            Console.Write("Enter radius of circle: ");
            double rad=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            cir.calculatearea(rad);
            cir.calculatecirc(rad);
        }
    }
}