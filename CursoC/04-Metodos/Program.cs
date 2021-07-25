using System;

namespace _04_Metodos
{
    class Program
    {
        static void Main()
        {
            //Que es un método
            //Console.WriteLine("01234567890123456789");
            //Console.SetCursorPosition(5, 3);
            //Console.WriteLine("01234567890123456789");

            //Console.ReadLine();
            //Console.Clear();
            //Console.ReadLine();

            //------------------------------------------------------------------------

            //Creando métodos en C#
            Console.WriteLine("Hola Mundo");

            BorrarConsola();
            Saludar("Luis");

            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Hola Mundo de nuevo");

            BorrarConsola();
            Console.Write("Ingresa tu nombre: ");
            string nombre = Console.ReadLine();
            Saludar(nombre);

            Console.Write("Ingresa Número 1: ");
            string num1 = Console.ReadLine();
            Console.Write("Ingresa Número 2: ");
            string num2 = Console.ReadLine();
            Console.WriteLine("-------------------");
            Console.Write("La Suma de Número 1 + Número 2 es: ");
            Console.WriteLine(Sumar(Convert.ToInt32(num1), Convert.ToInt32(num2)));

            EscribirPi();

            Console.Write("La Resta de Número 1 - Número 2 es: ");

            Console.WriteLine(Restar(Convert.ToInt32(num1), Convert.ToInt32(num2)));

            Console.ReadLine();
        }

        //static + Tipo de dato a retornar  + Nombre del método + parámetros
        static void BorrarConsola()
        {
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Consola borrada");
        }

        static void Saludar(string campo)
        {
            Console.WriteLine("Hola "+campo);
        }

        static int Sumar(int num1, int num2)
        {
            return num1 + num2;
        }

        static void EscribirPi() => Console.WriteLine("3.141592...");

        static int Restar(int num1, int num2) => num1 - num2;
    }
}