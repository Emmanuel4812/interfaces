using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    public class Figura //implicitamente hereda de object
        {
            public float alto, ancho;
            public Figura(float alto, float ancho)
            {
                this.alto = alto;
                this.ancho = ancho;
            }
            public float Alto { get { return alto; } set { alto = value; } }
            public float Ancho { get { return ancho; } set { ancho = value; } }
            public void Mostrar()
            {
                Console.WriteLine("{0}:{1}x{2}", GetType(), Alto, Ancho);
            }
    }
    class Cuadrado : Rectangulo //hereda de Rectangulo
    {
            public Cuadrado(float lado) : base(lado, lado) {}
            public float Lado { get { return Alto; } set { Alto = ancho = value; } }  
     


    }
}
