using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    public class Rectangulo : Figura, Dibujable
    {
        //implementacion del metodo de la interfaz
        public void Dibujar()
        {
            if (Alto > 0)
            {
                string s = "";
                for (int x = 0; x < Ancho; ++x)
                    s += "[]";
                Console.WriteLine(s);
                if (Alto > 2)
                {
                    for (int y = 0; y < Alto - 2; ++y)
                    {
                        s = "[]";
                        for (int x = 0; x < Ancho - 2; ++x)
                            s += " ";
                        if (Ancho > 1)
                            s += "[]";
                        Console.WriteLine(s);
                    }
                }
                Console.ReadLine();
            }
            public Rectangulo(float alto, float ancho) : base(alto, ancho){ }
        }
    }
}
