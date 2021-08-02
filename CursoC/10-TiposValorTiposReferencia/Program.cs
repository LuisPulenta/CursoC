using System;

namespace _10_TiposValorTiposReferencia
{
    class Program
    {
        static void Main()
        {
            //Tipos por valor
            Console.WriteLine("----------------------------");
            int valor1 = 50;
            int valor2 = valor1;
            Console.Write("Valor1 = ");
            Console.WriteLine(valor1);
            Console.Write("Valor2 = ");
            Console.WriteLine(valor2);
            valor1++;
            Console.Write("Valor1 después de valor1++= ");
            Console.WriteLine(valor1);
            Console.Write("Valor2 después de valor1++= ");
            Console.WriteLine(valor2);
            
            //Tipos por referencia
            Console.WriteLine("----------------------------");
            Circulo circ1 = new Circulo();
            circ1.radio = 50;
            Circulo circ2 = circ1;
            Console.Write("circ1.radio = ");
            Console.WriteLine(circ1.radio);
            Console.Write("circ2.radio = ");
            Console.WriteLine(circ2.radio);
            circ1.radio++;
            Console.Write("circ1.radio depués de circ1.radio++ = ");
            Console.WriteLine(circ1.radio);
            Console.Write("circ2.radio depués de circ1.radio++ = ");
            Console.WriteLine(circ2.radio);

            Console.WriteLine("----------------------------");
            int numero1 = 0;
            Console.Write("numero1 = ");
            Console.WriteLine(numero1);
            AgregarUno(numero1);
            Console.Write("numero1 despues de AgregarUno = ");
            Console.WriteLine(numero1);


            Console.WriteLine("----------------------------");
            Circulo circulo = new Circulo(); ;
            Console.Write("circulo.radio = " + circulo?.radio);


            Console.WriteLine("----------------------------");
            int? i = null;
            DateTime? fecha = null;
            i = 10;
            int j = 10;
            j = (int) i;

            if(i.HasValue)
            {
                Console.WriteLine("i tiene un valor");
                Console.WriteLine(i.Value);
            }


            //Definiendo parámetros ref
            Console.WriteLine("----------------------------");
            int num = 10;
            AgregarUno(ref num);
            Console.Write("num = ");
            Console.WriteLine(num);

            //Definiendo parámetros out
            Console.WriteLine("----------------------------");
            int num2;
            AgregarUno_out(out num2);
            Console.Write("num2 = ");
            Console.WriteLine(num2);

            int.TryParse("hola", out int pruebaconversion1);
            Console.Write("pruebaconversion1 = ");
            Console.WriteLine(pruebaconversion1);
            int.TryParse("1234", out int pruebaconversion2);
            Console.Write("pruebaconversion2 = ");
            Console.WriteLine(pruebaconversion2);

            //La clase System.Object
            object entero = 13;
            object cadena = "Hola";
            object circulo3 = new Circulo();


            //Boxing y Unboxing
            Console.WriteLine("----------------------------");
            int valorb = 50;
            object objeto2 = valorb;
            int otroValor2 = (int)objeto2;
            Console.Write("otroValor2 = ");
            Console.WriteLine(otroValor2);


            //Los operadores is y as
            Console.WriteLine("----------------------------");
            int valor = 50;
            object objeto = valor;
            if (objeto is int)
            {
                int otroValor = (int)objeto;
                Console.Write("otroValor = ");
                Console.WriteLine(otroValor);
            }
            else if (objeto is string)
            {
                string otraCadena = (string)objeto;
                Console.Write("otraCadena = ");
                Console.WriteLine(otraCadena);
            }

            objeto = "Luis";
            string cadenaNueva = objeto as string;
            Console.Write("cadenaNueva = ");
            Console.WriteLine(cadenaNueva);


            Console.ReadLine();
        }

        public static void AgregarUno(int param1)
        {
            param1++;
        }

        public static void AgregarUno(ref int param1)
        {
            param1++;
        }

        public static void AgregarUno_out(out int param1)
        {
            param1 = 0;
            param1++;
        }
    }
}