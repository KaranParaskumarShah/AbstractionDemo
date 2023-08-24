using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Generics
{
    
     public interface Base<T,V>
    {
         T Id
        {
            get;
            set;
        }

         V CreatedOn
        {
            get;
            set;
        }

    }

    public class Program
    {
        
        public static void Main(string[] args)
        {
             Bill<int, DateTime> objCli = new Bill<int, DateTime>();
           
            objCli.Id = 16;
            objCli.ClientName = "kpshah";
            objCli.ClientNumber = "7990213036";
            objCli.ClientEmail = "kpshah@1234";
            objCli.ClientPassword = "shahkp";
            objCli.GenderId = 1;
            //objCli.ClientDOB = DateTime.Now;
             objCli.ClientDOB = new DateTime(1999, 12, 23); // Example date of birth
            objCli.CreatedOn = DateTime.Now;

            objCli.ItemName = "Single bed with Cover";
            objCli.ItemPrice = 450;
            objCli.ItemQuantity = 3;
            objCli.Operation = 1;
            objCli.OperationName = "Insert";
            int total = objCli.ItemPrice * objCli.ItemQuantity;

            Console.WriteLine(objCli.ItemName);
            Console.WriteLine(objCli.ItemPrice);
            Console.WriteLine(objCli.ItemQuantity);
            Console.WriteLine(objCli.Operation);
            Console.WriteLine(objCli.OperationName);
            Console.WriteLine("Value of bill : {0}", total);


            Console.WriteLine(objCli.Id);
            Console.WriteLine(objCli.ClientName);
            Console.WriteLine(objCli.ClientNumber);

            Console.WriteLine(objCli.ClientEmail);

            Console.WriteLine(objCli.ClientPassword);

            Console.WriteLine(objCli.GenderId);
            Console.WriteLine(objCli.ClientDOB);
            Program objPro = new Program();
            // objPro.InsertStoreProGender();
             objPro.InsertStoreProceClientInfo();
            //  objPro.InsertStoreProPayment();
            //objPro.InsertStoreProOperation();
            //objPro.InsertStoreProCategory();
            //objPro.InsertStoreProItemType();

           // objPro.InsertStoreProBill();

            Console.ReadKey();
        }
        //Insert ClientInfo through sp and also ado.net through inserted date entered into db
        public void InsertStoreProceClientInfo()
        {
            Bill<int, DateTime> objCli = new Bill<int, DateTime>();

            objCli.Id = 3;
            objCli.ClientName = "mahir";
            objCli.ClientNumber = "7990213036";
            objCli.ClientEmail = "kpshah@1234";
            objCli.ClientPassword = "shahkp";
            objCli.Operation = 3;
            objCli.GenderId = 1;
            //objCli.ClientDOB = DateTime.Now;
            objCli.ClientDOB = new DateTime(1999, 12, 23); // Example date of birth
                                                           //  objCli.CreatedOn = DateTime.Now;

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["storegeproce"].ToString());
            //create Connection also configurationManager 
            string query = "InsertClientInfo";
            //create query
            //create command
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@ClientId", SqlDbType.Int).Value = objCli.Id;
            cmd.Parameters.Add("@ClientName", SqlDbType.VarChar).Value = objCli.ClientName;
            cmd.Parameters.Add("@ClientNumber", SqlDbType.VarChar).Value = objCli.ClientNumber;
            cmd.Parameters.Add("@ClientEmail", SqlDbType.VarChar).Value = objCli.ClientNumber;
            cmd.Parameters.Add("@ClientPassword", SqlDbType.VarChar).Value = objCli.ClientPassword;
            cmd.Parameters.Add("@ClientGenderId", SqlDbType.Int).Value = objCli.GenderId;

            cmd.Parameters.Add("@ClientDOB", SqlDbType.DateTime).Value = objCli.ClientDOB;
            cmd.Parameters.Add("@OperationId", SqlDbType.Int).Value = objCli.Operation;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();


            string qu = "Select * from ClientInfo";
            SqlCommand sqc = new SqlCommand(qu, con);
            con.Open();
            SqlDataReader red=sqc.ExecuteReader();
            if (red.HasRows)
            {
                while (red.Read())
                {
                    Console.WriteLine("{0}     {1}    {2}    {3}   {4}   {5}    {6}   {7}", red["ClientId"],
                        red["ClientName"],red["ClientNumber"],red["ClientEmail"],red["ClientPassword"]
                        ,red["ClientGenderId"],red["ClientDOB"],red["OperationId"]);
                }
            }





        }

        public void InsertStoreProGender()
        {
            Bill<int, DateTime> objCli = new Bill<int, DateTime>();
            objCli.GenderId = 1;
            objCli.ClientGenderName = "Tran";
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["storegeproce"].ToString());
            string query = "InsertClientGender";
            SqlCommand cmd = new SqlCommand(query,con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@ClientGenderId",SqlDbType.Int).Value=objCli.GenderId;
            cmd.Parameters.Add("@ClientGenderName", SqlDbType.VarChar).Value = objCli.ClientGenderName;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();


        }
        public void InsertStoreProOperation()
        {
            Bill<int, DateTime> objCli = new Bill<int, DateTime>();
            objCli.Operation = 4;
            objCli.OperationName = "Read";
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["storegeproce"].ToString());
            string query = "InsertOperation";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
       //     cmd.Parameters.Add("@OperationId", SqlDbType.Int).Value = objCli.Operation;
            cmd.Parameters.Add("@OperationName", SqlDbType.VarChar).Value = objCli.OperationName;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }
        public void InsertStoreProPayment()
        {
            Bill<int, DateTime> objCli = new Bill<int, DateTime>();
           // objCli.PaymentId = 3;
            objCli.PaymentTypeName = "CRED";
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["storegeproce"].ToString());
            string query = "InsertPaymentType";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //cmd.Parameters.Add("@PaymentId", SqlDbType.Int).Value = objCli.PaymentId;
            cmd.Parameters.Add("@PaymentTypeName", SqlDbType.VarChar).Value = objCli.PaymentTypeName;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }

        public void InsertStoreProItemType()
        {
            Bill<int, DateTime> objCli = new Bill<int, DateTime>();
            objCli.Id = 1;
            objCli.ItemName = "Single Rajaini khol With Cover";
            objCli.ItemPrice = 700;
            objCli.CategoryId = 8;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["storegeproce"].ToString());
            string query = "InsertItemType";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
          //  cmd.Parameters.Add("@Id", SqlDbType.Int).Value = objCli.PaymentId;
            cmd.Parameters.Add("@ItemName", SqlDbType.VarChar).Value = objCli.ItemName;

            cmd.Parameters.Add("@ItemPrice", SqlDbType.Int).Value = objCli.ItemPrice;
            cmd.Parameters.Add("@CategoryId", SqlDbType.VarChar).Value = objCli.CategoryId;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }

        public void InsertStoreProCategory()
        {
            Bill<int, DateTime> objCli = new Bill<int, DateTime>();
            objCli.Id = 1;
            objCli.CategoryName = "RajaiNikhol";
            objCli.TotalCategoryQuantity = 600;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["storegeproce"].ToString());
            string query = "InsertCategoryType";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
          //  cmd.Parameters.Add("@Id", SqlDbType.Int).Value = objCli.Id;
            cmd.Parameters.Add("@CategoryName", SqlDbType.VarChar).Value = objCli.CategoryName;
            cmd.Parameters.Add("@CategoryQuantity", SqlDbType.Int).Value = objCli.TotalCategoryQuantity;

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }

        public void InsertStoreProBill()
        {
            Bill<int, DateTime> objCli = new Bill<int, DateTime>();
            objCli.Id = 1;
            objCli.ItemId = 2;
            objCli.ItemQuantity = 4;
            objCli.ClientId = 3;
            objCli.PaymentId = 1;
            objCli.CreatedOn = DateTime.Now;
            objCli.TotalBill = 12;

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["storegeproce"].ToString());
            string query = "InsertBill";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
           // cmd.Parameters.Add("@Id", SqlDbType.Int).Value = objCli.Id;
            cmd.Parameters.Add("@ItemId", SqlDbType.Int).Value = objCli.ItemId;
            cmd.Parameters.Add("@ItemQuantity", SqlDbType.Int).Value = objCli.ItemQuantity;
            cmd.Parameters.Add("@ClientId", SqlDbType.Int).Value = objCli.ClientId;
            cmd.Parameters.Add("@PaymentTypeId", SqlDbType.Int).Value = objCli.PaymentId;
            cmd.Parameters.Add("@CreatedOn", SqlDbType.DateTime).Value = objCli.CreatedOn;
            cmd.Parameters.Add("@TotalBill", SqlDbType.Int).Value = objCli.TotalBill;
          cmd.Parameters.Add("@OperationId", SqlDbType.Int).Value = objCli.Operation;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
         }
    }

    public interface Client<T,V>: Base<T, V>,ClientGender<T>,OperationType<T>,PaymentType<T>
   {
         string ClientName
        {
            get;
            set;
        }

         string ClientNumber
        {
            get;
            set;
        }

        string ClientEmail
        {
            get;
            set;
        }
     string ClientPassword
        {
            get;
            set;
        }
     DateTime ClientDOB
        {
            get;
            set;
        }
}
    public interface ClientGender<T>
    {
        T GenderId
        {
            get;
            set;
        }

         string ClientGenderName
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
    public interface PaymentType<T>
    {
        T PaymentId
        {
            get;
            set;
        }

        string PaymentTypeName
        {
            get;set;
        }

    }


}
