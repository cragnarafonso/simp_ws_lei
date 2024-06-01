using System;
using System.Collections.Generic;

// ADICIONADO POR DAVID -------

namespace simp_ws_lei.Records
{
    public interface IDailySeaForecast
    {
        string Owner { get; set; }
        string Country { get; set; }
        List<SeaForecastData> Data { get; set; }
        string DataUpdate { get; set; }
        string ForecastDate { get; set; }
    }
}
