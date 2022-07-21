using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientPerson
{
    internal class Program
    {
        static void Main(string[] args)
        {

           string id = "", userName = "", password = "", requestDate = "";

           ServiceReferencePerson.TestClient user = new ServiceReferencePerson.TestClient();
            
           Console.WriteLine("EnterId: ");
           id = Console.ReadLine();

           Console.WriteLine("EnterUserName: ");
           userName = Console.ReadLine();

           Console.WriteLine("EnterPassword: ");
           password = Console.ReadLine();

           Console.WriteLine("EnterRequestDate: ");
           requestDate = Console.ReadLine();

           var result = user.DataUser(id, userName, password, requestDate);

           Console.WriteLine("\n" + "Id: " + result.Id + " UserName: " + result.UserName + " Password: " + result.Password + " RequestDate: " + result.RequestDate);

        }
    }
}
