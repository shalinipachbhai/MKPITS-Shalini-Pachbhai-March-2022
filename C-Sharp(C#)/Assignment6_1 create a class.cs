//Assi6_1 Create a class Product having fields productid,productname,price,quantity create a constructor with no parameters and method display
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_class_product
{
    class product
    {
        int productid,quantity;
        String productname;
        int price;
        //creating a constructor with no parameters
        public product()
        {
            productid=1;
            productname="cement";
            quantity=15;
            price=250;
        }
        public void display()
        {
            Console.WriteLine("product id="+productid);
            Console.WriteLine("produc tname="+productname);
            Console.WriteLine("product quantity="+quantity);
            Console.WriteLine("product price="+price);
        }

    }
    class program
    {
        static void main(string[]args)
        {
            product b=new product;//this will call constructor automatically
            b.display();
            Console.ReadLine();
        }
    }
}