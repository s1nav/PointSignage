using PresenterLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    class Program
    {
        static void Main()
        {
            //var ppt = @"E:\CodingTestField\test.pptx";
            //var tpt = @"E:\CodingTestField\tour.pptx";
            ////Test();
            //var present = new PowerPointPresentation(ppt);
            //present.Start();
            //Thread.Sleep(10000);
            //present.Stop();
            ////present2 = null;
            //GC.Collect();
            var path = @"E:\CodingTestField\ubuntu.png";
            //var imageApp = new ImageViewer.AppControl();
            //imageApp.Start(path);
            //Thread.Sleep(5000);
            //imageApp.Stop();

            ImageViewer.AppControl.Start(path);
            //Thread.Sleep(5000);
            //ImageViewer.AppControl.Stop();


            Console.ReadLine();
        }

    }
}
