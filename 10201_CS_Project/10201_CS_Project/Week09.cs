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
    public partial class Week09 : Form
    {
        public Week09()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, j, result;
            string output = "";
            // 第一層
            for (i = 1; i <= 10; i++)
            {
                j = 1;
                do  // 第二層
                {
                    result = i * j;
                    output += i + "*" + j + "=" + result + "\t";
                    j++;
                } while (j <= 9);
                output += "\r\n";
            }
            txtOutput.Text = output;

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("請問是否要離開？", "九九乘法表", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.OK)
            {
                Main f = new Main();
                this.Visible = false;
                f.Visible = true;
            }

        }
    }
}
