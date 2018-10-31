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
    public partial class Week03 : Form
    {
        public Week03()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (fileDialog.ShowDialog() == DialogResult.OK)
                pictureList.Items.Add(fileDialog.FileName);
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (pictureList.SelectedIndex != -1)
                pictureList.Items.RemoveAt(pictureList.SelectedIndex);
        }

        private void setButton_Click(object sender, EventArgs e)
        {
            timer1.Interval = int.Parse(intervalText.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("請問是否要離開？", "圖片輪播", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.OK)
            {
                Main f = new Main();
                this.Visible = false;
                f.Visible = true;
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            if (pictureList.Visible)
            {
                pictureList.Visible = false;
                addButton.Visible = false;
                removeButton.Visible = false;
                setButton.Visible = false;
                intervalText.Visible = false;
            }
            else
            {
                pictureList.Visible = true;
                addButton.Visible = true;
                removeButton.Visible = true;
                setButton.Visible = true;
                intervalText.Visible = true;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureList.Items.Count != 0)
            {
                pictureList.SelectedIndex = (pictureList.SelectedIndex + 1) % pictureList.Items.Count;
                pictureBox.ImageLocation = pictureList.SelectedItem.ToString();

            }
        }
    }
}
