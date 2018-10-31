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
    public partial class Week15 : Form
    {
        public Week15()
        {
            InitializeComponent();
        }
        int guess, count, min, max;

        private void btnOk_Click(object sender, EventArgs e)
        {
            count += 1;
            int myguess = 0;
            try
            {
                myguess = int.Parse(txtGuess.Text); //判斷輸入職
            }
            catch
            {
                MessageBox.Show(" == 請輸入數字！！！");
            }

            if (myguess >= 1 && myguess < 100)
            {
                if (myguess == guess)
                {
                    MessageBox.Show(" == 恭喜！你猜對了");
                    btnOk.Enabled = false;
                }
                else if (myguess > guess)
                {
                    max = myguess; //將輸入值取代最大值
                    MessageBox.Show(" == 再小一點！");
                }
                else if (myguess < guess)
                {
                    min = myguess; //將輸入值取代最小值
                    MessageBox.Show(" == 再大一點！");
                }
            }
            else
            {
                MessageBox.Show(" == 請輸入提示範圍內的數字..");
            }

            lblMsg.Text = " == 共猜了" + count + "次.. ";
            lblTitle.Text = min + "< ? <" + max;
        }

        private void btnAgain_Click(object sender, EventArgs e)
        {
            Week15_Load(sender, e);
        }

        private void Week15_Load(object sender, EventArgs e)
        {
            Random r = new Random(); //產生亂數物件 r
            guess = r.Next(1, 100);  //產生1-99亂數當被猜樹置入guess
            min = 0;
            max = 100;
            count = 0;
            lblTitle.Text = min + " < ? < " + max;
            lblMsg.Text = "共猜了" + count + "次";
            btnOk.Enabled = true;
            txtGuess.Text = "";
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("請問是否要離開？", "猜數字遊戲", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.OK)
            {
                Main f = new Main();
                this.Visible = false;
                f.Visible = true;
            }


        }
    }
}
