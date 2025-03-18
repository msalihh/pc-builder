using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newbuild
{
    public class SsdInfo
    {
        public required string Brand { get; set; }
        public required string Name { get; set; }
        public required string Interface { get; set; } // NVMe, SATA gibi
        public required string Capacity { get; set; }
        public required string ReadSpeed { get; set; }
        public required string WriteSpeed { get; set; }
        public decimal Price { get; set; }
        public int FormFactor { get; set; }
    }

}
