//create a class calculate having fields num1,num2 and 4 methods addition,substraction, multiplication and division

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_calculate
{
    public class calculate
    {
        public float num1;
        public float num2;
        public void addition(float num1,float num2)
        {
            Console.WriteLine("Addition:"+(num1+num2));
        }
        public void Substraction(float num1,float num2)
        {
            Console.WriteLine("Substraction:"+(num1-num2));
        }
        public void multiplication(float num1,float num2)
        {
            Console.WriteLine("Multiplication:"+(num1*num2));
        }
        public void Division(float num1,float num2)
        {
            Console.WriteLine("Division:"+(num1/num2));
        }
    }
    internal class program
    {
        static void main(string[]arg)
        {
            calculate cal=new calculate();
            Console.Write("Enter first number:");
            float num1=Convert.ToSingle(Console.ReadLine());

            Console.Write("Enter second number:");
            float num2=Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("");
            cal.Addition(num1,num2);
            Console.WriteLine("");
            cal.Substraction(num1,num2);
            Console.WriteLine("");
            cal.Multiplication(num1,num2);
            Console.WriteLine("");
            cal.Division(num1,num2);
        }
    }
}