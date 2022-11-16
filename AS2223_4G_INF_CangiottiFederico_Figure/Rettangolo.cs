using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS2223_4G_INF_CangiottiFederico_Figure
{
    internal class Rettangolo : Figura
    {
        double b;
        double altezza;

        public Rettangolo(double b, double altezza)
        {
            this.b = b;
            this.altezza = altezza;
            nome = "Rettangolo";
            lati = 4;
        }

        public override double Perimetro()
        {
            return b * 2 + altezza * 2;
        }

        public override double Area()
        {
            return b * altezza;
        }

        public string NomeFigura
        {
            get { return nome; }
        }
    }
}
