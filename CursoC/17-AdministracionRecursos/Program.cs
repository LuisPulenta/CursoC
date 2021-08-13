using System;

namespace _17_AdministracionRecursos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------");
            FileManager manager1 = new FileManager(@"C:\ElCaminoDev\01-Curso C\CursoC\17-AdministracionRecursos\prueba.txt");
            

            
            //FileManager manager2 = new FileManager(@"C:\ElCaminoDev\01-Curso C\CursoC\17-AdministracionRecursos\prueba.txt");
            Console.ReadLine();
        }
    }
}