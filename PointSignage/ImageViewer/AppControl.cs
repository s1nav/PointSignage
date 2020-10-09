using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageViewer
{
    public static class AppControl
    {
        private static MainForm _form;
        private static CancellationTokenSource _tokenSource = new CancellationTokenSource();
        private static CancellationToken _token = _tokenSource.Token;
        //private static Task _task;
        //private static bool _exit = false;

        public static void Start(string path)
        {

                _form = new MainForm(path);
                _form.Show();

        }

        public static void Stop()
        {
            _form.Close();
        }
    }
}
