using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace newbuild
{
    public class MotherboardInfo
    {
        public required string Brand { get; set; }
        public required string Name { get; set; }
        public decimal Price { get; set; }
        public required string FormFactor { get; set; }
        public required string Socket { get; set; }
        public required string RamType { get; set; }
        public required string Color { get; set; }
        public int RamSlots { get; set; }
        public int MaxRamCapacity { get; set; }
    }



}
