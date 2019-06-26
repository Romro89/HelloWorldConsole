using System.Collections.Generic; // Listas, diccionarios, tuplas

namespace Interface 
{
    public interface IFiguraGeometrica
    {
        int CantidadLados { get; set;}
        List<double> DimensionLados {get; set;}

    }
}