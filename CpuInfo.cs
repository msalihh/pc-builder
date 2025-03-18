using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newbuild
{
    public class CpuInfo
    {
        public int ID { get; set; }
        public required string Brand { get; set; }
        public required string Name { get; set; }
        public decimal Price { get; set; }
        public int Cores { get; set; }
        public int Threads { get; set; }
        public required string Socket { get; set; }
        public required string RamSupport { get; set; }
        public double BaseClock { get; set; }
        public double BoostClock { get; set; }
        public int TDP { get; set; }
        public int MaxRam { get; set; }
        public int Rank { get; set; }
    }
}
