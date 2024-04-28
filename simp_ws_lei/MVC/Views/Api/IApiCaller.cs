using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simp_ws_lei.MVC.Views
{
    public interface IApiCaller
    {
        string Get(string url);
    }
}
