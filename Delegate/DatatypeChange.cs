using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public delegate string Handloom(string a, string b, string c);
  public static class DatatypeChange
    {
        public static string Curtains(string a,string bb ,string cc)
        {
           //Console.WriteLine(a, bb, cc);
            Console.WriteLine("This is string delegate 1 method " +a +"" +bb + "" + cc);
            string rr = a + " " + bb + " " + cc;
            return rr;

        }

        public static string Bedsheets(string a , string b)
        {
            Console.WriteLine("This is a normal method");
            return "Aman";
        }

        public static string Doormates(string aa,string bb,string cc)
        {
          //  Console.WriteLine(aa, bb, cc);
            Console.WriteLine("This is a delegate method 2 " +aa + " " +bb + " " +cc);
            string ss = aa + " " + bb + " " + cc;


            return ss;
        }
    }
}
