using Entities;
using System.Linq;

namespace Logic{

    public class CalculaArea
    {
        public double getAreaCuadrilatero(double x, double y)
        {
            return x*y;
        }

        public double getAreaCuadrilatero(FiguraGeometrica figura)
        {

            if(figura.CantidadLados != 4 && figura.DimensionLados.Count != 2)
            {
                return 0;
            }

            double area = 1;

            figura.DimensionLados.ForEach(x => {
                area *= x;
            });

            return area;

        }

    }

}