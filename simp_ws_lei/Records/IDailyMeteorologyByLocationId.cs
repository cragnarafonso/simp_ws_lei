using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ADICIONADO POR MIGUEL  -------

namespace simp_ws_lei.Records
{
    public interface IDailyMeteorologyByLocationId
    {
        string Owner { get; set; }
        string Country { get; set; }
        List<MeteorologyData> Data { get; set; }
        int GlobalIdLocal { get; set; }
        string DataUpdate { get; set; }
    }
}
