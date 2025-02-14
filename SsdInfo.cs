using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newbuild
{
    public class SsdInfo
    {
        public string Brand { get; set; }
        public string Name { get; set; }
        public string Interface { get; set; } // NVMe, SATA gibi
        public string Capacity { get; set; }
        public string ReadSpeed { get; set; }
        public string WriteSpeed { get; set; }
        public double Price { get; set; }
    }

}
