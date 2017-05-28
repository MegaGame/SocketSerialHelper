using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServerSockets;
using System.Threading;
using System.Net.Sockets;
using SocketData;

namespace ConsoleServerTest
{
    class Server
    {
        SendRecive sr;
        static void Main(string[] args)
        {
            Server start = new Server();
            start.run();
        }
        public void run()
        {
            ServerSocket ss = new ServerSocket();
            Socket handler = ss.StartHost();
            sr = new SendRecive(handler);
            new Thread(sr.Listen).Start();
            lytte();
        }
        public void lytte()
        {
            try
            {
                sr.Recived += Print;
            }
            catch (Exception)
            {
            }
        }
        public void Print(string s)
        {
            Console.WriteLine(s);
        }
    }
}
