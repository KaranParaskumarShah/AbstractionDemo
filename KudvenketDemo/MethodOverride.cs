using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KudvenketDemo
{
   public  class MethodOverride
    {

        public virtual void printSum()
        {
            Console.WriteLine("This is a base class");
        }
   }

    public class OverrideDemo : MethodOverride
    {
        public override void printSum()
        {
            Console.WriteLine("This is a child  class");
        }
    }





}
