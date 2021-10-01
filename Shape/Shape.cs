using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    //clase padre o base
    class Shape
    {
        //propiedades
        public string shapeColor { get; set; }
        public string shepeCoord { get; set; }


        //metodos


        public string draw()
        {
            return "La forma se a dibujado";
        }
        //overload del metodo draw
        public string draw(string shapeColor, string shepeCoord)
        {
            return "La forma de color " + shapeColor + 
                "se formo con las coordenadas " + shepeCoord; 
        }

        //este metodo se debe sobreescribir
        public virtual string draw

    }
}
