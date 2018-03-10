using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace serial
{
    public partial class macros : UserControl
    {
        public Form1 _master;
        public macros()
        {
            InitializeComponent();
          
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _master.Send_Data("hallo");
            _master.Send_Data(button1.Name);
        }
    }
}
