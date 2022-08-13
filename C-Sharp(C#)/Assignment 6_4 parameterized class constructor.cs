//- create a class product having fields productno,productname,designation,quantity create a constructor with no parameters and create another parameterized constructor with 3 parameters.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class product
    {
        int price,quantity;
        string productname;
        //no parameter
        public product()
        {
            productname="pen";
            quantity=50;
            price=20;
        }
        //with parameter
        public product(string productname,int price,int quantity)
        {
            this.productname=productname;
            this.quantity=quantity;
            
              this.productno=productno;
        }
        public void display()
        {
            Console.WriteLine("name="+productname);
            Console.WriteLine("product quantity="+quantity);
           Console.WriteLine("product price="+price);
        }
    }
    class program
    {
        static void main(string[]arg)
        {
            product p1=new product();//this will call constructor with no parameter automatically
            p1.display();

            product p2=new product("pen",50,"ytl",20);//this will call parameterized constructor
            p2.display();
        }
    }
}