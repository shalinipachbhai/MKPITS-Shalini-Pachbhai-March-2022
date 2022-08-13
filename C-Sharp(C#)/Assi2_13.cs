using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_13
{
    internal class Program
    {
        //wap to accept ch aracter form the user and display whether it is vowel or not.(by using switch case)

        static void Main(string[])
        {
              char ch;
              Console.WriteLine("enter character");
              ch=Convert.ToChar(Console.ReadLine());
              switch(ch)
              {
                case 'a':
                Console.WriteLine("character is vowel");
                break;
                case 'e':
                Console.WriteLine("character is vowel");
                break;
                case 'i':
                Console.WriteLine("character is vowel");
                break;
                case 'o':
                Console.WriteLine("character is vowel");
                break;
                case 'u':
                Console.WriteLine("character is vowel");
                break;
                default:
                Console.WriteLine("character is not vowel");
                break;
              }
        }
    }
}
