using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace TPA
{
    public partial class Login : Telerik.WinControls.UI.RadForm
    {
        public Login()
        {
            InitializeComponent();
            Initial_Settings();
        }
        private void Initial_Settings()
        {
            panelFY.Visible = false;
            panelFY.PanelElement.PanelBorder.Visibility = ElementVisibility.Collapsed;

            Combo_Setting(radMultiColumnComboBox1, "Branch_FName", "Branch_ID");
            Combo_Setting(radMultiColumnComboBox2, "Dept_DD", "Dept_ID");
            Combo_Setting(radMultiColumnComboBox3, "FY","FY");

        }
        private void Combo_Setting(RadMultiColumnComboBox combo,string DisplayMember, string ValueMember)
        {
            combo.DropDownStyle = RadDropDownStyle.DropDownList;
            //combo.Columns.Add(new GridViewTextBoxColumn(ValueMember));
            //combo.Columns.Add(new GridViewTextBoxColumn(DisplayMember));
            combo.ValueMember = ValueMember;
            combo.DisplayMember = DisplayMember;

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
