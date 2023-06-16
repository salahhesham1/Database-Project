﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminAccess adminAccess = new AdminAccess();
            this.Hide();
            adminAccess.ShowDialog();
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StudentAccess studentAccess = new StudentAccess();
            this.Hide();
            studentAccess.ShowDialog();
            this.Close();


        }
    }
}
