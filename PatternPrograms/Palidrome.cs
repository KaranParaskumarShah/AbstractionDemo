using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternPrograms
{
   public class Palidrome
    {
        public void palidromeDemo(int num)
        {
            int sum = 0;
            int a=0;

            int temp = num;
            
            while (num > 0)
            {
                a = num % 10;
                sum = sum * 10 + a;
                num = num / 10;
            }
            Console.WriteLine("value is reverse of " + sum);
            Console.WriteLine("value of number is "+num);

            if (temp == sum)
            {
                Console.WriteLine("Number is palidrome : ");
            }
            else
            {
                Console.WriteLine("Number is not palidrome : ");
            }

        }

        public void palidromeDemo2()
        {
            Console.WriteLine("Eneter the string ");
            string ss = Console.ReadLine();

            string em = string.Empty;

            for(int i = ss.Length-1 ; i >= 0; i--)
            {
                em += ss[i];
            }
            Console.WriteLine("new string of reverse is : " + em);

            if (em == ss)
            {
                Console.WriteLine("This string is palidrome : ");
            }
            else
            {
                Console.WriteLine("This string is not palidrome : ");
            }


        }



    }
}
