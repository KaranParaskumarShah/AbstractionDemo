using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternPrograms
{
  public class Swapping
    {
        int a = 4, b = 7;
        public void swapDemo()
        {
            Console.WriteLine("value of {0} and  {1} ",a,b);

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine($"After swapping {a} and {b}");
        }
    }
}
