using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnTry3
{

    class Program
    { 
    public static void Main()
    {

        Server server = new Server();
        
        int choice;
        char ch;

        do
        {
            Console.WriteLine("\n 1. User registration \n 2. Add new Contact \n 3. Send Message \n 4. Delete Contact \n 5. View all contacts ");
            Console.WriteLine(" Enter choice");

            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine(" User registration ");

                    //TAKING INPUT DETAILS FOR NEW REGISTRATION
                    int phoneNumber;
                    String ClientName;
                    Console.Write("\n Enter phone number: ");
                    phoneNumber = Convert.ToInt32(Console.ReadLine());
                    Console.Write("\n Enter name: ");
                    ClientName = Console.ReadLine();


                    Client c1 = new Client();  //creating new instance of a client
                    c1.Name = ClientName;
                    c1.phoneNumber = phoneNumber;
                    c1.AddToClient(c1);   //Adding client to clients list
                        

                    if ((server.isClientRegistered(phoneNumber))==null)
                    {
                        server.AddToServer(c1);  //add client to server
                      
                        Console.WriteLine("\n Id: " + phoneNumber + ", Name : " + ClientName + " is Successfully loaded to server");
                    }
                    else
                    {
                        Console.WriteLine("\n Duplicate Number / User already exists");
                        Console.WriteLine("\n Id: " + phoneNumber + ", Name : " + ClientName + " ,Not loaded to server");
                    }

                    break;

                    
                    
                case 2: Console.WriteLine("Add new Contact ");  


                        break;

                case 3:  Console.WriteLine("Send Message");

                        Console.WriteLine("Login to your account: ");

                        int senderNumber;
                        Console.Write("\n Enter phone number: ");
                        senderNumber = Convert.ToInt32(Console.ReadLine());

                        if ((server.isClientRegistered(senderNumber)) == null)
                        {
                            Console.WriteLine("No Registered User found");
                        }
                        else
                        {
                            Console.WriteLine("Successfull Login");

                        }


                        Console.WriteLine("Viewing all contacts");
                        server.DisplayClientsExcept(senderNumber);




                        int receiverNumber;
                        Console.Write("\n Enter phone number: ");
                        receiverNumber = Convert.ToInt32(Console.ReadLine());
                        string message;
                        Console.WriteLine("Enter message to be sent: ");
                        message = Console.ReadLine();

                        if (server.isClientRegistered(receiverNumber) == null)
                        {
                            Console.WriteLine("Incorrect number");
                        }
                        else
                        {
                            Client receiverClient = server.isClientRegistered(receiverNumber);
                            Client senderClient   = server.isClientRegistered(senderNumber);

                            server.sendMessage(senderClient, receiverClient, message);

                        }





                            break;


                case 4:
                    Console.WriteLine("\n Contact deletion Operation \n");

                    int phoneNumber4;
                    Console.Write("\n Enter phone number: ");
                    phoneNumber4 = Convert.ToInt32(Console.ReadLine());

                    server.RemoveFromServer(phoneNumber4);  //passing new instance to server for removing from server list  
                    break;




                case 5:
                    Console.WriteLine("Viewing all contacts");

                    server.DisplayClients();   //for displaying all clients present in server
                    break;



                default:
                    Console.WriteLine("Incorrect Choice");
                    break;
            }
            Console.WriteLine("\n Do you want to continue: press 'y' for yes 'n' for no.....\n");
            ch = Convert.ToChar(Console.ReadLine());
            } while (ch == 'y');
        Console.ReadKey();
    }
}
}
    


