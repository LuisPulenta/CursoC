using System;

namespace _14_Params
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------");
            int suma = Sumar(1, 2, 3, "4");
            Console.Write("La suma es: ");
            Console.WriteLine(suma);


            Console.ReadLine();
        }
       
        static int Sumar(params object [] numeros)
        {
           int suma = 0;
            foreach(var numero in numeros)
            {
                if(numero is int)
                {
                    suma += (int)numero;
                }
                else if (numero is string)
                {
                    bool convertido = int.TryParse((string)numero, out int temporal);
                    if (convertido)
                    {
                        suma += temporal;
                    }
                    else
                    {
                        throw new Exception("Valor no numérico");
                    }
                }
                else
                {
                    throw new Exception("Valor no numérico");
                }
            }
            return suma;
        }
    }
}