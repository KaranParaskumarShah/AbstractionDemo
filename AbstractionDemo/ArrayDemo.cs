using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionDemo
{
    public class ArrayDemo
    {
        public void ArrayMethod()
        {
            int[] aa = new int[3];
            aa[0] = 1;
            aa[1] = 11;
            aa[2] = 111;


            foreach(int value in aa)
            {
                Console.Write("this is array print  " + value);
            }
        }

        public void ArrayMethod2()
        {
            int[] bb = new int[4]
            {
                12,23,234,55
            };

            string[] ss = { "hi", "karan", "hello", "kem cho?", "Mazama" };

            for(int i = 0; i < ss.Length; i++)
            {
                Console.WriteLine(ss[i]);
            }

            for(int j=0; j <bb.Length;j++)
            {
                Console.WriteLine(bb[j]);
            }

        }


    }
}
