using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace simp_ws_lei.MVC.Views
{
    public class IPMARequest
    {
        private static readonly string DISTRITS_ISLANDS = "https://api.ipma.pt/open-data/distrits-islands.json";

        private static readonly string DAILY_METEOROLOGY_LOCATIONID = "https://api.ipma.pt/open-data/forecast/meteorology/cities/daily/{globalIdLocal}.json";

        private static readonly string DAILY_WARNING_LOCATIONID = "https://api.ipma.pt/open-data/forecast/warnings/warnings_www.json";

        private IApiCaller Caller { get; set; }

        public IPMARequest(IApiCaller caller)
        {
            Caller = caller;
        }

        public string GetDistrictsIslandsIdentifiers()
        {
            return Caller.Get(DISTRITS_ISLANDS);
        }

        //ADICIONADO POR MIGUEL -------
        public string GetDailyMeteorologyByLocationId(string globalIdLocal)
        {
            string url = DAILY_METEOROLOGY_LOCATIONID;

            //replace id location parameter from static url
            url = url.Replace("{globalIdLocal}", globalIdLocal);

            return Caller.Get(url);
        }
        //ADICIONADO POR MIGUEL -------




        //ADICIONADO POR Paulo -------
        public string GetDailyWarningByLocationId(string globalIdLocal)
        {
            string url = DAILY_WARNING_LOCATIONID;

            //replace id location parameter from static url
            url = url.Replace("{globalIdLocal}", globalIdLocal);

            return Caller.Get(url);
        }
        //ADICIONADO POR Paulo -------
    }
}
