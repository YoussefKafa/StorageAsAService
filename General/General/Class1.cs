using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace General
{
    public interface IAdminManager
    {
       void addCustomer(Customer customer);
        void removeCustomer(int id);
        DataTable findAll();
   
        //
        
    }
    public interface ICustomerManager
    {
        void updateCustomer(Customer customer);
        DataTable findAll(int customerId);
        void addFile(File file);
        void removeFile(int fileId);
        File getFile(int fileId);
        Boolean checkAdmin(String username, String password);
    }
        [Serializable]
    public class Customer
    {
        public String id { get; set; }
      public  String fullName { get; set; }
        public String email { get; set; }
        public String maxQuota { get; set; }
        public String currentQuota { get; set; }
        public String serviceClass { get; set; }
        public String photo { get; set; }

    }
     

    [Serializable]
    public class File
    {
        public String id { get; set; }
        public String type { get; set; }
        public String size { get; set; }
        public String subject { get; set; }
        public Boolean availability { get; set; }
        public int customerId { get; set; }
    }
}
