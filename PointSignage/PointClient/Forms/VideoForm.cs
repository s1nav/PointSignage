using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointClient.Forms
{
    public partial class VideoForm : Form
    {
        public VideoForm()
        {

            InitializeComponent();

        }

        public void Play(string path)
        {
            var mediaOptions = new string[] { "input-repeat=65535" };
            var file = new FileInfo(path);
            vlcControl2.SetMedia(file, mediaOptions);
            vlcControl2.Play();
        }

        private void vlcControl2_VlcLibDirectoryNeeded(object sender, Vlc.DotNet.Forms.VlcLibDirectoryNeededEventArgs e)
        {
            if (IntPtr.Size == 4)
                e.VlcLibDirectory = new DirectoryInfo(@"C:\Users\andre\source\repos\s1nav\PointSignage\PointSignage\PointClient\bin\x64\Debug\libvlc\win-x64");
            else
                e.VlcLibDirectory = new DirectoryInfo(@"C:\Users\andre\source\repos\s1nav\PointSignage\PointSignage\PointClient\bin\x64\Debug\libvlc\win-x64");
        }
    }
}
