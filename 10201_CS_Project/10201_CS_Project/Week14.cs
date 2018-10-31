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
    public partial class Week14 : Form
    {
        public Week14()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a;
            a = int.Parse(textBox1.Text);

            if (a % 2 == 0)
                a = a / 2;
            {
                label1.Text = textBox1.Text + " 是偶數";
            }

            if (a % 2 != 0)
                a = a / 2;
            {
                label1.Text = textBox1.Text + " 不是偶數";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("請問是否要離開？", "判斷偶數", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.OK)
            {
                Main f = new Main();
                this.Visible = false;
                f.Visible = true;
            }
        }
    }
}
