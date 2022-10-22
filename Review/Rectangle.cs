using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review
{
    public class Rectangle
    {
        public decimal length { get; set; }
        public decimal width { get; set; }

        public Rectangle (decimal length, decimal width)
        {
            this.length = length;
            this.width = width;
        }

        public decimal Perim()
        {
            return 2 * length + 2 * width;
        }

        public decimal Area()
        {
            // for test 
            //return length + width;

            return length * width; 
        }

        public override string ToString()
        {
            return $"Rectangle: Length {length}, Width {width}"; 
        }
    }
}
