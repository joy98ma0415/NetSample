using System;
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

        private void btnWeek03_Click(object sender, EventArgs e)
        {
            Week03 obj3 = new Week03();
            this.Visible = false;
            obj3.Visible = true;
        }

        private void btnWeek04_Click(object sender, EventArgs e)
        {
            Week04 obj4 = new Week04();
            this.Visible = false;
            obj4.Visible = true;
        }

        private void btnWeek05_Click(object sender, EventArgs e)
        {
            Week05 obj5 = new Week05();
            this.Visible = false;
            obj5.Visible = true;
        }

        private void btnWeek06_Click(object sender, EventArgs e)
        {
            Week06 obj6 = new Week06();
            this.Visible = false;
            obj6.Visible = true;
        }

        private void btnWeek07_Click(object sender, EventArgs e)
        {
            Week07 obj7 = new Week07();
            this.Visible = false;
            obj7.Visible = true;
        }

        private void btnWeek08_Click(object sender, EventArgs e)
        {
            Week08 obj8 = new Week08();
            this.Visible = false;
            obj8.Visible = true;
        }
    }
}
