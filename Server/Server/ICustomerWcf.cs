using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Server
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ICustomerWcf
    {
        [OperationContract]
       DataTable getTheNewest10PublicFilesBySubject(String subject);
        
        [OperationContract]
        DataTable getCustomersWith90Quota();
        
        [OperationContract]
        Boolean updateCustomerQuota(String newQuota, String customerId);

        [OperationContract]
        Boolean updateFileAvailability(String available, String fileId);
        [OperationContract]
        Boolean checkAdmin(String userName, String password);

    }
}
