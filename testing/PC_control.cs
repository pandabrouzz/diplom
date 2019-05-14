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
        
        public PC_control()
        {
            InitializeComponent();
            foreach (var item in flowLayoutPanel1.Controls)
                if (item is Button)
                    ((Button)item).Click += PC_button_click;
            status_array = new int[flowLayoutPanel1.Controls.Count];
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
            TcpClient client = new TcpClient("192.168.0.6", 2000);
            NetworkStream stream;
            string outMessage = "";
            foreach (int a in status_array)
            {
                outMessage += Convert.ToString(a);
            }

            string c = "2";
            Byte[] data = Encoding.UTF8.GetBytes(outMessage);
            Byte[] s2 = Encoding.UTF8.GetBytes(c);
            stream = client.GetStream();
            try
            {
                //Отправка сообщения
                stream.Write(s2, 0, s2.Length);
                stream.Write(data, 0, data.Length);
                // Получение ответа
                Byte[] readingData = new Byte[256];
                String responseData = String.Empty;
                StringBuilder completeMessage = new StringBuilder();
                int numberOfBytesRead = 0;
                do
                {
                    numberOfBytesRead = stream.Read(readingData, 0, readingData.Length);
                    completeMessage.AppendFormat("{0}", Encoding.UTF8.GetString(readingData, 0, numberOfBytesRead));
                }
                while (stream.DataAvailable);
                MessageBox.Show(Convert.ToString(completeMessage));
            }
            finally
            {
                stream.Close();
                client.Close();
            }
            
        }
    }
}
