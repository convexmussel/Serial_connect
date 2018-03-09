using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace serial
{
    public partial class tester : Form
    {
        Form1 master;
        public tester(Form1 master)
        {
            this.master = master;
            this.Location = master.Location;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

   
    }
}
