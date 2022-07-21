using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ITest
{
    [ServiceContract]
    public interface ITest
    {
        [OperationContract]
        User DataUser(string id, string userName, string password, string requestDate);
    }

    [DataContract]
    public class User
    {
        [DataMember]
        public string Id { get; set; }
        [DataMember]
        public string UserName { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public string RequestDate { get; set; }
    }
}
