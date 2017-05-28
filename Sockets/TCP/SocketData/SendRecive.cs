using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SocketData
{
    public class SendRecive
    {
        Socket handler;
        public event Action<string> Recived;

        public SendRecive(Socket socket)
        {
            handler = socket;
        }

        public void Send(byte[] msg)
        {
            handler.Send(msg);
        }
        public void Send(string data)
        {
            byte[] msg = Encoding.ASCII.GetBytes(data);
            Console.WriteLine("sender");
            handler.Send(msg);
        }
        public void Listen()
        {
            while(true)
            {
                try
                {
                    byte[] bytes = new byte[1024]; //hvorfor 1024?
                    Console.WriteLine("0");
                    int bytesRec = handler.Receive(bytes);
                    Console.WriteLine("1");
                    String data = Encoding.ASCII.GetString(bytes, 0, bytesRec);
                    Console.WriteLine("2");
                    Console.WriteLine(data);
                    Recived(data);
                    Console.WriteLine("3");
                }
                catch (Exception)
                {
                }
            }

        }
    }
}
