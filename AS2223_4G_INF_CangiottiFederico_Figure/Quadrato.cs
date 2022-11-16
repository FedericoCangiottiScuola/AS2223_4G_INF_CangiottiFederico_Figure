using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS2223_4G_INF_CangiottiFederico_Figure
{
    internal class Quadrato : Figura
    {
        double lato;

        public Quadrato(double lato)
        {
            this.lato = lato;
            nome = "Quadrato";
            lati = 4;
        }

        public override double Perimetro()
        {
            return lato * 4;
        }

        public override double Area()
        {
            return lato * lato;
        }
    }
}
