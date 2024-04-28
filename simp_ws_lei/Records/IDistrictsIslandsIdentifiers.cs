using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simp_ws_lei.Records
{
    public interface IDistrictsIslandsIdentifiers
    {
        string Owner { get; set; }
        string Country { get; set; }
        List<DistrictsIslands> Data { get; set; }
        List<Item> GetIdNameRegions();
    }
}
