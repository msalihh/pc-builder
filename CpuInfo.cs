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
        public string Brand { get; set; }
        public string Name { get; set; }
        public int Cores { get; set; }
        public int TDP { get; set; }
        public string Socket { get; set; }
        public string RamSupport { get; set; }
        public int MaxRam { get; set; }
        public int Rank { get; set; }
        public double Price { get; set; }


    }
}
