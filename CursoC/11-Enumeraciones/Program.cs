using System;

namespace _11_Enumeraciones
{
    class Program
    {
        static void Main()
        {
            //Declarando una enumeración y resolviendo la problemática
            Console.WriteLine("----------------------------");

            Rol tipoUsuario = Rol.Administrador;
            
            switch(tipoUsuario)
            {
                case Rol.Administrador:
                    Console.WriteLine("Administrador");
                    break;
                case Rol.Desarrolador:
                    Console.WriteLine("Desarrolador");
                    break;
                case Rol.UsuarioFinal:
                    Console.WriteLine("UsuarioFinal");
                    break;
                default:
                    Console.WriteLine("Valor incorrecto");
                    break;
            }
            //Imprimiendo los valores de una enumeración
            Console.WriteLine(tipoUsuario);
            string temporal = tipoUsuario.ToString();
            Console.WriteLine(temporal);

            //Convirtiendo una enumeración en nullable
            Rol? tipoUsuario2 = null;

            //Uso de operadores con enumeraciones
            Console.WriteLine("----------------------------");
            if (tipoUsuario==Rol.Administrador)
            {
                Console.Write("TipoUsuario: ");
                Console.WriteLine(tipoUsuario);
                tipoUsuario++;
                Console.Write("TipoUsuario después del tipoUsuario++: ");
                Console.WriteLine(tipoUsuario);

            }

            //Trabajando con los valores numéricos de una enumeración
            //Cada elemento de la enumeración se asocia a un valor entero
            Console.WriteLine("----------------------------");
            Console.Write("Valor entero del TipoUsuario: ");
            Console.WriteLine((int)tipoUsuario);

            Console.ReadLine();
        }
        //Utilizando enumeraciones como parámetros
        public static void ValidarUsuario(Rol rol)
        {

        }
    }
}