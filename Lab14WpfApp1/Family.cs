using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14WpfApp1
{
    public enum FamilyTypes
    {
        WallPanel,
        FloorPanel,
        Beam,
        Column
    }

    public class Family
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public FamilyTypes FamilyType { get; set; }
        public int AmountOfSamples { get; set; }
    }
}
