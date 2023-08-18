using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternPrograms
{
   public class Armstrong
    {
        //371 = 3*3+7*1
        public void armstrongDemo(int num)
        {
            int sum = 0;
            int temp = num;

            //string ab = Console.WriteLine(num.ToString().Length);
          int test=  num.ToString().Length;
            int temp2 = 0;            

            int a;
            while (num>0)
            {
               temp2= num % 10;
                sum += (int)Math.Pow(temp2, test);
                //sum = sum + (temp2 * test);
                num = num / 10;
            }

            Console.WriteLine("value is :" + sum);

            if (sum == temp)
            {
                Console.WriteLine("The number is armstrong number : ");
            }
            else
            {
                Console.WriteLine("the number is not armstrong number : ");
            }
        }

    }
}
