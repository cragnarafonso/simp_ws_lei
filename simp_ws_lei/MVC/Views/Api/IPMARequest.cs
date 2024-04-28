using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simp_ws_lei.MVC.Views
{
    public class IPMARequest
    {
        private static readonly string DISTRITS_ISLANDS = "https://api.ipma.pt/open-data/distrits-islands.json";
        private IApiCaller Caller { get; set; }

        public IPMARequest(IApiCaller caller)
        {
            Caller = caller;
        }

        public string GetDistrictsIslandsIdentifiers()
        {
            return Caller.Get(DISTRITS_ISLANDS);
        }
    }
}
