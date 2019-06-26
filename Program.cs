using System;
using Logic;
using Entities;
using System.Collections.Generic;

namespace HelloWorldConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var logic = new CalculaArea();
            var figura = new FiguraGeometrica(4, new List<double> {2, 3});

            //Console.WriteLine("Area: " + figura);
            Console.WriteLine(logic.getAreaCuadrilatero(figura));
        }
    }
}
