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

        private void btnWeek04_Click(object sender, EventArgs e)
        {
            Week04 object4 = new Week04();
            this.Visible = false;
            object4.Visible = true;
        }

        private void btnWeek05_Click(object sender, EventArgs e)
        {
            Week05 object5 = new Week05();
            this.Visible = false;
            object5.Visible = true;
        }

        private void btnWeek06_Click(object sender, EventArgs e)
        {
            Week06 object6 = new Week06();
            this.Visible = false;
            object6.Visible = true;
        }

        private void btnWeek07_Click(object sender, EventArgs e)
        {
            Week07 object7 = new Week07();
            this.Visible = false;
            object7.Visible = true;
        }

        private void btnWeek08_Click(object sender, EventArgs e)
        {
            Week08 object8 = new Week08();
            this.Visible = false;
            object8.Visible = true;
        }

        private void btnWeek09_Click(object sender, EventArgs e)
        {
            Week09 object9 = new Week09();
            this.Visible = false;
            object9.Visible = true;
        }

        private void btnWeek11_Click(object sender, EventArgs e)
        {
            Week11 object11 = new Week11();
            this.Visible = false;
            object11.Visible = true;
        }

        private void btnWeek12_Click(object sender, EventArgs e)
        {
            Week12 object12 = new Week12();
            this.Visible = false;
            object12.Visible = true;
        }

        private void btnWeek13_Click(object sender, EventArgs e)
        {
            Week13 object13 = new Week13();
            this.Visible = false;
            object13.Visible = true;
        }

        private void btnWeek16_Click(object sender, EventArgs e)
        {
            Week16 object16 = new Week16();
            this.Visible = false;
            object16.Visible = true;
        }
    }
}
