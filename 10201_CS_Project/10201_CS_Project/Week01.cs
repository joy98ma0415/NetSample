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
    public partial class Week01 : Form
    {
        public Week01()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name = txtInput.Text;
            MessageBox.Show("Hello " + name + ", Welcome to C Sharp Class~");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("請問是否要離開？", "Hello", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.OK)
            {
                Main f = new Main();
                this.Visible = false;
                f.Visible = true;
            }
        }
    }
}
