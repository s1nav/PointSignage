using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointClient.Configuration
{
    public class Presenter
    {
        private List<Presentation> _presentationConfigs = new List<Presentation>();

        public void AddItem(Presentation presentation)
        {
            _presentationConfigs.Add(presentation);
        }
    }
}
