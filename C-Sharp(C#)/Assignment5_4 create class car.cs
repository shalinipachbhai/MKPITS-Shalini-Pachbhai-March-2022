//create a class car having fields company name,model and method getcardata and displaycardata
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_car
{
    public class car
    {
        public string company_name;
        public string model;

        public void getcardata(string company_name,string model)
        {
            this.company_name=company_name;
            this.model=model;
        }
        public void displaycardata()
        {
            Console.WriteLine("Enter company name:"+company_name);
            Console.WriteLine("Enter  car model:"+model);
        }
    }
    internal class program
    {
        static void main(string[]arg)
        {
            car car=new car();
            Console.Write("Enter company name:");
            string company_name=Console.ReadLine();

            Console.Write("Enter car model:");
            string model=Console.ReadLine();

            car.getcardata(company_name,model);
            Console.WriteLine();
            car.displaycardata();
        }
    }
}