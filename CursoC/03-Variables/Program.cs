using System;

namespace _03_Variables
{
    class Program
    {
        static void Main()
        {
            int entero = 123;
            Console.Write("Variable entero: ");
            Console.WriteLine(entero);
            Console.Write("El máximo valor Int es: ");
            Console.WriteLine(int.MaxValue);
            Console.Write("El mínimo valor Int es: ");
            Console.WriteLine(int.MinValue);
            Console.WriteLine();

            long enteroLong = 1234567890123L;
            Console.Write("Variable long: ");
            Console.WriteLine(enteroLong);
            Console.WriteLine();

            float numeroFloat = 123.01234567890123456789F;
            Console.Write("Variable float: ");
            Console.WriteLine(numeroFloat);
            Console.WriteLine();

            double numeroDouble = 123.01234567890123456789;
            Console.Write("Variable double: ");
            Console.WriteLine(numeroDouble);
            Console.WriteLine();

            decimal numeroDecimal = 123.01234567890123456789M;
            Console.Write("Variable decimal: ");
            Console.WriteLine(numeroDecimal);
            Console.WriteLine();

            Console.ReadLine();

            //Como se declara una variable
            //tipo de dato + nombre de la variable +;
            //tipo de dato + nombre de la variable + = + valor +;
            int valorEntero;
            valorEntero = 40;
            string valorCadena;
            valorCadena = "Hola ";
            int valorEntero2 = 50;
            string valorCadena2 ="Luis";
            Console.Write("Suma de valorEntero + valorEntero2: ");
            Console.WriteLine(valorEntero+valorEntero2);
            Console.Write("Concatenación de valorCadena y valorCadena2: ");
            Console.WriteLine(valorCadena + valorCadena2);
            Console.WriteLine();

            //Como se declarar varias variables de un mismo tipo
            int valorEntero3 = 60, valorEntero4 = 70, valorEntero5 = 80;
            string saludo1 = "Hola", saludo2="Adiós", saludo3 = "Chau";

            //Conociendo los tipos de datos bool, char y string
            bool esCliente;
            esCliente = false;
            Console.Write("Valor de la variable esCliente: ");
            Console.WriteLine(esCliente);
            Console.WriteLine();

            string nombreCliente;
            nombreCliente = "Luis";
            Console.Write("Valor de la variable nombreCliente: ");
            Console.WriteLine(nombreCliente);
            Console.WriteLine();

            char caracter;
            caracter = 'M';
            Console.Write("Valor de la variable caracter: ");
            Console.WriteLine(caracter);
            Console.WriteLine();

            

            //Operadores aritméticos
            // + - * /
            int num1=50, num2= 12;
            int suma = num1 + num2;
            int resta = num1 - num2;
            int multiplicación = num1 * num2;
            int division = num1 / num2;
            Console.Write("Valor de la suma: ");
            Console.WriteLine(suma);
            Console.WriteLine();
            Console.Write("Valor de la resta: ");
            Console.WriteLine(resta);
            Console.WriteLine();
            Console.Write("Valor de la multiplicación: ");
            Console.WriteLine(multiplicación);
            Console.WriteLine();
            Console.Write("Valor de la division: ");
            Console.WriteLine(division);
            Console.WriteLine();
            
            //Concatenando cadenas
            string nombre = "Luis", apellido = "Núñez";
            Console.Write("Concatenación de las variables nombre y apellido: ");
            Console.WriteLine(nombre+" "+apellido);
            Console.WriteLine();

            Console.Write("Concatenación de dos char 'A' da como resultado la suma de los códigos Ascii: ");
            Console.WriteLine('A'+'A');
            Console.WriteLine();

            Console.Write("División entre 16 y 3 como enteros: ");
            Console.WriteLine(16/3);
            Console.WriteLine();

            Console.Write("División entre 16 y 3 como doubles: ");
            Console.WriteLine(16.0 / 3.0);
            Console.WriteLine();

            //Operador residuo
            int numero1 = 16;
            int numero2 = 3;
            Console.Write("División entre 16 y 3: ");
            Console.WriteLine(numero1/numero2);
            Console.WriteLine();

            Console.Write("Residuo de dividir entre 16 y 3: ");
            Console.WriteLine(numero1 % numero2);
            Console.WriteLine();

            //Números infinitos y NaN
            double infinito = 5.0 / 0.0;
            Console.Write("Variable infinito: ");
            Console.WriteLine(infinito);
            Console.WriteLine();

            Console.Write("0/0: ");
            Console.WriteLine(0.0/0.0);
            Console.WriteLine();

            //Precedencia y Asociatividad
            Console.Write("5+10*2: ");
            Console.WriteLine(5+10*2);
            Console.WriteLine();

            Console.Write("(5+10)*2: ");
            Console.WriteLine((5 + 10) * 2);
            Console.WriteLine();

            //Incremento y Decremento de Variables
            int j = 1;
            Console.Write("j: ");
            Console.WriteLine(j);
            Console.WriteLine();
            j++;
            Console.Write("j++: ");
            Console.WriteLine(j);
            Console.WriteLine();
            j--;
            Console.Write("j--: ");
            Console.WriteLine(j);
            Console.WriteLine();

            //Variables locales declaradas implícitamente
            var variable = 5.0m;
            Console.Write("variable var: ");
            Console.WriteLine(variable);

            Console.ReadLine();
        }
    }
}