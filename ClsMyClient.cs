using System;
using System.Net;
using System.Net.Sockets;

namespace Client
{ 
    class MyClient
    {
        public static void CreateMain()
        {

            IPHostEntry IPHost = Dns.Resolve("www.hotmail.com");
            Console.WriteLine(IPHost.HostName);
            string[] aliases = IPHost.Aliases;
            Console.WriteLine(aliases.Length);
            IPAddress[] addr = IPHost.AddressList;
            Console.WriteLine(addr.Length);
            for (int i = 0; i < addr.Length; i++)
            {
                Console.WriteLine(addr[i]);
            }
        }
    }

}

