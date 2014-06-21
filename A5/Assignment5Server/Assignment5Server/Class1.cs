using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Threading;

namespace Assignment5Server
{
    class cHandle
    {
        private Socket soc = null;
        public cHandle(Socket s)
        {
            soc = s;
        }
        /*DESCRIPTION   -- This Function will send and recieve data as needed by the client and server           		
         (ARGUMENTS)    -- (void) -> Void
         PRECONDITION   --  The client has to be connected to the server                    	
         POSTCONDITION	 -- Client and serverwould have exchanged messages
         EXAMPLE (s)	 -- Socket client = server.AcceptSocket();
                            cHandle c = new cHandle(client);
                            Thread thread1 = new Thread(new ThreadStart(c.clientConnect));
                            thread1.Start();
         */
        public void clientConnect()
        {
            try
            {
                Byte[] t = new Byte[64];
                soc.Receive(t);
                String Message = Encoding.ASCII.GetString(t);
                String Client = Message.Replace("\0", ""); ;
                Console.WriteLine(Client + " has Started!");

                //sends back response
                Message = "ONLINE";
                Byte[] msgToSend = ASCIIEncoding.ASCII.GetBytes(Message.ToCharArray());
                soc.Send(msgToSend, msgToSend.Length, 0);

                //recieving of the second message
                Byte[] e;
                while (true)
                {
                    e = new Byte[64];
                    soc.Receive(e);
                    Message = Encoding.ASCII.GetString(e);

                    String trimmed = Message.Replace("\0", "");
                    Console.WriteLine(Client + " MSG: " + trimmed);

                    if (trimmed.Equals("ADD"))
                    {
                        Message = "You want to add";
                    }
                    else if (trimmed.Equals("MINUS"))
                    {
                        Message = "You want to minus";
                    }
                    else if (trimmed.Equals("MULTIPLY"))
                    {
                        Message = "You want to multiply";
                    }
                    else
                    {
                        Message = "I did not understand your request";
                    }


                    msgToSend = ASCIIEncoding.ASCII.GetBytes(Message.ToCharArray());
                    soc.Send(msgToSend, msgToSend.Length, 0);

                }
            }
            catch (Exception e)
            {
                soc.Close();
            }
        }
    }
}
