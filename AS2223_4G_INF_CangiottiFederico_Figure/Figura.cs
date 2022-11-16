using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS2223_4G_INF_CangiottiFederico_Figure
{
    internal class Figura
    {
        protected string? nome;
        protected int lati;

        protected Figura()
        {
            nome = "Figura generica";
            lati = 0;
        }

        public virtual double Perimetro()
        {
            return 0;
        }

        public virtual double Area()
        {
            return 0;
        }
    }
}
