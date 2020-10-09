using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointClient
{
    class Presenter
    {
        private readonly Timer _timer;
        private Configuration.Presenter _config;

        public Presenter(Configuration.Presenter config)
        {
            _timer = new Timer();
            _timer.Interval = 1000;
            _timer.Start();

            _config = config;
        }

        public void Start()
        {

        }

        //private void StartOnTime(DateTime[] startTimes)
        //{
        //    foreach (var time in startTimes)
        //    {

        //    }
        //}
    }
}
