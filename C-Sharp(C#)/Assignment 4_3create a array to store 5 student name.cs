 //create a array to store 5 student name
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace display_stud_name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string []name=new string[5];
            for(int i=0;i<5;i++)
            {
                Console.Write("Enter student name: ");
                name[i]=Console.ReadLine();
            }
            Console.WriteLine("");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(name[i]);
                
            }
        }
    }
}