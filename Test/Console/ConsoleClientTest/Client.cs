using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientSocket;
using SocketData;
using System.Net.Sockets;

namespace ConsoleClientTest
{
    class Client
    {
        ClientSocket.ClientSocket cs;
        SendRecive sr;
        static void Main(string[] args)
        {
            Client c = new Client();
            c.run();
        }
        public void run()
        {
            cs = new ClientSocket.ClientSocket();
            Console.WriteLine("venter");
            //Console.ReadKey();
            Socket handler = cs.ConnectToServer();
            Console.WriteLine("send?");
            //Console.ReadKey();
            sr = new SendRecive(handler);
            sr.Send("Test1");
            Console.WriteLine("sendt");
            sr.Send("Test2");
            sr.Send("Test3");
            sr.Send("Test4");
            Console.ReadKey();
        }
    }
}
