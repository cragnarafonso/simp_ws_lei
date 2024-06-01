using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

// ADICIONADO POR DAVID -------

namespace simp_ws_lei.Records
{
    public interface ISeaForecastData
    {
        double WavePeriodMin { get; set; }
        double WavePeriodMax { get; set; }
        double WaveHighMin { get; set; }
        double WaveHighMax { get; set; }
        string PredWaveDir { get; set; }
        double TotalSeaMin { get; set; }
        double TotalSeaMax { get; set; }
        double SstMin { get; set; }
        double SstMax { get; set; }
        double Latitude { get; set; }
        double Longitude { get; set; }
        int GlobalIdLocal { get; set; }
    }
}
