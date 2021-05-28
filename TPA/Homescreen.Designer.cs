namespace TPA
{
    partial class Homescreen
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
            this.radPageView1 = new Telerik.WinControls.UI.RadPageView();
            this.radPageViewPage1 = new Telerik.WinControls.UI.RadPageViewPage();
            this.radPageViewPage2 = new Telerik.WinControls.UI.RadPageViewPage();
            this.radPageViewPage3 = new Telerik.WinControls.UI.RadPageViewPage();
            this.radPageViewPage4 = new Telerik.WinControls.UI.RadPageViewPage();
            this.radPageViewPage5 = new Telerik.WinControls.UI.RadPageViewPage();
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).BeginInit();
            this.radPageView1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radPageView1
            // 
            this.radPageView1.Controls.Add(this.radPageViewPage1);
            this.radPageView1.Controls.Add(this.radPageViewPage2);
            this.radPageView1.Controls.Add(this.radPageViewPage3);
            this.radPageView1.Controls.Add(this.radPageViewPage4);
            this.radPageView1.Controls.Add(this.radPageViewPage5);
            this.radPageView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPageView1.Location = new System.Drawing.Point(0, 0);
            this.radPageView1.Name = "radPageView1";
            this.radPageView1.SelectedPage = this.radPageViewPage3;
            this.radPageView1.Size = new System.Drawing.Size(1433, 748);
            this.radPageView1.TabIndex = 0;
            this.radPageView1.ThemeName = "TelerikMetroTouch";
            this.radPageView1.ViewMode = Telerik.WinControls.UI.PageViewMode.NavigationView;
            ((Telerik.WinControls.UI.RadPageViewNavigationViewElement)(this.radPageView1.GetChildAt(0))).ExpandedPaneWidth = 280;
            ((Telerik.WinControls.UI.RadPageViewNavigationViewElement)(this.radPageView1.GetChildAt(0))).CollapsedPaneWidth = 40;
            ((Telerik.WinControls.UI.RadPageViewNavigationViewElement)(this.radPageView1.GetChildAt(0))).ShowItemPinButton = true;
            ((Telerik.WinControls.UI.RadPageViewNavigationViewElement)(this.radPageView1.GetChildAt(0))).ShowItemCloseButton = true;
            // 
            // radPageViewPage1
            // 
            this.radPageViewPage1.ItemSize = new System.Drawing.SizeF(16F, 12F);
            this.radPageViewPage1.Location = new System.Drawing.Point(150, 33);
            this.radPageViewPage1.Name = "radPageViewPage1";
            this.radPageViewPage1.Size = new System.Drawing.Size(1282, 714);
            this.radPageViewPage1.Text = "radPageViewPage1";
            // 
            // radPageViewPage2
            // 
            this.radPageViewPage2.ItemSize = new System.Drawing.SizeF(16F, 12F);
            this.radPageViewPage2.Location = new System.Drawing.Point(101, 33);
            this.radPageViewPage2.Name = "radPageViewPage2";
            this.radPageViewPage2.Size = new System.Drawing.Size(1331, 714);
            this.radPageViewPage2.Text = "radPageViewPage2";
            // 
            // radPageViewPage3
            // 
            this.radPageViewPage3.ItemSize = new System.Drawing.SizeF(16F, 12F);
            this.radPageViewPage3.Location = new System.Drawing.Point(41, 33);
            this.radPageViewPage3.Name = "radPageViewPage3";
            this.radPageViewPage3.Size = new System.Drawing.Size(1391, 714);
            this.radPageViewPage3.Text = "radPageViewPage3";
            // 
            // radPageViewPage4
            // 
            this.radPageViewPage4.ItemSize = new System.Drawing.SizeF(16F, 12F);
            this.radPageViewPage4.Location = new System.Drawing.Point(150, 33);
            this.radPageViewPage4.Name = "radPageViewPage4";
            this.radPageViewPage4.Size = new System.Drawing.Size(1282, 714);
            this.radPageViewPage4.Text = "radPageViewPage4";
            // 
            // radPageViewPage5
            // 
            this.radPageViewPage5.ItemSize = new System.Drawing.SizeF(16F, 12F);
            this.radPageViewPage5.Location = new System.Drawing.Point(101, 33);
            this.radPageViewPage5.Name = "radPageViewPage5";
            this.radPageViewPage5.Size = new System.Drawing.Size(1331, 714);
            this.radPageViewPage5.Text = "radPageViewPage5";
            // 
            // Homescreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1433, 748);
            this.Controls.Add(this.radPageView1);
            this.Name = "Homescreen";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Homescreen";
            this.ThemeName = "TelerikMetroTouch";
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).EndInit();
            this.radPageView1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPageView radPageView1;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage1;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage2;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage3;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage4;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage5;
    }
}
