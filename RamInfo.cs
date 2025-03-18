using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newbuild
{
    public class RamInfo
    {
        public required string Brand { get; set; }
        public required string Name { get; set; }
        public decimal Price { get; set; }
        public int Capacity { get; set; }
        public required string RamType { get; set; }
        public int Speed { get; set; }
        public required string CompatiblePlatform { get; set; }
        public int CasLatency { get; set; }
    }
}

