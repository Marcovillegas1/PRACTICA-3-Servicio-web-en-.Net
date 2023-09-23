using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AreaWS
{
    public class Operaciones
    {

        public decimal cuadrado(decimal n1, decimal n2)
        {
            return n1 * n2;
        }
        public decimal triangulo(decimal n1, decimal n2)
        {
            var resultado = n1 * n2;
            return resultado / 2;
        }
        public double circulo(double n1)
        {
            double pi = 3.14;
            double radio2 = n1 * n1;
            return pi * radio2;
        }
    }
}