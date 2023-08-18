using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionDemo
{
  public  class ListDemo
    {
        public void listMethod()
        {
            List<int> lstint = new List<int>();
            

            for(int i = 1; i <= 100; i++)
            {
                lstint.Add(i);
            }

           int a= lstint.Count();
            Console.WriteLine("hey " + a);
           
            foreach(int valu in lstint)
            {
                Console.WriteLine(valu);
            }




            Console.WriteLine("Total capacity = {0}",lstint.Capacity);

            Console.WriteLine("Total valuse ={0}",lstint.Count);
          
        }
    }
}
