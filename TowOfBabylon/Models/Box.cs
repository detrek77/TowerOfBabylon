using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowOfBabylon.Models 
{
    //Box implement IComparable so we can sort the array by Area
    public class Box : IComparable<Box>
    {
        public int Depth { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }

        public int Area { get; set; }

        public int CompareTo(Box? other) => other.Area - Area;
    }
}
