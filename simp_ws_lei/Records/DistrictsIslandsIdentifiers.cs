using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;

namespace simp_ws_lei.Records
{
    public class DistrictsIslandsIdentifiers : IDistrictsIslandsIdentifiers
    {
        [JsonPropertyName("owner")]
        public string Owner { get; set; }
        [JsonPropertyName("country")]
        public string Country { get; set; }
        [JsonPropertyName("data")]
        public List<DistrictsIslands> Data { get; set; }


        public DistrictsIslandsIdentifiers() { }

        public DistrictsIslandsIdentifiers(string owner, string country, List<DistrictsIslands> data)
        {
            Owner = owner;
            Country = country;
            Data = data;
        }

        public static DistrictsIslandsIdentifiers FromJson(string jsonString)
        {
            return JsonSerializer.Deserialize<DistrictsIslandsIdentifiers>(jsonString);
        }

        public string ToJson()
        {
            return JsonSerializer.Serialize(this);
        }

        List<Item> IDistrictsIslandsIdentifiers.GetIdNameRegions()
        {
            List<Item> regions = new List<Item>();
            foreach (DistrictsIslands region in Data)
            {
                regions.Add(new Item(region.GlobalLocalId, region.LocalName));
            }
            return regions;
        }
    }
}
