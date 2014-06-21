/*
 *  Assignment 5 - Sockets and Multithreading
 *  By: Peter Lyn (26100068) && Tajwane Campbell (29085001)
 *  Date: 21/06/14
 * 
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment5Server
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpListener server = null;
            try
            {
                IPAddress ip = IPAddress.Parse("192.168.1.6");//use current IP address here
                server = new TcpListener(ip, 8000); //8000 might not be open on different computers as well

                server.Start();

                // Enter the listening loop. 
                while (true)
                {
                    Console.Write("Waiting for a connection... ");
                    // Perform a blocking call to accept requests. 
                    Socket client = server.AcceptSocket();
                    cHandle c = new cHandle(client);
                    Thread thread1 = new Thread(new ThreadStart(c.clientConnect));
                    thread1.Start();
                }
            }
            catch (SocketException ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            Console.Read();
        }
    }
}
