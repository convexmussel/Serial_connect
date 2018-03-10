using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace serial
{
    public partial class Form1 : Form
    {
        List<Panel> panels = new List<Panel>();
        public string a = "";
        public string com = "";
        public int baudss = 9600;
        static SerialPort serialport;
        public int index_panel =0;
        public Form1()
        {
            serialport = new SerialPort();
            InitializeComponent();
            setup();
        }

        private void setup()
        {
            comboBox1.SelectedIndex = 6;
            serialport.ReceivedBytesThreshold = 1; 
            serialport.NewLine = "\n";               
            serialport.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(SerialPort1_DataReceived);
            updateCom();
            comselect.SelectedIndex = 0;
        }

        private void updateCom()
        {
            comselect.Items.Clear();
            try
            {
                string[] ports = SerialPort.GetPortNames();
                foreach (String a in ports)
                {
                    comselect.Items.Add(a);
                }
                comselect.SelectedIndex = 0;

            }
            catch (Exception)
            {
                MessageBox.Show("cannot access com ports");
            }
        }

        private void Send_Data(String send)
        {
            if (serialport.IsOpen)
            {
                serialport.WriteLine(send);
            }
            else
            {
                to.AppendText("unable to send no connection port closed" + Environment.NewLine);
                updateCom();
            }
        }

        private void SerialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                a = serialport.ReadLine();
                Invoke(new EventHandler(update));
            }
            catch (Exception)
            {

            }

        }

        private void update(object sender, EventArgs e)
        {
            from.AppendText(a + Environment.NewLine);
        }

        private void connect_Click(object sender, EventArgs e)
        {
            if (!serialport.IsOpen)
            {
                openconnection();
                if (serialport.IsOpen)
                {
                    to.AppendText("connection opened" + Environment.NewLine);
                }
                else
                {
                    to.AppendText("not opened" + Environment.NewLine);
                }
            }

        }

        private void openconnection()
        {
            try
            {
                serialport.PortName = com;
                serialport.BaudRate = baudss;
                serialport.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("com port busy please close already open connection!!");
            }
        }

        private void closeconnection()
        {
            serialport.Close();
        }

     

        private void disconnect_Click(object sender, EventArgs e)
        {
            if (serialport.IsOpen)
            {
                closeconnection();
                to.AppendText("connection closed" + Environment.NewLine);
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                baudss = Int32.Parse(comboBox1.Text);
            }
            catch (FormatException)
            {
                to.AppendText("error");
            }
            if (serialport.IsOpen)
            {
                closeconnection();
                openconnection();
            }

        }

        private void comselect_SelectedIndexChanged(object sender, EventArgs e)
        {
            com = comselect.Text;
            if (serialport.IsOpen)
            {
                closeconnection();
                openconnection();
            }
        }

        private void send_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void send_KeyDown(object sender, KeyEventArgs e)
        {
           
            if (e.KeyCode == Keys.Enter)
            {
                string[] lines = send.Text.Split('\n', '\r');
                string last_line = lines[lines.Length - 1];
                Send_Data(last_line);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            updateCom();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            panels.Add(panel1);
            panels.Add(panel2);
            panels[index_panel].BringToFront();
        
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (index_panel > 0)
            {
                index_panel--;
            }
            else
            {
                index_panel = panels.Count - 1;
            }
            panels[index_panel].BringToFront();

        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (index_panel < panels.Count-1)
            {
                index_panel++;
            }
            else
            {
                index_panel = 0;  
            }
            panels[index_panel].BringToFront();
        }

        private void macro1_Click(object sender, EventArgs e)
        {
            
            Send_Data("2");
        }
    }
}
