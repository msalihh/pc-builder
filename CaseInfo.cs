using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newbuild
{
    public class CaseInfo
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }
        public string Psu { get; set; } // Optional
        public string SidePanel { get; set; }
        public double ExternalVolume { get; set; }
        public int Internal35Bays { get; set; }
    }

}
