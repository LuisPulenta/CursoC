using System;

namespace _09_Clases
{
    class Circulo
    {
        double radio;

        public static int numeroDeCirdulos;
        public const double PI = 3.141592;

        public Circulo()
        {
            radio = 4;
            numeroDeCirdulos++;
        }

        public double CalcularPerimetro()
        {
            return 2* Math.PI * radio;
        }

        public double CalcularArea()
        {
            return Math.PI * radio* radio;
        }
    }
}