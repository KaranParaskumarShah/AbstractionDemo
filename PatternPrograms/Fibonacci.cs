using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternPrograms
{
    //0,1,1,2,3,5,8,13,21,34
    public class Fibonacci
    {
      
        public int fiboDemo(int num)
        {
            
            
            //Console.WriteLine("Enter Number");
            //int num =Convert.ToInt32( Console.ReadLine());

            if ((num ==0)||(num==1) )
            {
                //Console.WriteLine("Value is " +num);
                return num;
            }
            else
            {
                return fiboDemo(num - 1) + fiboDemo(num - 2);
            }


            //for (int i = 0; i <= num; i++)
            //{
            //    sum = a + b;
            //    a = b;
            //    b = sum;
            //    Console.WriteLine("Every number is : " + sum);
            //}
            //Console.WriteLine("Total is : "+sum);
            

        }
    }
}
