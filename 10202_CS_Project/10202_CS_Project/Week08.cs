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
    public partial class Week08 : Form
    {
        public Week08()
        {
            InitializeComponent();
        }
        string[] files, path;

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            this.Visible = false;
            home.Visible = true;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = path[listBox1.SelectedIndex];
        }

        private void Week08_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)

            {

                files = openFileDialog1.SafeFileNames;

                path = openFileDialog1.FileNames;

                for (int i = 0; i < files.Length; i++)

                {

                    listBox1.Items.Add(files[i]);

                }

            }
        }
    }
}
