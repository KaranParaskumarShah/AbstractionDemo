using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionDemo
{
 public  class Demo2
    {
        //error throw  int i = null; 

        //int? i = null; not throw error 
        //in value type we can not store data in null .in db in webform if user not fill the input
        //of particular field how to store in db .so null value type kariye to direct lai le


        //Nullable Colliasion
        public void nullableCollision()
        {
            int? ticketsOnSale = 1000;

            int availableTickets;
            int total;

            if (ticketsOnSale == null)
            {
                Console.WriteLine("Nullable tickets is = {0}", ticketsOnSale);
            }
            else
            {
                availableTickets = ticketsOnSale.Value;
                Console.WriteLine("Not null av={0}", availableTickets);

                total = (int)ticketsOnSale;
                Console.WriteLine("total tickets{0}", total);
            }
        }

      



    }
}
