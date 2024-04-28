using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simp_ws_lei.Records
{
    public interface IDistrictsIslands
    {
        int GlobalLocalId { get; set; }
        string LocalName { get; set; }
        int RegionId { get; set; }
        int CountyId { get; set; }
        int DistrictId { get; set; }
        string WarnAreaId { get; set; }
        string Latitude { get; set; }
        string Longitude { get; set; }
    }
}
