using System;

namespace _05_Metodos2
{
    class Program
    {
        static int valorGlobal = 0;

        static void Main()
        {
            Console.Write("valorGlobal: ");
            Console.WriteLine(valorGlobal);
            valorGlobal++;
            Console.Write("valorGlobal: ");
            Console.WriteLine(valorGlobal);

            Console.Write("Ingresa Dividendo: ");
            string num1 = Console.ReadLine();
            Console.Write("Ingresa Divisor: ");
            string num2 = Console.ReadLine();

            int dividendo = Convert.ToInt32(num1);
            int divisor = Convert.ToInt32(num2);

            Console.WriteLine("-------------------");

            int cociente = 0, residuo = 0;
            (cociente, residuo) = Dividir(dividendo, divisor);

            Console.Write("El cociente es: ");
            Console.WriteLine(cociente);

            Console.Write("El residuo es: ");
            Console.WriteLine(residuo);

            //Otra forma
            Console.WriteLine("-------------------");
            (int cociente2, int residuo2) data = Dividir(100, 40);
            Console.Write("El cociente es: ");
            Console.WriteLine(data.cociente2);

            Console.Write("El residuo es: ");
            Console.WriteLine(data.residuo2);


            Console.Write("Multiplicar 2 enteros -> 8x5=: ");
            Console.WriteLine(Multiplicar(8, 5));

            Console.Write("Multiplicar 2 doubles -> 8.123 x 2.245=: ");
            Console.WriteLine(Multiplicar(8.123, 2.245));

            Console.Write("Cuenta sin estacionamiento: ");
            Console.WriteLine(CalcularCuenta(100, 20, 3));

            Console.Write("Cuenta con estacionamiento: ");
            Console.WriteLine(CalcularCuenta(100, 20, 3, 30));

            Console.Write("Cuenta sin estacionamiento: ");
            Console.WriteLine(CalcularCuenta2(100, 20, 3));

            Console.Write("Cuenta con estacionamiento: ");
            Console.WriteLine(CalcularCuenta2(100, 20, 3, 30));

            Console.Write("Cuenta sin estacionamiento: ");
            Console.WriteLine(CalcularCuenta3(100, 20, 3, iva: 30));

            Console.Write("Cuenta con estacionamiento: ");
            Console.WriteLine(CalcularCuenta3(100, 20, 3, 30, iva: 30));

            EscribirTexto("Viva Talleres!!!");

            CalcularAreaCuadrado(20, "Luis", 50m, true);
            NewMethod();

            Console.ReadLine();
        }

        private static void NewMethod()
        {
            Console.WriteLine("----------------");
            Console.WriteLine("ALERTA!!!");
            Console.WriteLine("----------------");
        }

        private static void CalcularAreaCuadrado(int v1, string v2, decimal v3, bool v4)
        {
            throw new NotImplementedException();
        }

        static (int,int) Dividir(int dividendo, int divisor)
        {
            int cociente = dividendo / divisor;
            int residuo = dividendo % divisor;
            return (cociente, residuo);
        }

        static (int,string,bool) RegresarDatos()
        {
            return (56, "Luis", true);
        }

        static int Multiplicar(int num1,int num2)
        {
            return num1*num2;
        }

        static double Multiplicar(double num1, double num2)
        {
            return num1 * num2;
        }

        static double CalcularCuenta(double totalCuenta, double propina, int clientes)
        {
            return (totalCuenta+propina)/ clientes;
        }

        static double CalcularCuenta(double totalCuenta, double propina, int clientes,double estacionamiento )
        {
            return (totalCuenta + propina + estacionamiento) / clientes;
        }

        static double CalcularCuenta2(double totalCuenta, double propina, int clientes, double estacionamiento = 0)
        {
            return (totalCuenta + propina + estacionamiento) / clientes;
        }

        static double CalcularCuenta3(double totalCuenta, double propina, int clientes, double estacionamiento = 0,double iva =15)
        {
            return (totalCuenta + propina + estacionamiento) / clientes;
        }

        static void EscribirTexto(string texto)
        {
            Console.WriteLine(texto);
            Limpiar();

            void Limpiar()
            {
                Console.ReadLine();
                Console.Clear();
            }

        }
    }
}