using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;


// ADICIONADO POR DAVID -------

namespace simp_ws_lei.Records
{
    public class DailySeaForecast : IDailySeaForecast
    {
        [JsonPropertyName("owner")]
        public string Owner { get; set; }

        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("data")]
        public List<SeaForecastData> Data { get; set; }

        [JsonPropertyName("dataUpdate")]
        public string DataUpdate { get; set; }

        [JsonPropertyName("forecastDate")]
        public string ForecastDate { get; set; }

        public DailySeaForecast() { }

        public DailySeaForecast(string owner, string country, List<SeaForecastData> data, string dataUpdate, string forecastDate)
        {
            Owner = owner;
            Country = country;
            Data = data;
            DataUpdate = dataUpdate;
            ForecastDate = forecastDate;
        }

        public static DailySeaForecast FromJson(string jsonString)
        {
            return JsonSerializer.Deserialize<DailySeaForecast>(jsonString);
        }

        public string ToJson()
        {
            return JsonSerializer.Serialize(this);
        }
    }

    public class SeaForecastData
    {
        [JsonPropertyName("wavePeriodMin")]
        public double WavePeriodMin { get; set; }

        [JsonPropertyName("wavePeriodMax")]
        public double WavePeriodMax { get; set; }

        [JsonPropertyName("waveHighMin")]
        public double WaveHighMin { get; set; }

        [JsonPropertyName("waveHighMax")]
        public double WaveHighMax { get; set; }

        [JsonPropertyName("predWaveDir")]
        public string PredWaveDir { get; set; }

        [JsonPropertyName("totalSeaMin")]
        public double TotalSeaMin { get; set; }

        [JsonPropertyName("totalSeaMax")]
        public double TotalSeaMax { get; set; }

        [JsonPropertyName("sstMin")]
        public double SstMin { get; set; }

        [JsonPropertyName("sstMax")]
        public double SstMax { get; set; }

        [JsonPropertyName("latitude")]
        public double Latitude { get; set; }

        [JsonPropertyName("longitude")]
        public double Longitude { get; set; }

        [JsonPropertyName("globalIdLocal")]
        public int GlobalIdLocal { get; set; }
    }
}
