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
    public partial class Week12 : Form
    {
        public Week12()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Joy Ma" || textBox2.Text == "Joyma840531")
            {
                MessageBox.Show("You are logged in successfully..");
                this.Visible = false;
                Form1 obj1 = new Form1();
                obj1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Enter Valid Username and Password.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
