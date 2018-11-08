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
    public partial class Week05 : Form
    {
        public Week05()
        {
            InitializeComponent();
            textBox1.MaxLength = 10;//設定字元數最大值
            textBox1.Focus();//程式啟動就把焦點移到textBox1
            this.AcceptButton = button1;//按下enter就觸發button click事件
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Length == 10)//長度達十個字才驗證
            {
                if (isIdentificationId(textBox1.Text))//驗證身份證字號,正確回傳true
                {
                    textBox1.Text = textBox1.Text.ToUpper();//英文自動轉成大寫
                    MessageBox.Show(textBox1.Text + "是正確的身份證字號", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else//驗證身份證字號,不正確回傳false
                {
                    MessageBox.Show("身份證字號有誤", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("身份證字號有誤", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #region checkID
        public static bool isIdentificationId(string arg_Identify)
        {
            var d = false;
            if (arg_Identify.Length == 10)
            {
                arg_Identify = arg_Identify.ToUpper();
                if (arg_Identify[0] >= 0x41 && arg_Identify[0] <= 0x5A)
                {
                    var a = new[] { 10, 11, 12, 13, 14, 15, 16, 17, 34, 18, 19, 20, 21, 22, 35, 23, 24, 25, 26, 27, 28, 29, 32, 30, 31, 33 };
                    var b = new int[11];
                    b[1] = a[(arg_Identify[0]) - 65] % 10;
                    var c = b[0] = a[(arg_Identify[0]) - 65] / 10;
                    for (var i = 1; i <= 9; i++)
                    {
                        b[i + 1] = arg_Identify[i] - 48;
                        c += b[i] * (10 - i);
                    }
                    if (((c % 10) + b[10]) % 10 == 0)
                    {
                        d = true;
                    }
                }
            }
            return d;
        }
        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            this.Visible = false;
            home.Visible = true;
        }

        private void Week05_Load(object sender, EventArgs e)
        {

        }
    }
}
