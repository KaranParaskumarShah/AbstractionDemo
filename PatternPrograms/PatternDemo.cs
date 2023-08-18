using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternPrograms
{
   public  class PatternDemo
    {
        int num;


        public void PatternDemo1()
        {
            //Console.WriteLine("Enter Numbers");
            //int num = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= num; i++)
            {
                for (int j=1;j<=i;j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("");
            }
        }


        public void PatternDemo2()
        {
            Console.WriteLine("Enter Numbers");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i=1;i<=num;i++)
            {
                //space loop
                for (int j=num;j>i;j--)
                {
                    Console.Write(" ");
                }

                for(int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");

            }
        }






    }
}
