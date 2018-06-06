using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using topshelfdemo;

namespace topshelfdemoserver
{
    public class WebServer
    {
        private IDisposable _webserver;

        public void Start()
        {
            _webserver = WebApp.Start<Startup>("http://localhost:12345");
        }

        public void Stop()
        {
            _webserver?.Dispose();
        }
    }
}
