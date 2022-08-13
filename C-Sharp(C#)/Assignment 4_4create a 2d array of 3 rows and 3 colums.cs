using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    //create a 2d array of 3 rows and 3 colums
    internal class static 
        
    {
        static void Main(string[])
        {
            int[,]num=new int[3,3];//dynamic technique
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