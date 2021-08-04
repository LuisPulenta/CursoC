using System;

namespace _15_Herencia
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("----------------------------");
            MultimediaFile mFile = new MultimediaFile();
            mFile.DesplegarInformacion();
            var fecha = mFile.fechaCreacion;
            

            DynamicFile dFile = new DynamicFile();
            dFile.DesplegarInformacion();
            var fecha2 = dFile.fechaCreacion;
            dFile.Reproducir();
            dFile.Pausar();
            dFile.Detener();
            var duracion = dFile.duracion;
            

            StaticFile sFile = new StaticFile();
            sFile.DesplegarInformacion();
            var fecha3 = sFile.fechaCreacion;
            sFile.Editar();

            //Reexaminando la clase System.Object
            mFile.ToString();
            sFile.GetType();

            Console.ReadLine();
        }
    }
}