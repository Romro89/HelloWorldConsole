using Interface;
using System.Collections.Generic;

namespace Entities
{
    public class FiguraGeometrica : IFiguraGeometrica
    {
        public int CantidadLados { get; set; }

        public List<double> DimensionLados { get; set; }

        public FiguraGeometrica (int cantidadLados, List<double> dimensionLados)
        {
            CantidadLados = cantidadLados;
            DimensionLados = dimensionLados;
        }

    }
}