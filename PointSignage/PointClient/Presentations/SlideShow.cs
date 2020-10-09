using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointClient.Presentations
{
    class SlideShow : IPresentation
    {
        private Forms.PictureForm _form;
        private Timer _timer = new Timer();
        private FileInfo[] _pictures;
        private int _index = 0;
        private int _picturesCount;
        private int _timerInterval;
        public string FolderPath { get; set; }
        public int SlideShowIntervalInSeconds { get; set; }

        public SlideShow(string folderPath, int slideShowIntervalInSeconds)
        {
            FolderPath = folderPath;
            var picturesDir = new DirectoryInfo(folderPath);
            var filter = "*.png";
            _pictures = picturesDir.GetFiles(filter);
            _picturesCount = _pictures.Length;
            _form = new Forms.PictureForm();
            _timerInterval = slideShowIntervalInSeconds * 1000;
        }
        public void Start()
        {
            _timer.Interval = 1;
            _timer.Tick += ShowNextPicture;
            _timer.Start();
        }

        public void Stop()
        {
            _timer.Stop();
            _form.Close();
        }

        private void ShowNextPicture(object source, EventArgs e)
        {
            _timer.Interval = _timerInterval;
            if (_index < _picturesCount)
            {
                _form.Show();
                _form.ShowPicture(_pictures[_index].FullName);
                _index++;
            }
            else
            {
                _index = 0;
                _form.ShowPicture(_pictures[_index].FullName);
            }
        }
    }
}
