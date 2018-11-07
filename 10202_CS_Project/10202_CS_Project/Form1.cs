﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10202_CS_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = "現在時間是： " + DateTime.Now.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 100;
            timer1.Enabled = true;

            MessageBox.Show("Hello, Welcome to my project");
        }

        private void btnWeek01_Click(object sender, EventArgs e)
        {
            Week01 obj1 = new Week01();
            this.Visible = false;
            obj1.Visible = true;
        }

        private void btnWeek02_Click(object sender, EventArgs e)
        {
            Week02 obj2 = new Week02();
            this.Visible = false;
            obj2.Visible = true;
        }
    }
}