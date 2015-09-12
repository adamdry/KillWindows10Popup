using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KillWindows10Popup
{
    public partial class frmMain : Form
    {

        public frmMain()
        {
            InitializeComponent();

            this.ShowInTaskbar = false;
        }

        private void btnEngage_Click(object sender, EventArgs e)
        {
            this.Hide();

            new KillProcess().Start("GWX");
            new KillProcess().Start("GWXUX");
            
        }

    }
}
