using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

//ADICIONADO POR Paulo -------

namespace simp_ws_lei.Records
{
    public interface IWarningData
    {
        string PrecipitaProb { get; set; }
        string TMin { get; set; }
        string TMax { get; set; }
        string PredWindDir { get; set; }
        int IdWeatherType { get; set; }
        int ClassWindSpeed { get; set; }
        string Longitude { get; set; }
        string ForecastDate { get; set; }
        int ClassPrecInt { get; set; }
        string Latitude { get; set; }
    }
}
