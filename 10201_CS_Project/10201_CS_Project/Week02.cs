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
    public partial class Week02 : Form
    {
        public Week02()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dTP_CurrentDate.Value < dTP_DOB.Value)
                {
                    MessageBox.Show("Current Date must be greater than DOB");
                }

                int Age = dTP_CurrentDate.Value.Year - dTP_DOB.Value.Year;

                if (dTP_DOB.Value.AddYears(Age) > dTP_CurrentDate.Value)
                    Age--;

                int Month = dTP_CurrentDate.Value.Month - dTP_DOB.Value.Month;
                if (dTP_CurrentDate.Value.AddMonths(Month) > dTP_DOB.Value)
                    Month--;
                lblAge.Text = "Your Age : " + Age.ToString() + " 歲" + Month.ToString() + " 月";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message.");
            }

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("請問是否要離開？", "年齡計算", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.OK)
            {
                Main f = new Main();
                this.Visible = false;
                f.Visible = true;
            }

        }
    }
}
