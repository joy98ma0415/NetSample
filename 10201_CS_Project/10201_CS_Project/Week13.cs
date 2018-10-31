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
    public partial class Week13 : Form
    {
        public Week13()
        {
            InitializeComponent();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("請問是否要離開？", "錢幣兌換", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.OK)
            {
                Main f = new Main();
                this.Visible = false;
                f.Visible = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, amount, change = 0, coins;
            bool doit;  // 是否兌換此錢幣
            amount = Convert.ToInt32(txtAmount.Text);
            txt1000.Text = "0";
            txt500.Text = "0";
            txt100.Text = "0";  // 清除文字方塊控制項
            txt50.Text = "0";
            txt10.Text = "0";
            txt1.Text = "0";
            for (i = 1; i <= 6; i++)  // 兌換迴圈
            {
                doit = false;
                switch (i)  // 是否選此錢幣
                {
                    case 1:
                        if (chk1000.Checked) doit = true;
                        change = 1000;   // 取得金額
                        break;
                    case 2:
                        if (chk500.Checked) doit = true;
                        change = 500;
                        break;
                    case 3:
                        if (chk100.Checked) doit = true;
                        change = 100;
                        break;
                    case 4:
                        if (chk50.Checked) doit = true;
                        change = 50;
                        break;
                    case 5:
                        if (chk10.Checked) doit = true;
                        change = 10;
                        break;
                    case 6:
                        doit = true;
                        change = 1;
                        break;
                }
                if (doit)
                {
                    if (i == 6)
                        coins = amount;  // 1元
                    else
                    {
                        coins = 0;       // 不是1元
                        // 計算錢幣數
                        while ((amount - change) >= 0)
                        {
                            coins += 1;
                            amount = amount - change;
                        }
                    }
                    // 顯示兌換錢幣數
                    switch (i)
                    {
                        case 1:
                            txt1000.Text = coins.ToString();
                            break;
                        case 2:
                            txt500.Text = coins.ToString();
                            break;
                        case 3:
                            txt100.Text = coins.ToString();
                            break;
                        case 4:
                            txt50.Text = coins.ToString();
                            break;
                        case 5:
                            txt10.Text = coins.ToString();
                            break;
                        case 6:
                            txt1.Text = coins.ToString();
                            break;
                    }
                }
                // 檢查是否已經兌完
                if (amount <= 0) break;  // 離開迴圈
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt1.Clear();
            txt10.Clear();
            txt100.Clear();
            txt1000.Clear();
            txt50.Clear();
            txt500.Clear();
            txtAmount.Clear();
        }
    }
}
