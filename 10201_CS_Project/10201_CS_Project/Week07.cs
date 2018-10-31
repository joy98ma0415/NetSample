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
    public partial class Week07 : Form
    {
        public Week07()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("請問是否要離開？", "基本運算", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.OK)
            {
                Main f = new Main();
                this.Visible = false;
                f.Visible = true;
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOperand1.Clear();
            txtOperand2.Clear();
            txtOutput.Clear();

        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            int opd1, opd2, op = 1;
            double result = 0.0;
            opd1 = Convert.ToInt32(txtOperand1.Text);
            opd2 = Convert.ToInt32(txtOperand2.Text);

            //取得運算子

            if (rdbAdd.Checked) op = 1;
            if (rdbSubtract.Checked) op = 2;
            if (rdbMultiply.Checked) op = 3;
            if (rdbDivide.Checked) op = 4;

            if (op == 1/*條件式 1*/)
            { //當條件式 1 为真時執行
                result = opd1 + opd2;
                txtOutput.Text = txtOperand1.Text + "+" + txtOperand2.Text + "=" + result.ToString();
            }

            else if (op == 2)
            { //當條件式 2 为真時執行
                result = opd1 - opd2;
                txtOutput.Text = txtOperand1.Text + "-" + txtOperand2.Text + "=" + result.ToString();
            }

            else if (op == 3)
            { //當條件式 3 为真時執行
                result = opd1 * opd2;
                txtOutput.Text = txtOperand1.Text + "*" + txtOperand2.Text + "=" + result.ToString();
            }

            else if (op == 4)
            { //當條件式 4 为真時執行
                result = opd1 / opd2;
                txtOutput.Text = txtOperand1.Text + "/" + txtOperand2.Text + "=" + result.ToString();
            }


            else
            {//當上面條件式都不為真時執行
                MessageBox.Show("錯誤，沒有選擇運算子！");
            }

        }
    }
}
