using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    //wap to accept productname, productrate, quantity calculate totalamount , discount ie 50% if totalamount > 2000 else discount =10% of total amount (using switch case)


    internal class program
    {
        static void Main(string[])
        {
             int product_rate,product_quantity,total_amount;
             float total_amount_with_discount;
            string product_name;
            Console.WriteLine("Enter product name");
            product_name=Console.ReadLine();
            Console.WriteLine("Enter product rate");
            product_rate=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter product quantity");
            product_quantity=Convert.ToInt32(console.ReadLine());
            
            total_amount=product_rate*product_quantity;
            if(total_amount>2000)
            {
                h=1;
            }
            switch(h)
            {
                case 1:
                discount=total_amount-total_amount*(50/100.0f);
                Console.WriteLine("total amount after discount:"+discount);
                break;
                default:
                  discount=total_amount-total_amount*(10/100.0f);
                  Console.WriteLine("total amount after discount:"+discount);
                  break;
            }
        }
    }
}