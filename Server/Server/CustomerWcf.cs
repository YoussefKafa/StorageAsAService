using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Server
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class CustomerWcf : ICustomerWcf
    {
        static String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Kafa\Desktop\StorageAsAService\Server\Server\projectDatabase.mdf;Integrated Security=True;Connect Timeout=30";

        public bool checkAdmin(string name, string pass)
        {
            SqlConnection con;
            con = new SqlConnection(connectionString);
            con.Open();
            string userName = name;
            string password = pass;
            SqlCommand cmd1 = new SqlCommand("select case when exists ( SELECT * FROM USERS WHERE name ='" + userName + "' and password= '" + password + "') THEN CAST (1 AS BIT) ELSE CAST(0 AS BIT) END; ", con);
            object result1 = cmd1.ExecuteScalar();
            string res1 = Convert.ToString(result1);
            con.Close();
            return Boolean.Parse(res1);
        }

        public DataTable getCustomersWith90Quota()
        {
            SqlConnection con;
            con = new SqlConnection(connectionString);
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from [customer] where currentQuota like @x;", con);
            adapt.SelectCommand.Parameters.AddWithValue("@x", "%" + "90" + "%");
            DataTable table = new DataTable("resultTable");
            _ = adapt.Fill(table);
            con.Close();
            return table;
        }

        public bool updateCustomerQuota(String newQuota, String customerId)
        {
            SqlConnection con;
            con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd1 = new SqlCommand("update customer set maxQuota=@maxQ where id=@id;", con);
            cmd1.Parameters.Add("@maxQ", newQuota);
            cmd1.Parameters.Add("@id", customerId);
            cmd1.ExecuteNonQuery();
            con.Close();
            return true;
        }

        public bool updateFileAvailability(string available, string fileId)
        {
            SqlConnection con;
            con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd1 = new SqlCommand("update [file] set availability=@available where id=@id;", con);
            cmd1.Parameters.Add("@available", available);
            cmd1.Parameters.Add("@id", fileId);
            cmd1.ExecuteNonQuery();
            con.Close();
            return true;
        }

        DataTable ICustomerWcf.getTheNewest10PublicFilesBySubject(String subject)
        {
            SqlConnection con;
            con = new SqlConnection(connectionString);
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from [file] where subject like @x;", con);
            adapt.SelectCommand.Parameters.AddWithValue("@x","%"+subject+"%");
            DataTable table = new DataTable("resultTable");
            _ = adapt.Fill(table);
            con.Close();
            return table;
        }
    }
}
