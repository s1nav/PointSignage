using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointClient.Presentations
{
    class Picture : IPresentation
    {
        private Forms.PictureForm _form;
        public string FilePath { get; }

        public Picture (string filePath)
        {
            FilePath = filePath;
            _form = new Forms.PictureForm();
        }
        public void Start()
        {
            _form.Show();
            _form.ShowPicture(FilePath);
        }

        public void Stop()
        {
            _form.Close();
        }
    }
}
