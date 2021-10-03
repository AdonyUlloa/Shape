using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    class Line:Shape
    {
        //propiedades
        public string radius { get; set; }

        public Line() { }

        public Line(string color, string coord, string radiusLine)
            :base(color, coord)
        {
            radius = radiusLine;
        }

    }
}
