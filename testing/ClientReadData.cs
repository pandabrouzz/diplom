using System;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server_app
{
    public class ClientReadData
    {
        public static TcpClient client;
        public static TextBox ThreadLogBox;
        public ClientReadData(TcpClient tcpClient, TextBox textBox)
        {
            client = tcpClient;
            ThreadLogBox = textBox;
        }
        public string AddingData()
        {
            NetworkStream stream = null;
            try
            {
                stream = client.GetStream();
                byte[] data = new byte[64]; // буфер для получаемых данных
                StringBuilder builder = new StringBuilder();
                int bytes = 0;
                do
                {
                    //MessageBox.Show("косячок");
                    bytes = stream.Read(data, 0, data.Length);
                    builder.Append(Encoding.UTF8.GetString(data, 0, bytes));
                }
                while (stream.DataAvailable);
                // закрываем поток
                stream.Close();
                // закрываем подключение
                client.Close();
                return builder.ToString();
            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
                if (stream != null)
                    stream.Close();
                if (client != null)
                    client.Close();
            }
        }
    }
}
