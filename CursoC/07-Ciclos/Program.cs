using System;

namespace _07_Ciclos
{
    class Program
    {
        static void Main()
        {
            //Operador de asignación compuesto
            int variable1 = 50;
            int variable2 = 50;
            int variable3 = 50;
            int variable4 = 50;
            int variable5 = 50;
            string texto = "Soy un programador";
            variable1 += 3;
            variable2 -= 3;
            variable3 *= 3;
            variable4 /= 3;
            variable5 %= 3;
            texto += " de C#";
            Console.WriteLine("----------------------------");
            Console.Write("variable1: ");
            Console.WriteLine(variable1);
            Console.Write("variable2: ");
            Console.WriteLine(variable2);
            Console.Write("variable3: ");
            Console.WriteLine(variable3);
            Console.Write("variable4: ");
            Console.WriteLine(variable4);
            Console.Write("variable5: ");
            Console.WriteLine(variable5);
            Console.Write("texto: ");
            Console.WriteLine(texto);

            //Ciclo While
            Console.WriteLine("-------------While---------------");
            Console.WriteLine("*** Tabla del 2 ***");
            int i = 1;
            while (i<=10)
            {
                Console.WriteLine("2 x "+i+" = "+2*i );
                i++;
            }

            Console.WriteLine("-------------While---------------");
            Console.WriteLine("*** Suma de los primeros 10 números ***");
            int resultado = 0;
            int j = 1;
            while (j <= 10)
            {
                resultado += j;
                j++;
            }
            Console.WriteLine("Resultado = " + resultado);

            Console.WriteLine("-------------While---------------");
            Console.WriteLine("*** Termina cuando se ingresa 'Salir' ***");
            string input = string.Empty;
            while (input !="salir")
            {
                Console.WriteLine("Ejecutando");
                input = Console.ReadLine();
            }

            //Ciclo for
            Console.WriteLine("----------for---------------");
            Console.WriteLine("*** Tabla del 2 ***");
            for (int k=1; k<= 10; k++)
            {
                Console.WriteLine("2 x " + k + " = " + 2 * k);
            }

            Console.WriteLine("----------for---------------");
            Console.WriteLine("*** Suma de los primeros 10 números ***");
            int resul = 0;
            for (int k2 = 1; k2 <= 10; k2++)
            {
                resul += k2;
                j++;
            }
            Console.WriteLine("Resultado = " + resul);

            Console.WriteLine("----------for---------------");
            Console.WriteLine("*** for con 2 variables ***");
            for (int p = 1, q = 10; p <= q; p++,q--)
            {
                Console.WriteLine("p - q - p+q: " + p + " " + q + " " + (p+q));
            }

            //Ciclo Do While
            Console.WriteLine("-------------Do While---------------");
            Console.WriteLine("*** Tabla del 2 ***");
            int m = 1;
            do
            {
                Console.WriteLine("2 x " + m + " = " + 2 * m);
                m++;
            }
            while (m <= 10);

            Console.WriteLine("-------------Do While---------------");
            Console.WriteLine("*** Suma de los primeros 10 números ***");
            int result = 0;
            int n = 1;
            do
            {
                result += n;
                n++;
            }
            while (n <= 10);
            Console.WriteLine("Resultado = " + result);

            Console.WriteLine("-------------Do While ---------------");
            Console.WriteLine("*** Termina cuando se ingresa 'Salir' ***");
            string input2 = string.Empty;
            do
            {
                Console.WriteLine("Ejecutando");
                input2 = Console.ReadLine();
            }
            while (input2 != "salir");

            Console.ReadLine();
        }
    }
}