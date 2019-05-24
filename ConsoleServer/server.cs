using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleServer
{
    class Server
    {
        TcpListener Listener;
        public Server(int Port)
        {
            Listener = new TcpListener(IPAddress.Parse("192.168.1.106"), Port);
            Listener.Start();

            while(true)
            {
                new Client(Listener.AcceptTcpClient());
            }
        }
        ~Server()
        {
            if (Listener != null)
            {
                Listener.Stop();
            }
        }
        static void Main(string[] args)
        {
            new Server(80);
        }
    }
}
