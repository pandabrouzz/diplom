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
            Form1.serialPort.Write("2");
            string s="";
            foreach(int a in status_array)
            {
                s += Convert.ToString(a);
            }
            Form1.serialPort.WriteLine(s);
        }
    }
}
