using System;

namespace _08_Excepciones
{
    class Program
    {
        static void Main()
        {
            int valor = 10;
            //Console.WriteLine("----------------------------");
            //Console.WriteLine("valor / 0 =" + valor/0);

            string numeroEnCadena = "10";
            int valor2 = int.Parse(numeroEnCadena);
            Console.WriteLine("numeroEnCadena = " + numeroEnCadena);
            Console.WriteLine("valor2 = " + valor2);

            double valor3 = double.Parse("123,456");
            Console.WriteLine("valor3 = " + valor3);

            Console.ReadLine();

        }
    }
}
