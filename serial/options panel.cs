﻿using System;
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
    public partial class options_panel : Form
    {
        private Button button;
        private ButtonSettings settings;
        public options_panel(Button button,ButtonSettings settings)
        {
            this.settings = settings;
            this.button = button;
            InitializeComponent();
            bName.Text = button.Text;
            bCommand.Text = settings.button_print;
            
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            button.Text = bName.Text;
            settings.button_print = bCommand.Text;
            this.Close();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
