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
    public partial class Week08 : Form
    {
        public Week08()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("請問是否要離開？", "季節判斷", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.OK)
            {
                Main f = new Main();
                this.Visible = false;
                f.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int month;
            month = int.Parse(textBox1.Text);

            if (month > 12 || month < 1)
                textBox2.Text = "無法判斷";
            else
            {
                switch (month % 3)
                {
                    case 1://餘數1
                        textBox2.Text = "孟";
                        break;
                    case 2://餘數2
                        textBox2.Text = "仲";
                        break;
                    case 3://餘數3
                        textBox2.Text = "季";
                        break;
                }

                switch ((month - 1) / 3)
                {
                    case 0:
                        textBox2.Text += "春";
                        break;
                    case 1:
                        textBox2.Text += "夏";
                        break;
                    case 2:
                        textBox2.Text += "秋";
                        break;
                    case 3:
                        textBox2.Text += "冬";
                        break;
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
