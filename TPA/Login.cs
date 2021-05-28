using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace TPA
{
    public partial class Login : Telerik.WinControls.UI.RadForm
    {
        public Login()
        {
            InitializeComponent();
            panelFY.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            panelFY.Visible = true;
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExit1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnLogin1_Click(object sender, EventArgs e)
        {

        }
    }
}
