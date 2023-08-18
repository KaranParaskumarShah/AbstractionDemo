using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KudvenketDemo
{
   public class Program
    {
      public static void Main(string[] args)
        {
            //here first base class constructor called thay che 
            ChildDemo objChild = new ChildDemo("karan");
            Console.WriteLine("static varibla print : " + Inheritance_Constructor.collegeName);

            //MEthod override class obje

            MethodOverride objOverride = new OverrideDemo();
            objOverride.printSum();

            //GETTER SETTER  OBJECT
            GetterSetter objprop = new GetterSetter();
           // objprop.firstname = 'karan';
            //objprop.marks = -1100;

            objprop.SetFirstName("rajesh");
            Console.WriteLine("Get the data");
            Console.WriteLine(objprop.GetFirstName());

            //PROPERTY OBJECT

            PropertyDemo objpr = new PropertyDemo();

            objpr.Id = 101;
            objpr.Name = "karan";

            Console.WriteLine("here id is "+objpr.Id);
            Console.WriteLine("here name is " + objpr.Name);


            //auto implement obje
            PropertyDemo2 objprope = new PropertyDemo2();
            objprope.Email = "shahkaran2312@gmail.com";
            objprope.MobileNo = "7990213036";
            objprope.Salary = 232112.22F;

            Console.WriteLine(objprope.Email);
            Console.WriteLine(objprope.MobileNo);
            Console.WriteLine(objprope.Salary);
            Console.ReadKey();
        }
    }
}
