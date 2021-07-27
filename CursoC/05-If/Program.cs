using System;

namespace _06_If
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables booleanas
            bool mayorDeEdad = true;
            bool esHombre;
            esHombre = false;
            Console.WriteLine("----------------------------");
            Console.Write("Es mayor de edad?: ");
            Console.WriteLine(mayorDeEdad);
            Console.Write("Es hombre?: ");
            Console.WriteLine(esHombre);

            //Operador Not
            bool variableBooleana = true;
            Console.WriteLine("----------------------------");
            Console.Write("variableBooleana: ");
            Console.WriteLine(variableBooleana);
            Console.Write("variableBooleana negada: ");
            Console.WriteLine(!variableBooleana);

            //Operadores de igualdad y de desigualdad
            bool VariableVerdadera = 5 == 5;
            bool VariableFalsa = 5 != 5;
            Console.WriteLine("----------------------------");
            Console.Write("VariableVerdadera: ");
            Console.WriteLine(VariableVerdadera);
            Console.Write("VariableFalsa: ");
            Console.WriteLine(VariableFalsa);

            //Operadores Relacionales
            Console.WriteLine("----------------------------");
            Console.Write("Es 5>=3? : ");
            Console.WriteLine(5>=3);
            Console.Write("Es 5<3? : ");
            Console.WriteLine(5 < 3);
            Console.Write("Es 5=5? : ");
            Console.WriteLine(5 == 5);
            Console.Write("Es 5=3? : ");
            Console.WriteLine(5 == 3);

            //Operadores Lógicos
            //AND &&
            //OR ||
            Console.WriteLine("----------------------------");
            Console.Write("Es 5>=3 y 3>1? : ");
            Console.WriteLine(5 >= 3 && 3>1);
            Console.Write("Es 5<=3 o 3<1? : ");
            Console.WriteLine(5 <= 3 || 3 < 1);

            //La Sentencia de control if
            Console.WriteLine("----------------------------");
            Console.Write("Ingrese num1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese num2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if(num1==num2)
            {
                Console.WriteLine("Es num1=num2? : SI");
            }
            else
            {
                Console.WriteLine("Es num1=num2? : NO");

            }

            //Evaluando varios casos con if else
            Console.WriteLine("----------------------------");
            Console.Write("Ingrese número de 0 a 6: ");
            int dia = Convert.ToInt32(Console.ReadLine());
            if (dia==0)
            {
                Console.WriteLine("El día "+dia+" es Lunes" );
            }
            else if (dia == 1)
            {
                Console.WriteLine("El día " + dia + " es Martes");
            }
            else if (dia == 2)
            {
                Console.WriteLine("El día " + dia + " es Miércoles");
            }
            else if (dia == 3)
            {
                Console.WriteLine("El día " + dia + " es Jueves");
            }
            else if (dia == 4)
            {
                Console.WriteLine("El día " + dia + " es Viernes");
            }
            else if (dia == 5)
            {
                Console.WriteLine("El día " + dia + " es Sábado");
            }
            else if (dia == 6)
            {
                Console.WriteLine("El día " + dia + " es Domingo");
            }
            else
            {
                Console.WriteLine("El número ingresado no es válido");
            }

            //La sentencia de control Switch
            Console.WriteLine("----------------------------");
            Console.Write("Ingrese número de 0 a 6: ");
            int dia2 = Convert.ToInt32(Console.ReadLine());

            switch(dia2)
            {
                case 0: Console.WriteLine("El día " + dia2 + " es Lunes");
                    break;
                case 1:
                    Console.WriteLine("El día " + dia2 + " es Martes");
                    break;
                case 2:
                    Console.WriteLine("El día " + dia2 + " es Miércoles");
                    break;
                case 3:
                    Console.WriteLine("El día " + dia2 + " es Jueves");
                    break;
                case 4:
                    Console.WriteLine("El día " + dia2 + " es Viernes");
                    break;
                case 5:
                    Console.WriteLine("El día " + dia2 + " es Sábado");
                    break;
                case 6:
                    Console.WriteLine("El día " + dia2 + " es Domingo");
                    break;
                default:
                    Console.WriteLine("El número ingresado no es válido");
                    break;
            }

            //Otro ejemplo de Switch
            Console.WriteLine("----------------------------");
            Console.Write("Ingrese un caracter: ");
            char caracter = Convert.ToChar(Console.ReadLine());
            switch (caracter)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'p':
                    Console.WriteLine("Es una VOCAL");
                    break;
                default:
                    Console.WriteLine("NO ES una VOCAL");
                    break;
            }

            Console.ReadLine();
        }
    }
}