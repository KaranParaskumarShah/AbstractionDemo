using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{   
    public class Program
    {
        public static void Main(string[] args)
        {
            Client<int> objCli = new Client<int>();
            objCli.ClientId = 12;
            objCli.ClientName = "aman";
            objCli.ClientNumber = "7990213036";
            objCli.ClientEmail = "aman@1234";
            objCli.ClientPassword = "aman11";
            objCli.ClientGenderId = 2;
            objCli.ClientDOB = '2001-02-11 ';

            Console.WriteLine(objCli.ClientId);
            Console.WriteLine(objCli.ClientName);
            Console.WriteLine(objCli.ClientNumber);

            Console.WriteLine(objCli.ClientEmail);

            Console.WriteLine(objCli.ClientPassword);

            Console.WriteLine(objCli.ClientGenderId);
            Console.WriteLine(objCli.ClientDOB);






            Console.ReadKey();
        }
    }
    public class Client<T>:ClientGender<T>,OperationType<T>
    {
        public T ClientId
        {
            get;
            set;
        }
        public string ClientName
        {
            get;
            set;
        }

        public string ClientNumber
        {
            get;
            set;
        }

        public string ClientEmail
        {
            get;
            set;
        }

        public string ClientPassword
        {
            get;
            set;
        }

      

        public DateTime ClientDOB
        {
            get;
            set;
        }

     
        public T Operation 
        {
            get;
            set;
         }
        public string OperationName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

    public class ClientGender<T>
    {
        public T ClientGenderId
        {
            get;
            set;
        }

        public string ClientGenderName
        {
            get;
            set;
        }

    }

    public interface OperationType<T>
    {
         T Operation
        {
            get;
            set;
        }

         string OperationName
        {
            get;
            set;
        }

    }



}
