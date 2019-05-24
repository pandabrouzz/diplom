﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleServer
{
    class Client
    {
        public Client(TcpClient client)
        {
            string Html = "<html><body><h1>It works!</h1></body></html>";

            string Str = "HTTP/1.1 200 OK\nContent-type: text/html\nContent-Length:" + Html.Length.ToString() + "\n\n" + Html;

            byte[] Buffer = Encoding.ASCII.GetBytes(Str);

            client.GetStream().Write(Buffer, 0, Buffer.Length);

            client.Close();
        }
    }
}
