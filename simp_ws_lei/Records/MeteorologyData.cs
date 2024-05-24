using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

//ADICIONADO POR MIGUEL -------

namespace simp_ws_lei.Records
{
    public class MeteorologyData : IMeteorologyData
    {
        [JsonPropertyName("precipitaProb")]
        public string PrecipitaProb { get; set; }

        [JsonPropertyName("tMin")]
        public string TMin { get; set; }

        [JsonPropertyName("tMax")]
        public string TMax { get; set; }

        [JsonPropertyName("predWindDir")]
        public string PredWindDir { get; set; }

        [JsonPropertyName("idWeatherType")]
        public int IdWeatherType { get; set; }

        [JsonPropertyName("classWindSpeed")]
        public int ClassWindSpeed { get; set; }

        [JsonPropertyName("longitude")]
        public string Longitude { get; set; }

        [JsonPropertyName("forecastDate")]
        public string ForecastDate { get; set; }

        [JsonPropertyName("classPrecInt")]
        public int ClassPrecInt { get; set; }

        [JsonPropertyName("latitude")]
        public string Latitude { get; set; }


        public MeteorologyData (){}


        public MeteorologyData(string precipitaProb, string tMin, string tMax, string predWindDir, int idWeatherType, 
            int classWindSpeed, string longitude, string forecastDate, int classPrecInt, string latitude) {

            PrecipitaProb = precipitaProb;
            TMin = tMin;
            TMax = tMax;
            PredWindDir = predWindDir;
            IdWeatherType = idWeatherType;
            ClassWindSpeed = classWindSpeed;
            Longitude = longitude;
            ForecastDate = forecastDate;
            ClassPrecInt = classPrecInt;
            Latitude = latitude;

        }

        public static MeteorologyData FromJson(string jsonString)
        {
            return JsonSerializer.Deserialize<MeteorologyData>(jsonString);
        }

        public string ToJson()
        {
            return JsonSerializer.Serialize(this);
        }

    }

   
}
