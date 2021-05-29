namespace TPA
{
    partial class AccountSetup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition12 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition11 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radPageView1 = new Telerik.WinControls.UI.RadPageView();
            this.radPageViewPage1 = new Telerik.WinControls.UI.RadPageViewPage();
            this.radPanel2 = new Telerik.WinControls.UI.RadPanel();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.radPageViewPage2 = new Telerik.WinControls.UI.RadPageViewPage();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radTextBox1 = new Telerik.WinControls.UI.RadTextBox();
            this.radTextBox2 = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radMultiColumnComboBox1 = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).BeginInit();
            this.radPageView1.SuspendLayout();
            this.radPageViewPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).BeginInit();
            this.radPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMultiColumnComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMultiColumnComboBox1.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMultiColumnComboBox1.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radPageView1
            // 
            this.radPageView1.Controls.Add(this.radPageViewPage1);
            this.radPageView1.Controls.Add(this.radPageViewPage2);
            this.radPageView1.DefaultPage = this.radPageViewPage1;
            this.radPageView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPageView1.Location = new System.Drawing.Point(0, 0);
            this.radPageView1.Name = "radPageView1";
            this.radPageView1.SelectedPage = this.radPageViewPage1;
            this.radPageView1.Size = new System.Drawing.Size(1186, 689);
            this.radPageView1.TabIndex = 0;
            this.radPageView1.ThemeName = "TelerikMetroTouch";
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.radPageView1.GetChildAt(0))).ShowItemPinButton = false;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.radPageView1.GetChildAt(0))).StripButtons = Telerik.WinControls.UI.StripViewButtons.None;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.radPageView1.GetChildAt(0))).ShowItemCloseButton = false;
            // 
            // radPageViewPage1
            // 
            this.radPageViewPage1.Controls.Add(this.radPanel2);
            this.radPageViewPage1.Controls.Add(this.radPanel1);
            this.radPageViewPage1.ItemSize = new System.Drawing.SizeF(117F, 29F);
            this.radPageViewPage1.Location = new System.Drawing.Point(5, 35);
            this.radPageViewPage1.Name = "radPageViewPage1";
            this.radPageViewPage1.Size = new System.Drawing.Size(1176, 649);
            this.radPageViewPage1.Text = "Detail Accounts";
            // 
            // radPanel2
            // 
            this.radPanel2.Controls.Add(this.radMultiColumnComboBox1);
            this.radPanel2.Controls.Add(this.radLabel3);
            this.radPanel2.Controls.Add(this.radTextBox2);
            this.radPanel2.Controls.Add(this.radLabel1);
            this.radPanel2.Controls.Add(this.radTextBox1);
            this.radPanel2.Controls.Add(this.radLabel2);
            this.radPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanel2.Location = new System.Drawing.Point(495, 0);
            this.radPanel2.Name = "radPanel2";
            this.radPanel2.Size = new System.Drawing.Size(681, 649);
            this.radPanel2.TabIndex = 1;
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.radGridView1);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(495, 649);
            this.radPanel1.TabIndex = 0;
            // 
            // radGridView1
            // 
            this.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridView1.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition12;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.Size = new System.Drawing.Size(495, 649);
            this.radGridView1.TabIndex = 0;
            // 
            // radPageViewPage2
            // 
            this.radPageViewPage2.ItemSize = new System.Drawing.SizeF(113F, 29F);
            this.radPageViewPage2.Location = new System.Drawing.Point(5, 40);
            this.radPageViewPage2.Name = "radPageViewPage2";
            this.radPageViewPage2.Size = new System.Drawing.Size(1176, 644);
            this.radPageViewPage2.Text = "Party Accounts";
            // 
            // radLabel2
            // 
            this.radLabel2.AutoSize = false;
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(6, 99);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(142, 29);
            this.radLabel2.TabIndex = 2;
            this.radLabel2.Text = "Code:";
            this.radLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.radLabel2.ThemeName = "TelerikMetroTouch";
            // 
            // radTextBox1
            // 
            this.radTextBox1.Location = new System.Drawing.Point(154, 99);
            this.radTextBox1.Name = "radTextBox1";
            this.radTextBox1.Size = new System.Drawing.Size(290, 32);
            this.radTextBox1.TabIndex = 3;
            this.radTextBox1.ThemeName = "TelerikMetroTouch";
            // 
            // radTextBox2
            // 
            this.radTextBox2.Location = new System.Drawing.Point(154, 137);
            this.radTextBox2.Name = "radTextBox2";
            this.radTextBox2.Size = new System.Drawing.Size(520, 32);
            this.radTextBox2.TabIndex = 5;
            this.radTextBox2.ThemeName = "TelerikMetroTouch";
            // 
            // radLabel1
            // 
            this.radLabel1.AutoSize = false;
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(6, 137);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(142, 29);
            this.radLabel1.TabIndex = 4;
            this.radLabel1.Text = "Account Description:";
            this.radLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.radLabel1.ThemeName = "TelerikMetroTouch";
            // 
            // radLabel3
            // 
            this.radLabel3.AutoSize = false;
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel3.Location = new System.Drawing.Point(6, 175);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(142, 29);
            this.radLabel3.TabIndex = 6;
            this.radLabel3.Text = "Account Type:";
            this.radLabel3.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.radLabel3.ThemeName = "TelerikMetroTouch";
            // 
            // radMultiColumnComboBox1
            // 
            // 
            // radMultiColumnComboBox1.NestedRadGridView
            // 
            this.radMultiColumnComboBox1.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.radMultiColumnComboBox1.EditorControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMultiColumnComboBox1.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radMultiColumnComboBox1.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.radMultiColumnComboBox1.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.radMultiColumnComboBox1.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.radMultiColumnComboBox1.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.radMultiColumnComboBox1.EditorControl.MasterTemplate.EnableGrouping = false;
            this.radMultiColumnComboBox1.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.radMultiColumnComboBox1.EditorControl.MasterTemplate.ViewDefinition = tableViewDefinition11;
            this.radMultiColumnComboBox1.EditorControl.Name = "NestedRadGridView";
            this.radMultiColumnComboBox1.EditorControl.ReadOnly = true;
            this.radMultiColumnComboBox1.EditorControl.ShowGroupPanel = false;
            this.radMultiColumnComboBox1.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.radMultiColumnComboBox1.EditorControl.TabIndex = 0;
            this.radMultiColumnComboBox1.Location = new System.Drawing.Point(154, 175);
            this.radMultiColumnComboBox1.Name = "radMultiColumnComboBox1";
            this.radMultiColumnComboBox1.Size = new System.Drawing.Size(290, 32);
            this.radMultiColumnComboBox1.TabIndex = 7;
            this.radMultiColumnComboBox1.TabStop = false;
            this.radMultiColumnComboBox1.Text = "radMultiColumnComboBox1";
            this.radMultiColumnComboBox1.ThemeName = "TelerikMetroTouch";
            // 
            // AccountSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 689);
            this.Controls.Add(this.radPageView1);
            this.Name = "AccountSetup";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "FINANCIAL SETUP";
            this.ThemeName = "TelerikMetroTouch";
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).EndInit();
            this.radPageView1.ResumeLayout(false);
            this.radPageViewPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).EndInit();
            this.radPanel2.ResumeLayout(false);
            this.radPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMultiColumnComboBox1.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMultiColumnComboBox1.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMultiColumnComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPageView radPageView1;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage1;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage2;
        private Telerik.WinControls.UI.RadPanel radPanel2;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadTextBox radTextBox1;
        private Telerik.WinControls.UI.RadTextBox radTextBox2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadMultiColumnComboBox radMultiColumnComboBox1;
    }
}
