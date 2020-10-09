using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Core;
using Microsoft.Office.Interop.PowerPoint;

namespace PresenterLibrary
{
    public class PowerPointPresentation
    {
        private Application _pptApp;
        private Presentation _presentation;
        public string FilePath { get; set; }

        public PowerPointPresentation(string filePath)
        {
            FilePath = filePath;
        }

        public void Start()
        {
            _pptApp = new Application();
            try
            {
                _presentation = _pptApp.Presentations.Open(FilePath);
                _pptApp.Visible = MsoTriState.msoTrue;
                _presentation.SlideShowSettings.Run();

            }
            catch (Exception)
            {
                Stop();
                throw;
            }
        }

        public void Stop()
        {
            if (_presentation != null)
            {
                _presentation.Close();
                Marshal.FinalReleaseComObject(_presentation);
            }
            if (_pptApp != null)
            {
                _pptApp.Quit();
                Marshal.FinalReleaseComObject(_pptApp);
            }
        }

        //~PowerPointPresentation()
        //{
        //    if (_presentation != null)
        //    {
        //        _presentation.Close();
        //        _presentation.Application.Quit();
        //    }

        //}
    }
}
