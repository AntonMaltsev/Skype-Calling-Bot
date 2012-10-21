using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SkypeCallingBot
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void TestBtn_Click(object sender, EventArgs e)
        {
            Model.check();
        }

        private void StartCallBtn_Click(object sender, EventArgs e)
        {

        }

        private void phonesRefreshBtn_Click(object sender, EventArgs e)
        {

        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {

        }

        private void callSettings_Click(object sender, EventArgs e)
        {

        }
    }
}
