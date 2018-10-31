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
    public partial class Week06 : Form
    {
        public Week06()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int c = Convert.ToInt32(textBox3.Text);
            int d = Convert.ToInt32(textBox4.Text);

            if (a > b && c > d)
            {
                MessageBox.Show("是", "結果", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("否", "結果", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int c = Convert.ToInt32(textBox3.Text);
            int d = Convert.ToInt32(textBox4.Text);

            if (a < b || c < d)
            {
                MessageBox.Show("是", "結果", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("否", "結果", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("請問是否要離開？", "邏輯運算子判斷", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.OK)
            {
                Main f = new Main();
                this.Visible = false;
                f.Visible = true;
            }
        }
    }
}
