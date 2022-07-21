using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ITest
{
    public class Test : ITest
    {
        public User DataUser(string id, string userName, string password, string requestDate) { 
           return new User() {Id = id ,UserName= userName, Password = password, RequestDate = requestDate};
        }
    }
}
