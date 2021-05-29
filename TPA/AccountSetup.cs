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
    public partial class AccountSetup : Telerik.WinControls.UI.RadForm
    {
        public AccountSetup()
        {
            InitializeComponent();
            Set_Grid();
        }
        private  void Set_Grid()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int)).DefaultValue = 0;
            dt.Columns.Add("Name1", typeof(string)).DefaultValue = "";
            dt.Columns.Add("Name2", typeof(string)).DefaultValue = "";
            dt.Columns.Add("Name3", typeof(string)).DefaultValue = "";
            dt.Columns.Add("Name4", typeof(string)).DefaultValue = "";
            dt.Columns.Add("Name5", typeof(string)).DefaultValue = "";
            dt.Columns.Add("Name6", typeof(string)).DefaultValue = "";
            dt.Columns.Add("Name7", typeof(string)).DefaultValue = "";
            dt.Columns.Add("Name8", typeof(string)).DefaultValue = "";
            dt.Columns.Add("Name9", typeof(string)).DefaultValue = "";
            dt.Columns.Add("Name10", typeof(string)).DefaultValue = "";

            dt.PrimaryKey = new DataColumn[] { dt.Columns["ID"] };


            for (int i = 1; i <= 4000000; i++)
            {
                DataRow row = dt.NewRow();
                row[0] = i;
                row[1] = "Name1";
                row[2] = "Name2";
                row[3] = "Name3";
                row[4] = "Name4";
                row[5] = "Name5";
                row[6] = "Name6";
                row[7] = "Name7";
                row[8] = "Name8";
                row[9] = "Name9";
                row[10] = "Name10";

                dt.Rows.Add(row);

            }
            radGridView1.DataSource = dt;
            //radVirtualGrid1.p = dt;


        }
    }
}
