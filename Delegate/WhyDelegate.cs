using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{ 

    public class WhyDelegate 
    {
        int a, b;    
    }
   public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public static void PromoteEmployee(List<Employee> employeeList)
        {
            foreach(Employee employee in employeeList)
            {
                if (employee.Experience >= 5)
                {
                    Console.WriteLine(employee.Name +"Promoted");

                }
            }
        }
   }




}
