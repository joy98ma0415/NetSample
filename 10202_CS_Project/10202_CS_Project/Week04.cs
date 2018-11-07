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
    public partial class Week04 : Form
    {
        public Week04()
        {
            InitializeComponent();
        }

        private void toolStripButtonPrev_Click(object sender, EventArgs e)
        {
            webBrowser.GoBack();
        }

        private void toolStripButtonNext_Click(object sender, EventArgs e)
        {
            webBrowser.GoForward();
        }

        private void toolStripComboBoxUrl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                goUrl(toolStripComboBoxUrl.Text);
            }

        }

        private void toolStripButtonGo_Click(object sender, EventArgs e)
        {
            goUrl(toolStripComboBoxUrl.Text);
        }

        private void goUrl(String url)
        {
            toolStripComboBoxUrl.Text = url;
            webBrowser.Navigate(url);
        }

        private void webBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            toolStripComboBoxUrl.Text = webBrowser.Url.ToString();
        }
    }
}
