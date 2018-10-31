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
    public partial class Week12 : Form
    {
        public Week12()
        {
            InitializeComponent();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("請問是否要離開？", "複利計算", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.OK)
            {
                Main f = new Main();
                this.Visible = false;
                f.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double principal, rate, interest; //本金,利率,利息
            int endyear, year = 1; //結束年限, 第幾年

            principal = Convert.ToDouble(principalTB.Text);
            rate = Convert.ToDouble(rateTB.Text) / 100.0;
            endyear = Convert.ToInt32(endyearTB.Text);

            do
            {
                interest = principal * rate; //利息=本金*利率
                principal += interest; //本利和=本金+利息
                year++;
            } while (year <= endyear);

            //resultTB.Text = "NT$：" + principal;
            resultTB.Text = endyear + " 年後本利和：" + principal.ToString("C0");
        }
    }
}
