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

            //El método Parse
            string numeroEnCadena = "10";
            int valor2 = int.Parse(numeroEnCadena);
            Console.WriteLine("numeroEnCadena = " + numeroEnCadena);
            Console.WriteLine("valor2 = " + valor2);

            double valor3 = double.Parse("123,456");
            Console.WriteLine("valor3 = " + valor3);

            //Estructura try - catch
            Console.WriteLine("----------------------------");
            try
            {
                Console.WriteLine("valor / 0 =" + valor/0);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("División por 0");
                Console.WriteLine(ex.Message);
            }


            Console.WriteLine("----------------------------");
            string numeroGrande = "9999999999";
            try
            {
                int numeroConvertido = int.Parse(numeroGrande);
                Console.WriteLine(numeroConvertido);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Overflow. Número demasiado grande para int");
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("----------------------------");
            string numero = "1abc";
            try
            {
                int numeroConvertido = int.Parse(numero);
                Console.WriteLine(numero);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error de formato.");
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("----------------------------");
            try
            {
                Console.Write("Ingrese un valor: ");
                int numeroIngresado = Convert.ToInt32(Console.ReadLine());
                int resultado = 100 / numeroIngresado;
                Console.WriteLine("100 / Número ingresado = " + resultado);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }


            Console.WriteLine("----------Uso de Exception -----------");
            try
            {
                Console.Write("Ingrese un valor: ");
                int numeroIngresado2 = Convert.ToInt32(Console.ReadLine());
                int resultado2 = 100 / numeroIngresado2;
                Console.WriteLine("100 / Número ingresado = " + resultado2);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //Chequeo de operaciones aritméticas a través de checked y unchecked

            int entero = int.MaxValue;  //Tengo el mayor número int
            unchecked
            {
                entero++;               // al sumarle 1 da error
            }
            Console.WriteLine("----------------------------");
            Console.WriteLine(entero);

            //Lanzando excepciones a propósito
            Console.WriteLine("----------------------------");

            Console.Write("Ingrese un mes (1 a 12): ");
            int mes = int.Parse(Console.ReadLine());
            Console.Write("El signo zodiacal es: ");
            try
            {
                Console.WriteLine(ObtenerSignoZodiacal(mes));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Bloque finally");
            }

            Console.ReadLine();
        }

        static string ObtenerSignoZodiacal(int numeroMes)
        {
            string resultado = string.Empty;
            switch(numeroMes)
            { 
                case 1:
                resultado = "Aries";
                    break;
                case 2:
                    resultado = "Tauro";
                    break;
                case 3:
                    resultado = "Géminis";
                    break;
                case 4:
                    resultado = "Cancer";
                    break;
                case 5:
                    resultado = "Leo";
                    break;
                case 6:
                    resultado = "Virgo";
                    break;
                case 7:
                    resultado = "Libra";
                    break;
                case 8:
                    resultado = "Scorpio";
                    break;
                case 9:
                    resultado = "Sagitario";
                    break;
                case 10:
                    resultado = "Capricornio";
                    break;
                case 11:
                    resultado = "Acuario";
                    break;
                case 12:
                    resultado = "Piscis";
                    break;
                default:
                    throw new InvalidOperationException("Número de mes inválido");
                    break;
            }
            return resultado;
        }
    }
}