using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternPrograms
{
    public class PrimeNumber
    {
        //3,5,7,11,13,17,19,23,29,31
        public void primeDemo(int num)
        {
            int flag = 0;
            for(int i = 2; i < num; i++)
            {
                for(int j=2;j< num; j++)
                {
                    if (i!=j && i % j == 0)
                    {
                        //Console.WriteLine("Number is not prime number:" + j);
                        flag = 1;
                        break;
                    }
                }
                if (flag == 0)
                {
                    Console.WriteLine("number is prime number" + i);
                }
                flag = 0;



            }
           
           
            

        }
    }
}
