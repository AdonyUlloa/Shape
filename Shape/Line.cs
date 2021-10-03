using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//ESTUDIANTES
//EDWIN ADONY ULLOA DIAZ
//ALFREDO JOSE ZELAYA LAINEZ

namespace Shape
{
    class Line:Shape
    {

        public Double length { get; set; }

        //Constructor de la clase Line
        public Line()
        { }

        //Usar constructor heredado
        public Line(string color, Boolean coord, double Linelength)
            : base(color, coord)
        {
            length = Linelength;
        }

        //Método heredado y sobreescrito
        public override string draw()
        {
            return "La línea ha sido dibujada con una longitud de: " + length;
        }
    }
}
