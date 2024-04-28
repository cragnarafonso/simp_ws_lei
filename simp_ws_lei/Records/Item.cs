using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simp_ws_lei.Records
{
    public class Item
    {
        public int Id { get; set; }
        public string Value { get; set; }

        public Item(int id, string value)
        {
            Id = id;
            Value = value;
        }
    }
}
