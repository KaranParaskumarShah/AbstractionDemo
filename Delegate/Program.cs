using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public delegate void calculator(int a , int b);

   public  class Program
    {
       public static void Main(string[] args)
        {

            Program objpro = new Program();


            calculator objcalc = new calculator(objpro.add);

        //    objcalc(20, 10);

            //multi delegate

            objcalc +=objpro.sub;
            objcalc(100 ,20);


            Handloom objhand = new Handloom(DatatypeChange.Curtains);
            Handloom objhand2 = new Handloom(DatatypeChange.Doormates);

            //objhand("hi ", "hello ", "kem cho ");

            Handloom objfinal = objhand + objhand2;

            string a = "hi ";
            string b = "hello";
            string c = "mazama";
            string result = objfinal(a, b, c);

            Console.WriteLine($"karan this is string delegate {0}", result);





            //Why delegate:because in list class is hardcore if some company want employee salary
            //greater than 40k that employee is promoted

            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee() { Id = 101, Name = "Karan", Salary = 50000, Experience = 5 });
            empList.Add(new Employee() { Id = 101, Name = "Aman", Salary = 60000, Experience = 7 });
            empList.Add(new Employee() { Id = 101, Name = "Rajesh", Salary = 20000, Experience = 3 });
            empList.Add(new Employee() { Id = 101, Name = "darshan", Salary = 30000, Experience = 4 });
            empList.Add(new Employee() { Id = 101, Name = "tithi", Salary = 40000, Experience = 5 });

            Employee.PromoteEmployee(empList);

            Console.ReadKey();
        }


        public void add(int a , int b)
        {
            Console.WriteLine(a+b);
        }

        public void sub(int a ,int b)
        {
            Console.WriteLine(a - b);
        }

    }
}
