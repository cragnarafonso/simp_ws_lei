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
        public string StartTime { get; set; }

        [JsonPropertyName("awarenessLevelID")]
        public string AwarenessLevelID { get; set; }

        [JsonPropertyName("endTime")]
        public string EndTime { get; set; }

        public DailyWarningByLocationId() { }

        public DailyWarningByLocationId(string text, string awarenessTypeName, string idAreaAviso, string startTime, string awarenessLevelID, string endTime)
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
            return JsonSerializer.Deserialize<DailyWarningByLocationId>(jsonString);
        }


        public string ToJson()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
