using System;

namespace _16_InterfasesAbstractas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------");
            Circulo c = new Circulo();
            Linea l = new Linea();

            c.Dibujar();
            l.Dibujar();

            Console.WriteLine(1);
            Console.ReadLine();
        }
    }
}