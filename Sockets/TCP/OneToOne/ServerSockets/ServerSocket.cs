using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace ServerSockets
{
    public class ServerSocket
    {    
        public Socket StartHost()
        {
            Socket connector = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp); 
            IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Any, 11000);
            connector.Bind(localEndPoint); //test med new IPEndPoint(IPAddress.Any, 11000)
            connector.Listen(10); //vil det virke med 1 eller 0?
            return connector.Accept();
        }
        public Socket StartHost(int port) //OVERLOAD
        {
            Socket connector = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp); //denne linje og næstes parameter være dynamisk i en overload.
            IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Any, port);
            connector.Bind(localEndPoint); 
            connector.Listen(10);
            return connector.Accept();           
        }
    }
}
