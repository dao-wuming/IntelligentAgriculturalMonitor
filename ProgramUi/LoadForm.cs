﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramUI
{
    public partial class LoadForm : Form
    {
        public LoadForm()
        {
            InitializeComponent();
        }

        private void LoadForm_Load(object sender, EventArgs e)
        {
            this.txt_username.SendToBack();
            this.txt_password.SendToBack();
        }

        private void uiButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
