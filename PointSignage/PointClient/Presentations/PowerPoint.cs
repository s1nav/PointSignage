using Microsoft.Office.Core;
using Microsoft.Office.Interop.PowerPoint;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointClient.Presentations
{
    class PowerPoint : IPresentation
    {
        private Application _pptApp;
        private Presentation _presentation;
        public string FilePath { get; set; }
        public bool OverwriteSlidesInterval { get; set; }
        public int SlidesInterval { get; set; } = 20;
        public bool CheckTransitionTiming { get; set; }

        public PowerPoint(string filePath)
        {
            FilePath = filePath;
        }

        public void Start()
        {
            _pptApp = new Application();
            try
            {
                _presentation = _pptApp.Presentations.Open(FilePath);
            }
            catch (Exception)
            {
                Stop();
                throw;
            }
            _pptApp.Visible = MsoTriState.msoTrue;

            if (CheckTransitionTiming)
                SetTransitionTimingOnTime(_presentation);

            _presentation.SlideShowSettings.Run();
        }

        public void Stop()
        {
            if (_presentation != null)
            {
                _presentation.Close();
            }
            if (_pptApp != null)
            {
                _pptApp.Quit();
            }
        }

        private void SetTransitionTimingOnTime(Presentation presentation)
        {
            for (int i = 1; i <= presentation.Slides.Count; i++)
            {
                if (presentation.Slides[i].SlideShowTransition.AdvanceOnClick == MsoTriState.msoTrue)
                {
                    presentation.Slides[i].SlideShowTransition.AdvanceOnClick = MsoTriState.msoFalse;
                    presentation.Slides[i].SlideShowTransition.AdvanceOnTime = MsoTriState.msoTrue;
                    presentation.Slides[i].SlideShowTransition.AdvanceTime = SlidesInterval;
                }
            }

        }
    }
}
