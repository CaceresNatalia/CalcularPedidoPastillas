using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidoPastillas
{
    class Pastilla
    {

        public string Nombre { get; set; }
        public string UxBlister { get; set; }
        public string DosisDiaria { get; set; }
        public string Blisters { get; set; }
        public string Sueltas { get; set; }
        //Acá se calcula, en base a la cantidad de blisters que quedan más las unidades sueltas, cuántas pastillas quedan.
        public float HayTotal {

            get {
                float existencias = (float.Parse(Blisters) * float.Parse(UxBlister)) + float.Parse(Sueltas);
                return existencias;
            }
        
        }
        //Esta propiedad almacena la cantidad de días en base a los que se va a calcular el pedido.
        public string Dias { get; set; }

        //Esta propiedad calcula el pedido en base a los días requeridos, la dosis diaria de c/u y las pastillas que quedan.
        public float PedidoPastillas
        {
            get
            {
                float pedido = (float.Parse(Dias) * float.Parse(DosisDiaria) - HayTotal) / float.Parse(UxBlister);
                return pedido;
            }
        }
        //Esta parte facilita mostrar en pantalla la información. Redondea la cantidad de blisters.
        public override string ToString()
        {
            return Nombre + " Hay: " + HayTotal + " pastillas, se necesita pedir, para " + Dias + " días, " + 
                Math.Ceiling(PedidoPastillas) + " blisters";
        }

    }
}
