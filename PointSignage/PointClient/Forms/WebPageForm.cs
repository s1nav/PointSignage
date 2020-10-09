using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace PointClient.Forms
{
    public partial class WebPageForm : Form
    {
        private readonly ChromiumWebBrowser _browser;
        public WebPageForm()
        {
            InitializeComponent();

            _browser = new ChromiumWebBrowser("about:blank");
            toolStripContainer1.ContentPanel.Controls.Add(_browser);
        }

        public void LoadUrl(string url)
        {
            _browser.Load(url);
        }
    }
}
