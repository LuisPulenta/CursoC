using System;
namespace _15_Herencia
{
    class DynamicFile:MultimediaFile
    {
        public string duracion;

        public void Reproducir()
        {
            Console.WriteLine("Reproducir");
        }

        public void Pausar()
        {
            Console.WriteLine("Pausar");
        }

        public void Detener()
        {
            Console.WriteLine("Detener");
        }
    }
}