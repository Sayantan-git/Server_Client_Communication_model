using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnTry3
{
    public class Server
    {
        #region Member

        public IList<Client> server_list = new List<Client>();  //list for maintaining clients list in server

        #endregion Member

        #region Methods

        //FUNCTION TO ADD CLIENT TO SERVER
        public void AddToServer(Client client)   //Method to add client in Server list
        {
            server_list.Add(client);
            SaveAsXML(server_list);
        }

        void SaveAsXML(IList<Client> clients)  // //Method to add client in Server XML file
        {
            string xmlFilename = @"F:\projects\HandsOn\HandsOnTry3\HandsOnTry3\ClientList.xml";
            var writer = new System.Xml.Serialization.XmlSerializer(typeof(List<Client>));

            var file = new StreamWriter(xmlFilename);
            writer.Serialize(file, clients);
            file.Close();
        }

      


        // FUNCTION TO REMOVE CLIENT FROM SERVER

        public void RemoveFromServer(int phNumber)   //Method to remove client from Server list
        {
            foreach (var clnt in server_list.ToList())
            {
                if(clnt.phoneNumber == phNumber)
                {
                    server_list.Remove(clnt);
                }
            }     
        }


        //FUNCTION TO DISPLAY LIST OF CLIENTS IN THE SERVER

        public void DisplayClients()  
        {
            int i = 1;
            foreach (Client clnt in server_list)
            {
                Console.WriteLine(i + "." + "PhoneNumber: " + clnt.phoneNumber + " Name: " + clnt.Name);
                i++;
            }
        }

        //FUNCTION TO DISPLAY LIST OF CLIENTS IN THE SERVER except passed client
        public void DisplayClientsExcept(int phoneNumber)  
        {
            int i = 1;
            foreach (Client clnt in server_list)
            {
                if (clnt.phoneNumber != phoneNumber)
                {
                    Console.WriteLine(i + "." + "PhoneNumber: " + clnt.phoneNumber + " Name: " + clnt.Name);
                    i++;
                }
            }
        }






        //FUNCTION TO CHECK IF ID IS UNIQUE OR NOT
        public Client isClientRegistered(int phNumber)   //Method to check is Id id already present in server list during new Registration
        {
            
            foreach (var clnt in server_list.ToList())
            {
                if (clnt.phoneNumber == phNumber)
                    return clnt;   
            }
            return null;    
        }



        //SENDING MESSAGE
        public void sendMessage(Client sender, Client receiver, string message)
        {
            Console.WriteLine(" Message Sent ");
            Console.WriteLine("Sender: " + sender.Name);
            Console.WriteLine("Receiver: " + receiver.Name);
            Console.WriteLine("Message:- " + message);
        }

       

        #endregion Methods


    }
}
