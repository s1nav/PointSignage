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

namespace ImageViewer
{
    public partial class MainForm : Form
    {
        public MainForm(string imagePath)
        {
            InitializeComponent();
            
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var path = @"E:\CodingTestField\pic.jpg";
            var form = new ImageForm(path);
            form.Show();
        }
    }
}
