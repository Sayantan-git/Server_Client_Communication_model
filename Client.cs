using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnTry3
{
     

    public class Client
    {
        IList<Client> client_list = new List<Client>();

        #region Fields
        public string Name { get; set; }
        public int phoneNumber { get; set; }

        #endregion Fields

        public void AddToClient(Client client)   //Method to add client in Server list
        {
            client_list.Add(client);
        }

    }
}
