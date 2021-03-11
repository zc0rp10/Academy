using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsTutorial.WF
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSayHello_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxUserName.Text))
            {
                lstNames.Items.Add(textBoxUserName.Text);
                textBoxUserName.Text = "";
            }
        }
    }
}
