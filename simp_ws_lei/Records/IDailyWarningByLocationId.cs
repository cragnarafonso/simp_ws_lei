using System;

namespace simp_ws_lei.Records
{
    public interface IDailyWarningByLocationId
    {
        string Text { get; set; }
        string AwarenessTypeName { get; set; }
        string IdAreaAviso { get; set; }
        DateTime StartTime { get; set; }
        string AwarenessLevelID { get; set; }
        DateTime EndTime { get; set; }
    }
}
