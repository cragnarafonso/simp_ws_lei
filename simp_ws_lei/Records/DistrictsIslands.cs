using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;

namespace simp_ws_lei.Records
{
    public class DistrictsIslands : IDistrictsIslands
    {
        // Auto-implemented properties for trivial get and set
        [JsonPropertyName("globalIdLocal")]
        public int GlobalLocalId { get; set; }
        [JsonPropertyName("local")]
        public string LocalName { get; set; }
        [JsonPropertyName("idRegiao")]
        public int RegionId { get; set; }
        [JsonPropertyName("idConcelho")]
        public int CountyId { get; set; }
        [JsonPropertyName("idDistrito")]
        public int DistrictId { get; set; }
        [JsonPropertyName("idAreaAviso")]
        public string WarnAreaId { get; set; }
        [JsonPropertyName("latitude")]
        public string Latitude { get; set; }
        [JsonPropertyName("longitude")]
        public string Longitude { get; set; }


        // Constructores

        public DistrictsIslands() { }

        public DistrictsIslands(int globalLocalId, string localName, int regionId, int countyId, int districtId, string warnAreaId, string latitude, string longitude)
        {
            GlobalLocalId = globalLocalId;
            LocalName = localName;
            RegionId = regionId;
            CountyId = countyId;
            DistrictId = districtId;
            WarnAreaId = warnAreaId;
            Latitude = latitude;
            Longitude = longitude;
        }

        public static DistrictsIslands FromJson(string jsonString)
        {
            return JsonSerializer.Deserialize<DistrictsIslands>(jsonString);
        }

        public string ToJson()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
