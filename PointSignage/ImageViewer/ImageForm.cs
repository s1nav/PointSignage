﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageViewer
{
    public partial class ImageForm : Form
    {
        public ImageForm(string path)
        {
            InitializeComponent();
            pictureBox1.Load(path);
        }
    }
}
