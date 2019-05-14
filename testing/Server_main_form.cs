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

namespace testing
{
    public partial class Form1 : Form
    {
        public static SerialPort serialPort = new SerialPort("COM3", 9600);
        bool isConnected = false; //флаг коннекта к плате
        bool on_state = true;   //флан подключения
        public Form1()
        {
            InitializeComponent();
        }

        void OnTimedEvent(object sender, EventArgs myEventArgs)
        {
            if (!serialPort.IsOpen) return;
            try // так как после закрытия окна таймер еще может выполнится или предел ожидания может быть превышен
            {
                serialPort.DiscardInBuffer(); // удалим накопившееся в буфере
                string strFromPort = serialPort.ReadLine(); // считаем последнее значение 
                int rowNumber = dataGridView1.Rows.Add();
                dataGridView1.Rows[rowNumber].Cells[0].Value = rowNumber;
                dataGridView1.Rows[rowNumber].Cells[1].Value = System.DateTime.Now;
                dataGridView1.Rows[rowNumber].Cells[2].Value = strFromPort;
                dataGridView1.CurrentCell.Selected = false;
                dataGridView1.CurrentCell = dataGridView1.Rows[rowNumber].Cells[2];
                dataGridView1.Rows[rowNumber].Cells[2].Selected = true;
            }
            catch { }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Write("0");
                serialPort.Close();
            }
        }

        private void on_button_Click(object sender, EventArgs e)
        {
            if (isConnected && serialPort.IsOpen)
            {
                if (on_state)
                {
                    serialPort.Write("1");
                    on_state = false;
                    on_button.Text = "OFF";
                }
                else
                {
                    serialPort.Write("0");
                    on_state = true;
                    on_button.Text = "ON";
                }
            }
            else
            {
                MessageBox.Show("Сначала необходимо подключиться к порту.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            on_button.Text = "ON";
            System.Threading.Thread.Sleep(500);
            thread_timer.Tick += OnTimedEvent;
            thread_timer.Interval = 1000;
            thread_timer.Start();

            connection_label.Text = "Порт закрыт";
            port_label.Text = "COM порт не назначен";
        }

        private void COM_ToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            COM_ToolStripMenuItem.DropDown.Items.Clear();
            string[] portnames = SerialPort.GetPortNames();
            foreach (string portName in portnames)
            {
                COM_ToolStripMenuItem.DropDown.Items.Add(portName);
            }
        }

        private void COM_ToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            isConnected = true;
            string selectedPort = e.ClickedItem.Text;
            serialPort.PortName = selectedPort;
            serialPort.DtrEnable = true;
            serialPort.ReadTimeout = 1000;
            serialPort.Open();
            connection_label.Text = "Порт открыт";
            port_label.Text = selectedPort;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort.Write("2");
            System.Threading.Thread.Sleep(500);
            serialPort.WriteLine("1100");
        }

        private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PC_control pC_Control = new PC_control();
            pC_Control.Show();
            

        }
    }
}
