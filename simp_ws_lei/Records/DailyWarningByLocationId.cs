using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace simp_ws_lei.Records
{
    public class DailyWarningByLocationId : IDailyWarningByLocationId
    {
        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("awarenessTypeName")]
        public string AwarenessTypeName { get; set; }

        [JsonPropertyName("idAreaAviso")]
        public string IdAreaAviso { get; set; }

        [JsonPropertyName("startTime")]
        public DateTime StartTime { get; set; }

        [JsonPropertyName("awarenessLevelID")]
        public string AwarenessLevelID { get; set; }

        [JsonPropertyName("endTime")]
        public DateTime EndTime { get; set; }

        public DailyWarningByLocationId() { }

        public DailyWarningByLocationId(string text, string awarenessTypeName, string idAreaAviso, DateTime startTime, string awarenessLevelID, DateTime endTime)
        {
            Text = text;
            AwarenessTypeName = awarenessTypeName;
            IdAreaAviso = idAreaAviso;
            StartTime = startTime;
            AwarenessLevelID = awarenessLevelID;
            EndTime = endTime;
        }

        public static DailyWarningByLocationId FromJson(string jsonString)
        {
            try
            {
                Console.WriteLine($"Attempting to deserialize the following JSON: {jsonString}");
                return JsonSerializer.Deserialize<DailyWarningByLocationId>(jsonString);
            }
            catch (JsonException ex)
            {
                Console.WriteLine($"JSON Deserialization failed: {ex.Message}");
                throw;
            }
        }

        public string ToJson()
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            return JsonSerializer.Serialize(this, options);
        }
    }
}
