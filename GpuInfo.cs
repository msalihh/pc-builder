using DevExpress.Portable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newbuild
{
    public class GpuInfo
    {
        public required string Brand { get; set; }
        public required string Name { get; set; }
        public required string Memory { get; set; }
        public required string BaseClock { get; set; }
        public required string BoostClock { get; set; }
        public required string Tdp { get; set; }
        public decimal Price { get; set; }
        public int MemorySize { get; set; }
    }


}
