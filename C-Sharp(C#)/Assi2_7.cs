using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    //wap to empno, empname , designationcalculate and display bonus ie 10000 for manager5000 for clerk2000 for peon using if else if

    class designation
    {
        static void Main()
        {
            string empno,empname, designation;
            int bonus = 0;
            Console.WriteLine("enter empno ");
            empno = Console.ReadLine();
            Console.WriteLine("enter empname ");
            empname = Console.ReadLine();
            Console.WriteLine("enter designation ");
            designation = Console.ReadLine();
            if (des=="manager")
            {
                Console.WriteLine("empno:"+empno);
                Console.WriteLine("empname:"+empname);
                Console.WriteLine("Bonus for manager:1000");
            }
            else if(des=="clerk")
            {
                Console.WriteLine("empno:"+empno);
                Console.WriteLine("empname:"+empname);
                Console.WriteLine("Bonus for clerk:5000");
            }
            else if(des=="peon")
            {
               Console.WriteLine("empno:"+empno);
                Console.WriteLine("empname:"+empname);
                Console.WriteLine("Bonus for peon:2000"); 
            }
            else
            {
                Console.WritenLine("invalid designation");
            }

        }
    }
}
