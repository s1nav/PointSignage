using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageViewer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            var path = @"E:\CodingTestField\pic.jpg";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(path));

            //if (args.Length != 1)
            //    return;

            //var path = args[0];
            //FileInfo fileInfo = null;

            //try
            //{
            //    fileInfo = new FileInfo(path);
            //    if (!fileInfo.Exists)
            //        fileInfo = null;
            //}
            //catch (Exception)
            //{

            //}

            //if(ReferenceEquals(fileInfo, null))
            //{
            //    return;
            //}
            //else
            //{
            //    Application.EnableVisualStyles();
            //    Application.SetCompatibleTextRenderingDefault(false);
            //    Application.Run(new MainForm(path));
            //}
        }
    }
}
