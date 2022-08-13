//create a class customer having fields custno,custname,custaddress,custtelno
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_customer
{
    public class customer
    {
        int custno;
        string custname;
        string custaddress;
        long tel_number;
    }
    internal class program
    {
        static void main(string[]arg)
        {
            Customer customer=new customer();
            Console.Write("Enter customer number:");
            cust.number=Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter customer name:");
            cust.name=Console.ReadLine();

            Console.Write("Enter customer address:");
            cust.address=Console.ReadLine();

            Console.Write("Enter customer telephone number:");
            cust.tel_number=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Enter customer number="+cust.no); 
            Console.WriteLine("Enter customer name="+cust.name); 
            Console.WriteLine("Enter customer address="+cust.address); 
            Console.WriteLine("Enter customer tel_number ="+cust.tel_number);  
        }
    }
}