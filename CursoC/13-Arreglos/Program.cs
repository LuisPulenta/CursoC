using System;

namespace _13_Arreglos
{
    class Program
    {
        static void Main(string[] args)
        {

            if(args.Length>0)
            {
                foreach (var parametro in args)
                {
                    Console.WriteLine(parametro);
                }
            }

            Console.WriteLine("----------------------------");
            string[] nombres= { "Juan", "Regina", "Ana", "Héctor", "Isaac" };
            Console.WriteLine(nombres[0]);
            Console.WriteLine(nombres[2]);
            Console.WriteLine(nombres[3]);

            Console.WriteLine("----------------------------");
            int[] numeros =new int[4] {1,2,3,4};
            //lo anteriores equivalente a poner
            int[] numeros2 = { 1, 2, 3, 4 };

            Circulo[] circulos =new Circulo[2];
            Circulo[] circulos2 = { new Circulo(20), new Circulo(5) };

            //Creando arreglos implícitamente
            Console.WriteLine("----------------------------");
            var cadenas = new[] { "Hola", "mundo" };
            var valores = new[] { 2,4,6,7,6.5 };
            //con clases anónimas
            var personas = new[]
            {
                new{Nombre="Héctor"},
                new{Nombre="Juan"}
            };

            //Accediendo a los elementos de un arreglo
            Console.WriteLine("----------------------------");
            int[] misNumeros = new int[4] { 1, 2, 3, 4 };
            int numero3 = misNumeros[2];
            Console.Write("numero3 = ");
            Console.WriteLine(numero3);
            misNumeros[2] = 500;
            Console.Write("misNumeros[2] = ");
            Console.WriteLine(misNumeros[2]);
            try
            {
                int numero5 = misNumeros[4];
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Indice incorrecto");
            }

            //Iterando a través de un arreglo
            Console.WriteLine("----------------------------");
            var tipo = misNumeros.GetType();
            int nroElementosArray = misNumeros.Length;

            for (int i=0;i<misNumeros.Length;i++)
            {
                Console.Write("El elemento "+i+" del arreglo es: ");
                Console.WriteLine(misNumeros[i]);
            }

            //El ciclo foreach
            Console.WriteLine("-----------El ciclo foreach-----------------");
            foreach(int numero in misNumeros)
            {
                Console.WriteLine(numero);
            }

            //Utilizando arreglos en los métodos
            Console.WriteLine("-----------Utilizando arreglos en los métodos-----------------");
            var datos = Inicializar();

            // Copiando arreglos
            int[] arreglo = { 3, 5, 2, 3, 3 };
            int[] arreglo2 = arreglo;           //se copia la referencia. El objeto es el mismo.
            Console.Write("arreglo[1]: ");
            Console.WriteLine(arreglo[1]);
            Console.Write("arreglo2[1]: ");
            Console.WriteLine(arreglo2[1]);
            arreglo[1] = 50;
            Console.Write("arreglo[1]: ");
            Console.WriteLine(arreglo[1]);
            Console.Write("arreglo2[1]: ");
            Console.WriteLine(arreglo2[1]);
            //Asi es como se copia un arreglo en un nuevo arreglo:
            int[] arreglo3 = new int[arreglo.Length];
            for(int i=0;i<arreglo.Length;i++)
            {
                arreglo3[i] = arreglo[i];
            }
            Console.Write("arreglo[1]: ");
            Console.WriteLine(arreglo[1]);
            Console.Write("arreglo3[1]: ");
            Console.WriteLine(arreglo3[1]);
            arreglo[1] = 100;
            Console.Write("arreglo[1]: ");
            Console.WriteLine(arreglo[1]);
            Console.Write("arreglo3[1]: ");
            Console.WriteLine(arreglo3[1]);

            //Método para copiar un arreglo en otro arreglo (Copy)
            //El tercer elemento permite definir cuantos elementos se copian
            Array.Copy(arreglo, arreglo3, arreglo.Length);
            Console.Write("arreglo[1]: ");
            Console.WriteLine(arreglo[1]);
            Console.Write("arreglo3[1]: ");
            Console.WriteLine(arreglo3[1]);

            //Otro método para copiar un arreglo en otro arreglo (Clon)
            //No se puede definir cuantos elementos se copian (se copian todos).
            int[] arreglo4 = (int[]) arreglo.Clone();
            Console.Write("arreglo[1]: ");
            Console.WriteLine(arreglo[1]);
            Console.Write("arreglo4[1]: ");
            Console.WriteLine(arreglo3[1]);

            //Arreglos_multidimensionales
            int[,] matriz = new int[4, 5];
            matriz[0, 0] = 1;
            matriz[3, 3] = 10;

            Console.ReadLine();
        }

        static void GenerarReporte(int[] datos)
        {

        }
        static int[] Inicializar()
        {
            Console.Write("N° de elementos: ");
            string respuesta = Console.ReadLine();
            int cantidad = int.Parse(respuesta);
            int[] numeros = new int[cantidad];
            for (int i = 0; i < cantidad; i++)
            {
                Console.Write("Valor para el elemento "+i+":");
                respuesta = Console.ReadLine();
                int dato = int.Parse(respuesta);
                numeros[i]= dato;
            }
            return numeros;
        }
    }
}