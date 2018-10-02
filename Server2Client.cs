using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Client
{
    class Server2Client
    {
        static Socket sck;
        public static void Main(string []args)
        {
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"),1234);
            try
            {
                sck.Connect(localEndPoint);
            }
            catch 
            {
                Console.Write("unable to connect to remote end point!\r\n");
                Main(args);
            }
            Console.Write("enter Text:");
            string text = Console.ReadLine();
            byte[] data = Encoding.ASCII.GetBytes(text);
            sck.Send(data);
            Console.Write("data sent!r\n");
            Console.Write("press any key to continue...");
            Console.Read();
            sck.Close();
        }
    }
}
