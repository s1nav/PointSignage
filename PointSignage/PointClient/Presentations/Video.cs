using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointClient.Presentations
{
    class Video : IPresentation
    {
        private Forms.VideoForm _form;
        public string FilePath { get; set; }

        public Video(string filePath)
        {
            _form = new Forms.VideoForm();
            FilePath = filePath;
        }
        public void Start()
        {
            _form.Show();
            _form.Play(FilePath);
        }

        public void Stop()
        {
            _form.Close();
        }
    }
}
