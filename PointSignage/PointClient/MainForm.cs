using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointClient
{
    public partial class MainForm : Form
    {
        private Presentations.PowerPoint _presentation;
        private Presentations.SlideShow _picture;
        private Presentations.WebPage _webPage;
        private Presentations.Video _video;
        private Configuration.Presentation _presentationConfig;
        private Configuration.Presenter _presenterConfig;
        private Presenter _presenter;
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                listBoxSelectedFiles.Items.Add(openFileDialog.FileName);
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            //foreach (var file in listBoxSelectedFiles.Items)
            //{
            //    _presentation = new Presentations.PowerPoint(file.ToString());
            //    _presentationConfig = new Configuration.Presentation(_presentation)
            //    {
            //        ShowTimeInSeconds = 30
            //    };
            //    _presenterConfig.AddItem(_presentationConfig);
            //}
            //_presenter = new Presenter(_presenterConfig);
            //_presenter.Start();

            //var path = @"E:\CodingTestField";
            //_picture = new Presentations.SlideShow(path, 2);
            //_picture.Start();
            //var url = @"https://www.c-sharpcorner.com/UploadFile/mahesh/webbrowser-control-in-C-Sharp-and-windows-forms/";
            //_webPage = new Presentations.WebPage(url);
            //_webPage.Start();

            var filePath = @"E:\CodingTestField\VID_20200711_161118.mp4";
            _video = new Presentations.Video(filePath);
            _video.Start();

        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            _video.Stop();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            listBoxSelectedFiles.Items.Clear();
        }
    }
}
