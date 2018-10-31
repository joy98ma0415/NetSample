using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10201_CS_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("請問是否要進入我的介紹？", "進入我的介紹內容表單", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.OK)
            {
                AboutFrm f = new AboutFrm();
                f.Show();
                this.linkLabel1.LinkVisited = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("請問是否要進入C#專案？", "進入C#專案表單", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.OK)
            {
                Main f = new Main();
                f.Show();
                this.linkLabel1.LinkVisited = true;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hello, Welcome to my project~");
        }
    }
}
