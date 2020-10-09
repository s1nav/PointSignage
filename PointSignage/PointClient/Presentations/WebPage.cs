using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointClient.Presentations
{
    class WebPage : IPresentation
    {
        private Forms.WebPageForm _form;
        public string Url { get; }
        public int RefreshInterval { get; set; }

        public WebPage(string url)
        {
            Url = url;
            _form = new Forms.WebPageForm();
        }
        public void Start()
        {
            _form.LoadUrl(Url);
            _form.Show();
        }

        public void Stop()
        {
            _form.Close();
        }
    }
}
