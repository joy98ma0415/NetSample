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
    public partial class Week04 : Form
    {
        public Week04()
        {
            InitializeComponent();
        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            string gender = "性別：", interest = "興趣：", msg;

            if (rdbtn_Male.Checked) gender += rdbtn_Male.Text;
            if (rdbtn_Female.Checked) gender += rdbtn_Female.Text;

            if (chkBox_Accounting.Checked) interest += chkBox_Accounting.Text + "、";
            if (chkBox_Economic.Checked) interest += chkBox_Economic.Text + "、";
            if (chkBox_Multimedia.Checked) interest += chkBox_Multimedia.Text + "、";
            if (chkBox_Database.Checked) interest += chkBox_Database.Text + "、";
            if (chkBox_Programming.Checked) interest += chkBox_Programming.Text + "、";
            if (chkBox_Web.Checked) interest += chkBox_Web.Text + "、";
            if (chkBox_Movie.Checked) interest += chkBox_Movie.Text;
            if (chkBox_3D.Checked) interest += chkBox_3D.Text + "、";


            msg = txtName.Text + "\n" + txtPwd.Text + "\n" + gender + "\n" + interest;
            DialogResult dr = MessageBox.Show(msg, "會員資訊", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes) MessageBox.Show("您已填寫成功，謝謝您", "填寫成功！", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("請問是否要離開？", "會員資訊", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.OK)
            {
                Main f = new Main();
                this.Visible = false;
                f.Visible = true;
            }

        }
    }
}
