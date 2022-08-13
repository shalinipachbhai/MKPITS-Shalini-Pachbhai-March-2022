//create a class customer having fields custno,custname,custaddress,custtelno and methods getcustomerdata and displaycustomerdata
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_customer
{
    public class customer
    {
        public int number;
        public string name;
        public string address;
        public long tel_number;

        public void getcustomerdata(int number,string name,string address,long tel_number)
        {
            this.number=number;
            this.name=name;
            this.address=address;
            this.tel_number=tel_number;
        }
        public void displaycustomerdata()
        {
            Console.WriteLine("Enter customer number:"+number);
            Console.WriteLine("Enter customer name:"+name);
            Console.WriteLine("Enter customer address:"+address);
            Console.WriteLine("Enter customer telephone number:"+tel_number);
        }
    }
    internal class program
    {
        static void main(string[]args)
        {
            Customer customer=new customer();
            Console.Write("Enter customer number:");
            int number=Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter customer name:");
            string name=Console.ReadLine();

            Console.Write("Enter customer address:");
            string address=Console.ReadLine();

            Console.Write("Enter customer telephone number:");
            long tel_number=Convert.ToInt64(Console.ReadLine());

            customer.getcustomerdata(number,name,address,tel_number);
            Console.WriteLine();
            customer.displaycustomerdata();
        }
    }
}