using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EpicGames_Launcher.formlogin
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            base.Hide();
            new login().Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            base.Hide();
            new formlogin.opco().Show();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Code checked enabled.
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox2.Checked == true)
            {
                valid.Enabled = true;
            }
            else
            {
                valid.Enabled = false;
            }
        }
    }
}
