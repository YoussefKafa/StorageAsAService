using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using System.ServiceModel;
using General;
using System.Diagnostics;
namespace Server
{
    class Program 
    {
      public  static void Main(String[] args)
        {
            string val;
            starting:
            Console.WriteLine("____________________________________________________ ");
            Console.WriteLine("-If you want to run WCF Server please enter 1. ");
            Console.WriteLine("-If you want to run Remoting Server please enter 2. ");
            Console.WriteLine("-If you want to exit please enter 3. ");
            Console.WriteLine("____________________________________________________ ");
            Console.WriteLine("Enter Here:  ");
            val = Console.ReadLine();
            if (val == "1")
            {
                using (System.ServiceModel.ServiceHost host = new
             System.ServiceModel.ServiceHost(typeof(Server.CustomerWcf)))
                {
                    host.Open();
                    Console.WriteLine("Host started @ " + DateTime.Now.ToString());
                    Console.WriteLine("-press any key to exit WCF server. ");
                    Console.ReadKey();
                    goto starting;
                }
            }
            else if (val == "2") {
                openServerConnectionForCustomer();
                Console.WriteLine("-press any key to exit Remoting server. ");
                Console.ReadKey();
                goto starting;
            }
            else if (val == "3")
            {
                Console.WriteLine("exit.. ");
            }
        }
        static String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Projects\C#\StorageAsService\StorageAsAService\Server\Server\projectDatabase.mdf;Integrated Security=True;Connect Timeout=30";

        public class AdminManager : MarshalByRefObject, IAdminManager
        {
            public void addCustomer(General.Customer customer)
            {
                SqlConnection con;
                con = new SqlConnection(connectionString);
                con.Open();
                SqlCommand cmd1 = new SqlCommand("insert into customer(fullName, email, maxQuota, currentQuota, serviceClass, photo) values(@fn, @e, @maxQ, @cQ, @sc, @p);", con);
                cmd1.Parameters.Add("@fn", customer.fullName);
                cmd1.Parameters.Add("@e", customer.email);
                cmd1.Parameters.Add("@maxQ", customer.maxQuota);
                cmd1.Parameters.Add("@cQ", customer.currentQuota);
                cmd1.Parameters.Add("@sc", customer.serviceClass);
                cmd1.Parameters.Add("@p", customer.photo);
                cmd1.ExecuteNonQuery();
                con.Close();
            }

           

            public DataTable findAll()
            {
                SqlConnection con;
                con = new SqlConnection(connectionString);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter("select * from customer;", con);
                DataTable table = new DataTable();
                _ = adapt.Fill(table);
                con.Close();
                Console.WriteLine("access to findAll");
                return table;
            }

            public void removeCustomer(int id)
            {
                SqlConnection con;
                con = new SqlConnection(connectionString);
                con.Open();
                SqlCommand cmd1 = new SqlCommand("delete from customer where id=" + id + ";", con);
                cmd1.ExecuteNonQuery();
                con.Close();
            }
            
        }

        public class CustomerManager : MarshalByRefObject, ICustomerManager
        {
            public void addFile(File file)
            {
                SqlConnection con;
                con = new SqlConnection(connectionString);
                con.Open();
                SqlCommand cmd1 = new SqlCommand("insert into [file](type, size, subject, availability, customerId) values(@ty, @si, @su, @av, @cu);", con);
                cmd1.Parameters.Add("@ty", file.type);
                cmd1.Parameters.Add("@si", file.size);
                cmd1.Parameters.Add("@su", file.subject);
                cmd1.Parameters.Add("@av", file.availability);
                cmd1.Parameters.Add("@cu", file.customerId);
                cmd1.ExecuteNonQuery();
                con.Close();
            }

            public DataTable findAll(int customerId)
            {
                SqlConnection con;
                con = new SqlConnection(connectionString);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter("select * from [file] where customerId=" + customerId + ";", con);
                DataTable table = new DataTable();
                _ = adapt.Fill(table);
                con.Close();
                return table;
            }

            public File getFile(int fileId)
            {
                SqlConnection con;
                con = new SqlConnection(connectionString);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter("select * from [file] where Id=" + fileId + ";", con);
                DataTable table = new DataTable();
                _ = adapt.Fill(table);
                File file = new File();
                DataRow fileData = table.Rows[0];
                file.type = fileData[1].ToString();
                file.size = (string)fileData[2];
                file.subject = (string)fileData[3];
                file.availability = Boolean.Parse(fileData[4].ToString());
                file.customerId = (int)fileData[5];
                con.Close();
                return file;
            }

            public void removeFile(int fileId)
            {
                SqlConnection con;
                con = new SqlConnection(connectionString);
                con.Open();
                SqlCommand cmd1 = new SqlCommand("delete from [file] where id=" + fileId + ";", con);
                cmd1.ExecuteNonQuery();
                con.Close();
            }

            public void updateCustomer(General.Customer customer)
            {
                SqlConnection con;
                con = new SqlConnection(connectionString);
                con.Open();
                SqlCommand cmd1 = new SqlCommand("update customer set fullName=@fn, email=@e, maxQuota=@maxQ, currentQuota=@cQ, serviceClass=@sc, photo=@p where id=@id;", con);
                cmd1.Parameters.Add("@fn", customer.fullName);
                cmd1.Parameters.Add("@e", customer.email);
                cmd1.Parameters.Add("@maxQ", customer.maxQuota);
                cmd1.Parameters.Add("@cQ", customer.currentQuota);
                cmd1.Parameters.Add("@sc", customer.serviceClass);
                cmd1.Parameters.Add("@p", customer.photo);
                cmd1.Parameters.Add("@id", customer.id);
                cmd1.ExecuteNonQuery();
                con.Close();
            }
            public bool checkAdmin(string username, string password)
            {
                if (Program.checkIfAdmin(username, password))
                {
                    RemotingConfiguration.RegisterWellKnownServiceType(typeof(AdminManager), "MyAdminService.soap", WellKnownObjectMode.Singleton);
                    Console.WriteLine("admin server started");
                    return true;
                }
                return false;
            }
        }
           
                
        public static void openServerConnectionForCustomer()
        {
            HttpChannel httpChannel = new HttpChannel(5000);
            ChannelServices.RegisterChannel(httpChannel, false);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(CustomerManager), "MyCustomerService.soap", WellKnownObjectMode.Singleton);
            Console.WriteLine("customer server started");
     
        }
        public static Boolean checkIfAdmin(String name, String pass)
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

        
    }
}
