using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNet
{
   public class Program
    {
        SqlConnection con = null;
        public static void Main(string[] args)
        {
            Program objpr = new Program();
        //    objpr.Insert();

        //    objpr.InsertSP();

            Console.WriteLine("re");
            Console.ReadKey();
        }

        //test db
        public void Insert()
        {
            //create Connection also configurationManager 
             con = new SqlConnection(ConfigurationManager.ConnectionStrings["Constr"].ToString());

            //create query
            string query = "insert into EMPLOYEE values(5, 'shreyanshi')";


            //create command
            SqlCommand cmd = new SqlCommand(query,con);

            //run the query 
            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();


        }


        public void InsertSP()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["storegeproce"].ToString());

            //create Connection also configurationManager 

            string query = "InsertClientInfo";

            //create query


            //create command
            SqlCommand cmd = new SqlCommand(query, con);


            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@ClientId", SqlDbType.Int).Value = "14";
            cmd.Parameters.Add("@ClientName", SqlDbType.VarChar).Value = "aajar";
            cmd.Parameters.Add("@ClientNumber", SqlDbType.VarChar).Value = "18285662";
            cmd.Parameters.Add("@ClientEmail", SqlDbType.VarChar).Value = "bba@234gmail.com";
            cmd.Parameters.Add("@ClientPassword", SqlDbType.VarChar).Value = "5588e";
            cmd.Parameters.Add("@ClientGenderId", SqlDbType.Int).Value = "1";

            cmd.Parameters.Add("@ClientDOB", SqlDbType.DateTime).Value = "2000-9-22";
            cmd.Parameters.Add("@OperationId", SqlDbType.Int).Value = 1;
            



            con.Open();
            int rowaffected = cmd.ExecuteNonQuery();
            con.Close();
        }




        //run the query 
    


        }


    }

