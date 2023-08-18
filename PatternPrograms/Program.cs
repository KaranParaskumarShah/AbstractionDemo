using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternPrograms
{
   public class Program
    {
        public static void Main(string[] args)
        {
            //PatternDemo objPattern = new PatternDemo();
            //objPattern.PatternDemo1();
            //objPattern.PatternDemo2();
            int sum = 0;

            Console.WriteLine("Enter Numbers");
            int num = Convert.ToInt32(Console.ReadLine());

            //Fibonacci objFibo = new Fibonacci();
            //sum=objFibo.fiboDemo(num);
            //Console.WriteLine("total is " + sum);


            //PrimeNumber objprim = new PrimeNumber();
            //objprim.primeDemo(num);

            //Palidrome objpalidrom = new Palidrome();
            ////objpalidrom.palidromeDemo(num);
            //objpalidrom.palidromeDemo2();

            //factorial objfact = new factorial();
            //sum=objfact.factorialDemo(num);
            //Console.WriteLine("total value :: "+sum);

            //Armstrong objarm = new Armstrong();
            //objarm.armstrongDemo(num);

            //Swapping objswap = new Swapping();
            //objswap.swapDemo();

            SumOfDigit objsum = new SumOfDigit();
            objsum.sumOfDigit(num);

            Console.ReadKey();
            
        }
    }
}
