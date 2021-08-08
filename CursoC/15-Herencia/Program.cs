using System;

namespace _15_Herencia
{
    class Program
    {
        static void Main()
        {
            //Console.WriteLine("----------------------------");
            //MultimediaFile multimedia;
            //DynamicFile dFile = new DynamicFile();
            //StaticFile sFile = new StaticFile();
            //OtherFile oFile = new OtherFile();

            //multimedia = dFile;
            //Console.WriteLine(multimedia.ObtenerTipo());
            //multimedia = sFile;
            //Console.WriteLine(multimedia.ObtenerTipo());
            //multimedia = oFile;
            //Console.WriteLine(multimedia.ObtenerTipo());

            string prueba = "Esta es una demo de los métodos de extensión";
            MetodosExtension.ContarPalabras(prueba);

            int cantPalabras = prueba.ContarPalabras();

            Console.WriteLine(cantPalabras);

            Console.ReadLine();
        }
    }
}