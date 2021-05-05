using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace General
{
    public interface IAdminManager
    {
       void addCustomer(Customer customer);
        void removeCustomer(int id);
        DataTable findAll();
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
        [DataContractFormat]
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
   [DataContract]
    public class File
    {
        [DataMember]
        public String id { get; set; }
        [DataMember]
        public String type { get; set; }
        [DataMember]
        public String size { get; set; }
        [DataMember]
        public String subject { get; set; }
        [DataMember]
        public Boolean availability { get; set; }
        [DataMember]
        public int customerId { get; set; }
    }
}
