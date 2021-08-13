using System;

namespace _16_InterfasesAbstractas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------");

            Circulo c = new Circulo();
            IFigura f1= c;
            f1.Dibujar();
            IRenderizador r1 = c;
            r1.Dibujar();

            Linea l = new Linea();

            IFigura f = c;
            f = l;

            f.Dibujar();

            
            l.Dibujar();

            Console.WriteLine(1);
            Console.ReadLine();
        }

        static void CalcularArea(IFigura figura)
        {
            if(figura is Circulo)
            {
                figura.Dibujar();
            }
            else if (figura is Linea)
            {
                figura.Dibujar();
            }
        }
    }
}