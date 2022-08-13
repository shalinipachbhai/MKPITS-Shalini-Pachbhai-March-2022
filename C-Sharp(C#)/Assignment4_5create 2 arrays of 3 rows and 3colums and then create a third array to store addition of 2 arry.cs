using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    //create 2 arrays of 3 rows and 3colums and then create a third array to store addition of 2 arry
    internal class static 
        
    {
       static  void Main(string[]arg)
        {
             int[,]num=new int[3,3];
            for(int i=0;i<3;i++)
            {
                for(int j=0;j<3;j++)
                {
                    Console.WriteLine("enter number");
                    num[i,j]=Convert.ToInt32(Console.ReadLine());
                }
            }
            for(int i=0;i<3;i++)
            {
                for(int j=0;j<3;j++)
                {
                    Console.Write(num[i,j]+"\t");
                }
                Console.WriteLine();
            }
        }
    }
}   