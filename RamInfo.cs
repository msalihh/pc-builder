using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newbuild
{
    public class RamInfo
    {
        public string Brand { get; set; }      // Marka
        public string Name { get; set; }       // Model
        public int MaxCapacity { get; set; }   // Kapasite (GB)
        public string RamType { get; set; }    // RAM Tipi (DDR4, DDR5)
        public int Speed { get; set; }         // Hız (MHz)
        public string CompatiblePlatform { get; set; }
        public double Price { get; set; }      // Fiyat
    }



}

