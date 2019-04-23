using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileMenuDropdown
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
            NewDoc newDoc = new NewDoc();            
            newDoc.MdiParent = this;
            newDoc.Show();
            */
            // TODO - Use alternative browser engine (CefSharp, GeckoFX)
            WebForm WebDoc = new WebForm();
            WebDoc.MdiParent = this;
            WebDoc.Show();
            //appStatusBar.Text = "Loading new browser window...";
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            // Get reference to currently active child window
            Form ActiveChildWindow = this.ActiveMdiChild;

            if(ActiveChildWindow != null)
            {
                try
                {
                    WebBrowser ActiveBrowser = (WebBrowser)ActiveChildWindow.ActiveControl;
                    if (ActiveBrowser.CanGoBack)
                    {
                        ActiveBrowser.GoBack();
                    }
                }
                catch
                {
                    MessageBox.Show("No currently active browser window.");
                }
            }
        }

        private void fwdBtn_Click(object sender, EventArgs e)
        {
            // Get reference to currently active child window
            Form ActiveChildWindow = this.ActiveMdiChild;

            if (ActiveChildWindow != null)
            {
                try
                {
                    WebBrowser ActiveBrowser = (WebBrowser)ActiveChildWindow.ActiveControl;
                    if (ActiveBrowser.CanGoForward)
                    {
                        ActiveBrowser.GoForward();
                    }
                }
                catch
                {
                    MessageBox.Show("No currently active browser window.");
                }
            }
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            // Get reference to currently active child window
            Form ActiveChildWindow = this.ActiveMdiChild;

            if (ActiveChildWindow != null)
            {
                try
                {
                    WebBrowser ActiveBrowser = (WebBrowser)ActiveChildWindow.ActiveControl;
                    ActiveBrowser.Navigate("https://www.bing.com");
                }
                catch
                {
                    MessageBox.Show("No currently active browser window.");
                }
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            // Get reference to currently active child window
            Form ActiveChildWindow = this.ActiveMdiChild;

            if (ActiveChildWindow != null)
            {
                try
                {
                    WebBrowser ActiveBrowser = (WebBrowser)ActiveChildWindow.ActiveControl;
                    ActiveBrowser.Navigate(addressTextbox.Text);
                }
                catch
                {
                    MessageBox.Show("No currently active browser window.");
                }
            }
        }
        /*
        private void FormMain_Load(object sender, EventArgs e)
        {

        }
        */
    }
}
