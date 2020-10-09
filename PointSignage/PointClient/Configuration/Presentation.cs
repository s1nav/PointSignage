using PointClient.Presentations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointClient.Configuration
{
    public class Presentation
    {
        public IPresentation Item { get; }
        public DateTime StartAt { get; set; }
        public DateTime StopAt { get; set; }
        public int ShowTimeInSeconds { get; set; }

        public Presentation(IPresentation item)
        {
            Item = item;
        }
    }
}
