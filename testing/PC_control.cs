using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Net.Sockets;

namespace testing
{
    public partial class PC_control : Form
    {
        int[] status_array;
        TcpClient client;
        public PC_control(TcpClient tcpClient)
        {
            InitializeComponent();
            foreach (var item in flowLayoutPanel1.Controls)
                if (item is Button)
                {
                    ((Button)item).Click += PC_button_click;
                    ((Button)item).BackColor = Color.Red;
                }
            status_array = new int[flowLayoutPanel1.Controls.Count];
            client = tcpClient;
        }
        
        private void PC_button_click(object sender, EventArgs e)
        {
            int button_id = flowLayoutPanel1.Controls.GetChildIndex((Button)sender);
            if (status_array[button_id] == 0)
            {
                ((Button)sender).BackColor = Color.Green;
                status_array[button_id] = 1;
            }
            else
            {
                ((Button)sender).BackColor = Color.Red;
                status_array[button_id] = 0;
            }
        }

        private void send_button_Click(object sender, EventArgs e)
        {
            client = cabForm.listener.AcceptTcpClient();

            NetworkStream stream = client.GetStream();
            
            string outMessage = "";
            foreach (int a in status_array)
            {
                outMessage += Convert.ToString(a);
            }

            string c = "2";
            Byte[] data = Encoding.UTF8.GetBytes(outMessage);
            Byte[] s2 = Encoding.UTF8.GetBytes(c);
            try
            {
                //Отправка сообщения
                stream.Write(s2, 0, s2.Length);
                stream.Write(data, 0, data.Length);
                stream.Close();
                client.Close();
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
