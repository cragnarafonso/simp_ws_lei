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
    public class DailyMeteorologyByLocationId : IDailyMeteorologyByLocationId
    {
        [JsonPropertyName("owner")]
        public string Owner { get; set; }

        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("data")]
        public List<MeteorologyData> Data { get; set; }

        [JsonPropertyName("globalIdLocal")]
        public int GlobalIdLocal { get; set; }

        [JsonPropertyName("dataUpdate")]
        public string DataUpdate { get; set; }


        public DailyMeteorologyByLocationId() { }


        public DailyMeteorologyByLocationId(string owner, string country, List<MeteorologyData> data, int globalIdLocal, string dataUpdate)
        {
            Owner = owner;
            Country = country;
            Data = data;
            GlobalIdLocal = globalIdLocal;
            DataUpdate = dataUpdate;
        }


        public static DailyMeteorologyByLocationId FromJson(string jsonString)
        {
            return JsonSerializer.Deserialize<DailyMeteorologyByLocationId>(jsonString);
        }


        public string ToJson()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
