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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = "現在時間是： " + DateTime.Now.ToString();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            timer1.Interval = 100;
            timer1.Enabled = true;
        }

        private void btnWeek01_Click(object sender, EventArgs e)
        {
            Week01 object1 = new Week01();
            this.Visible = false;
            object1.Visible = true;
        }

        private void btnWeek02_Click(object sender, EventArgs e)
        {
            Week02 object2 = new Week02();
            this.Visible = false;
            object2.Visible = true;
        }

        private void btnWeek03_Click(object sender, EventArgs e)
        {
            Week03 object3 = new Week03();
            this.Visible = false;
            object3.Visible = true;
        }
    }
}
