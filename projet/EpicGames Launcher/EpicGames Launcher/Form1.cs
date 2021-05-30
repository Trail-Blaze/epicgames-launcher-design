using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace EpicGames_Launcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void launch_Tick(object sender, EventArgs e)
        {
            launch.Stop();
            base.Hide();
            new formlogin.opco().Show();
        }
    }
}
