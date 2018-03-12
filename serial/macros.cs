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
        private bool _setting = false;
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
            if (_setting == false)
            {
                ButtonSettings temp = buttons[(Button)sender];
                _master.Send_Data(temp.button_print);
            }
            else
            {
                ButtonSettings buttonSettings;
                buttons.TryGetValue((Button)sender, out buttonSettings);
                options_panel options = new options_panel((Button)sender, buttonSettings);
                options.Show();
            }
           
        }

        private void settings_CheckedChanged(object sender, EventArgs e)
        {
            _setting = !_setting;
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }
    }
}
