using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternPrograms
{
   public  class factorial
    {
        public int factorialDemo(int num)
        {
            if (num == 0)

            {

                return 1;

            }

            return num * factorialDemo(num - 1);


            //int fact = 1;
            //for(int i = 1; i <= num; i++)
            //{
            //    fact = fact * i; //1,2,6,24,120

            //}
            //Console.WriteLine("value " + fact);
        }
    }
}
