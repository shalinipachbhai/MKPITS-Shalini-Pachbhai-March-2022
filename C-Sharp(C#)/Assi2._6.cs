using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    //wap to empno, empname , designationcalculate and display bonus ie 10000 for manager5000 for clerk2000 for peon   using switch case

    class kuchbhi
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
            switch(designation)
            {
                case "manager":
                    bonus = 10000;
                    break;
                case "clerk":
                    bonus = 5000;
                    break;
                case "peon":
                    bonus = 2000;
                    break;
                default:
                    Console.WriteLine("invalid designation");
                    break;
            }

            Console.WriteLine("empname  ={0} , bonus = {1} " ,empname,bonus);


        }
    }
}
