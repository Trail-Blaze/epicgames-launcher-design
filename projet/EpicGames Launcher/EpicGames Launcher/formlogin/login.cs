using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EpicGames_Launcher
{
    public partial class login : Form
{
    public login()
    {
        InitializeComponent();
    }

        private void label8_Click(object sender, EventArgs e)
        {
            base.Hide();
            new formlogin.forgot().Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            base.Hide();
            new formlogin.register().Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            base.Hide();
            new formlogin.opco().Show();
        }
    }
}
