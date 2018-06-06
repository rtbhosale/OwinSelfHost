using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace topshelfdemo
{
    public class DemoController : ApiController
    {
        public string get()
        {
            return "Hello world";
        }
    }
}
