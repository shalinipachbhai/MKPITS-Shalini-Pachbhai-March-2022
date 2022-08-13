//create a class product having fields prodid,prodname,prodrate,quantity and display total amount
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_product
{
    public class product
    {
       public int id;
       public string name;
       public int rate;
       public int quantity;
       
       public void get_product_data(int id,string name,int rate,int quantity)
       {
        this.id=id;
        this.name=name;
        this.rate=rate;
        this.quantity=quantity;
       }
       public void display_product_data()
       {
        Console.WriteLine("Enter product id:"+id);
        Console.WriteLine("Enter product name:"+name);
        Console.WriteLine("Enter product rate:"+rate);
        Console.WriteLine("Enter product quantity:"+quantity);

        Console.WriteLine("total amount:"+(rate*quantity));
       }
    }
    internal class program
    {
        static void main(string[]arg)
        {
            product p=new Product();
            Console.Write("Enter product id:");
            int id=Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter product name:");
            string name=Console.ReadLine();

            Console.Write("Enter product rate:");
            int rate=Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter product quantity:");
            int quantity=Convert.ToInt32(Console.ReadLine());

            product.get_product_data(id,name,rate,quantity);
            Console.WriteLine();
            product.display_product_data();
        }
    }
}