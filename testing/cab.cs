using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO.Ports;
using System.Timers;
using System.Net.Sockets;
using System.Net;
using Server_app;
using System.Threading.Tasks;

namespace testing
{
    public partial class cabForm : Form
    {
        public static TextBox a;
        public static DataGridView dataGrid1;
        const int port = 2000;
        public static TcpListener listener;
        TcpClient client;

        public cabForm()
        {
            InitializeComponent();
            a = LogTextBox;
            dataGrid1 = dataGridView1;
            a.Text += "Ожидание подключения...\n";
            listener = new TcpListener(IPAddress.Parse("192.168.1.106"), port);
            listener.Start();
        }
        void OnTimedEvent(object sender, EventArgs myEventArgs)
        {
            client = listener.AcceptTcpClient();
            ClientReadData clientRead = new ClientReadData(client, a);

            string aw = clientRead.AddingData();
            current_lightness_label.Text = aw;

            int rowNumber = dataGrid1.Rows.Add();
            dataGrid1.Rows[rowNumber].Cells[0].Value = rowNumber;
            dataGrid1.Rows[rowNumber].Cells[1].Value = System.DateTime.Now;
            dataGrid1.Rows[rowNumber].Cells[2].Value = aw;
            dataGrid1.CurrentCell.Selected = false;
            dataGrid1.CurrentCell = dataGrid1.Rows[rowNumber].Cells[2];
            dataGrid1.Rows[rowNumber].Cells[2].Selected = true;

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            listener.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Tick += OnTimedEvent;
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PC_control pC_Control = new PC_control(client);
            pC_Control.Show();
        }

        private void form1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
