using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternPrograms
{
    public class SumOfDigit
    {
        public void sumOfDigit(int number)
        {
            int sum = 0, temp;
            temp = number;
            
            int ab = number.ToString().Length;
            for(int i=1;i<=ab;i++)
            {
                int remainder = number % 10;
                sum = sum + remainder;
                number = number / 10;
                Console.WriteLine("Individual digit of number {0}",remainder);
            }

            Console.WriteLine("value of sum : {0}", sum);


        }
    }
}
