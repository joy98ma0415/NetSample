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
    public partial class Week11 : Form
    {
        public Week11()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("請問是否要離開？", "攝氏華氏轉換", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.OK)
            {
                Main f = new Main();
                this.Visible = false;
                f.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int c = Convert.ToInt32(startTB.Text), step = Convert.ToInt32(stepTB.Text), end = Convert.ToInt32(endTB.Text);
            double f;
            resultTB.Text = "攝氏\t 華氏\r\n";
            while (c <= end)
            {
                f = (9.0 * c) / 5.0 + 32.0;
                resultTB.Text += c + "\t" + f + "\r\n";
                c += step;
            }
        }
    }
}
