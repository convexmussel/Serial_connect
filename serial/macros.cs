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
        private Dictionary<Button, ButtonSettings> buttons = new Dictionary<Button,ButtonSettings>();
        public macros()
        {
            InitializeComponent();
            FillButtonList();
        }

        public void FillButtonList()
        {
            int index = 0;
            foreach(Button temp in panel1.Controls)
            {
                buttons.Add(temp, new ButtonSettings(index.ToString()));
                temp.Click += new System.EventHandler(this.Anybutton_Click);
               
            }           
        }

        private void Anybutton_Click(object sender, EventArgs e)
        {
            ButtonSettings temp = buttons[(Button)sender];
            _master.Send_Data(temp.button_print);
        }

        private void options_Click(object sender, EventArgs e)
        {

        }
    }
}
